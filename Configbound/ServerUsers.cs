using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Configbound {
	public partial class ServerUsersForm : Form {
		public static ServerUser SelectedUser { get; set; }
		List<ServerUser> serverUsers = new List<ServerUser>();

		public ServerUsersForm() {
			InitializeComponent();
		}

		private void ServerUsers_Load(object sender, EventArgs e) { PopulateList(); }

		private void btnAdd_Click(object sender, EventArgs e) {
			ServerUserEditForm frmServerUserEdit = new ServerUserEditForm();
			frmServerUserEdit.ShowDialog(this);
		}

		private void btnEdit_Click(object sender, EventArgs e) {
			if (SelectedUser != null) {
				ServerUserEditForm frmServerUserEdit = new ServerUserEditForm();
				frmServerUserEdit.ShowDialog(this);
			}
		}

		private void btnAdmin_Click(object sender, EventArgs e) {
			if (SelectedUser != null) {
				SelectedUser.IsAdmin = !SelectedUser.IsAdmin;
				ListViewItem.ListViewSubItem userAdmin = lstServerUsers.SelectedItems[0].SubItems[colAdmin.Index];
				userAdmin.Text = SelectedUser.IsAdmin ? "✓" : "";
			}
		}

		private void btnRemove_Click(object sender, EventArgs e) {
			if (SelectedUser != null) {
				serverUsers.Remove(SelectedUser);
				lstServerUsers.Items.Remove(lstServerUsers.SelectedItems[0]);
			}
		}

		private void lstServerUsers_SelectedIndexChanged(object sender, EventArgs e) {
			if (serverUsers.Count > 0 && lstServerUsers.SelectedIndices.Count == 1) {
				ListViewItem selectedUser = lstServerUsers.SelectedItems[0];
				ServerUser srv = serverUsers.Find(x => x.Username == selectedUser.Text);
				SelectedUser = srv ?? throw new Exception("No results for " + selectedUser.Text);
			} else {
				SelectedUser = null;
			}
		}

		private void ServerUsersForm_FormClosing(object sender, FormClosingEventArgs e) {

		}

		public void ApplySelectedUserChanges() {
			ListViewItem.ListViewSubItem userName = lstServerUsers.SelectedItems[0].SubItems[colUsername.Index];
			ListViewItem.ListViewSubItem userPassword = lstServerUsers.SelectedItems[0].SubItems[colPassword.Index];
			ListViewItem.ListViewSubItem userAdmin = lstServerUsers.SelectedItems[0].SubItems[colAdmin.Index];
			userName.Text = SelectedUser.Username;
			userPassword.Text = SelectedUser.Password;
			userAdmin.Text = SelectedUser.IsAdmin ? "✓" : "";
		}

		private void PopulateList() {
			foreach (JProperty user in StarConfig.ServerUsers.Properties()) {
				ServerUser su = new ServerUser(user);
				if (serverUsers.Find(x => x.Username == su.Username) == null) {
					serverUsers.Add(su);

					ListViewItem li = new ListViewItem(su.Username);
					li.SubItems.Add(su.Password);
					li.SubItems.Add(su.IsAdmin ? "✓" : "");
					lstServerUsers.Items.Add(li);
				}
			}
		}

		public class ServerUser {
			JProperty _jprop;

			public ServerUser(JProperty user) {
				_jprop = user;
			}

			public string Username {
				get { return _jprop.Name; }
				set { _jprop = new JProperty(value, _jprop.Value); }
			}

			public string Password {
				get { return _jprop.Value.Value<string>("password"); }
				set { ((dynamic)_jprop.Value).password = value; }
			}

			public bool IsAdmin {
				get { return _jprop.Value.Value<bool>("admin"); }
				set { ((dynamic)_jprop.Value).admin = value; }
			}
		}
	}
}
