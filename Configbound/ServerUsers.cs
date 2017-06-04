using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Configbound {
	public partial class ServerUsersForm : Form {
		public static KeyValuePair<string, JToken>? SelectedUser = null;

		public ServerUsersForm() {
			InitializeComponent();
		}

		private void ServerUsers_Load(object sender, EventArgs e) {
			PopulateList();
			btnAdd.Enabled = true;
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			// Hacky way to deselect ListView items; will fix it later ¯\_(ツ)_/¯
			PopulateList();

			ServerUserEditForm frmServerUserEdit = new ServerUserEditForm(false);
			frmServerUserEdit.ShowDialog(this);
		}

		private void btnEdit_Click(object sender, EventArgs e) {
			if (SelectedUser != null) {
				ServerUserEditForm frmServerUserEdit = new ServerUserEditForm(true);
				frmServerUserEdit.ShowDialog(this);
			}
		}

		private void btnAdmin_Click(object sender, EventArgs e) {
			if (SelectedUser != null) {
				dynamic tmp = SelectedUser.Value.Value;
				tmp.admin = !(bool)tmp.admin;

				ListViewItem.ListViewSubItem userAdmin = lstServerUsers.SelectedItems[0].SubItems[colAdmin.Index];
				userAdmin.Text = (bool)tmp.admin ? "✓" : "";
			}
		}

		private void btnRemove_Click(object sender, EventArgs e) {
			if (SelectedUser != null) {
				Globals.StarboundSettings.serverUsers.additionalData.Remove(SelectedUser.Value.Key);
				lstServerUsers.Items.Remove(lstServerUsers.SelectedItems[0]);
				SelectedUser = null;
			}
		}

		private void lstServerUsers_SelectedIndexChanged(object sender, EventArgs e) {
			if (Globals.StarboundSettings.serverUsers.additionalData.Keys.Count > 0 && lstServerUsers.SelectedIndices.Count == 1) {
				ListViewItem selection = lstServerUsers.SelectedItems[0];
				SelectedUser = new KeyValuePair<string, JToken>(selection.Text, Globals.StarboundSettings.serverUsers.additionalData[selection.Text]);
			} else {
				SelectedUser = null;
			}

			btnEdit.Enabled = btnAdmin.Enabled = btnRemove.Enabled = SelectedUser != null;
		}

		public void PopulateList() {
			SelectedUser = null;
			btnEdit.Enabled = btnAdmin.Enabled = btnRemove.Enabled = false;
			lstServerUsers.Items.Clear();
			foreach (string userName in Globals.StarboundSettings.serverUsers.additionalData.Keys) {
				dynamic user = Globals.StarboundSettings.serverUsers.additionalData[userName];

				ListViewItem li = new ListViewItem(userName);
				li.SubItems.Add((string)user.password);
				li.SubItems.Add((bool)user.admin ? "✓" : "");
				lstServerUsers.Items.Add(li);
			}
		}
	}
}
