using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Configbound {
	public partial class ServerUsers : Form {
		List<ServerUser> serverUsers = new List<ServerUser>();

		public ServerUsers() {
			InitializeComponent();
		}

		private void ServerUsers_Load(object sender, EventArgs e) {
			foreach (KeyValuePair<string, Newtonsoft.Json.Linq.JToken> user in StarConfig.ServerUsers) {
				ServerUser su = new ServerUser(user.Key, user.Value.Value<string>("password"), user.Value.Value<bool>("admin"));
				serverUsers.Add(su);

				ListViewItem li = new ListViewItem(su.Username);
				li.SubItems.Add(su.Password);
				li.SubItems.Add(su.IsAdmin ? "✓" : "");
				lstServerUsers.Items.Add(li);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			ServerUserEdit frmServerUserEdit = new ServerUserEdit();
			frmServerUserEdit.ShowDialog();
		}

		private void btnEdit_Click(object sender, EventArgs e) {
			if (UserIsSelected) {
				ServerUserEdit frmServerUserEdit = new ServerUserEdit();
				frmServerUserEdit.ShowDialog();
			}
		}

		private void btnAdmin_Click(object sender, EventArgs e) {
			if (UserIsSelected) {

			}
		}

		private void btnRemove_Click(object sender, EventArgs e) {
			if (UserIsSelected) {
				ListViewItem selectedUser = lstServerUsers.SelectedItems[0];
				IEnumerable<ServerUser> results = (from user in serverUsers
												   where user.Username == selectedUser.Text
												   select user);
				if (results.Count() == 0) {
					throw new Exception("No results for " + selectedUser.Text);
				} else if (results.Count() > 1) {
					throw new Exception("Unimplemented! (Safe to continue)\n More than one serverUsers record for " + selectedUser.Text);
				} else {
					ServerUser su = results.First();
					serverUsers.Remove(su);
					lstServerUsers.Items.Remove(lstServerUsers.SelectedItems[0]);
				}
			}
		}

		private bool UserIsSelected {
			get { return serverUsers.Count > 0 && lstServerUsers.SelectedIndices.Count == 1; }
		}

		class ServerUser {
			public ServerUser(string username, string password, bool admin) {
				Username = username;
				Password = password;
				IsAdmin = admin;
			}

			public string Username { get; set; }
			public string Password { get; set; }
			public bool IsAdmin { get; set; }

			public override string ToString() {
				return Username + " : " + Password + " : " + IsAdmin;
			}
		}
	}
}
