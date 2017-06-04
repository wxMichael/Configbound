using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Configbound {
	public partial class ServerUserEditForm : Form {
		bool _isEditing;

		public ServerUserEditForm(bool isEditing) {
			_isEditing = isEditing;
			InitializeComponent();
		}

		private void ServerUserEdit_Load(object sender, EventArgs e) {
			if (_isEditing) {
				txtUsername.Text = ServerUsersForm.SelectedUser.Value.Key;
				txtPassword.Text = ((dynamic)ServerUsersForm.SelectedUser.Value.Value).password;
				chkAdmin.Checked = ((dynamic)ServerUsersForm.SelectedUser.Value.Value).admin;
			}
		}

		private void btnSaveUser_Click(object sender, EventArgs e) {
			string nameTrimmed = txtUsername.Text.Trim();
			string passTrimmed = txtPassword.Text.Trim();

			if (nameTrimmed == String.Empty | passTrimmed == String.Empty) {
				MessageBox.Show("Please enter both a name and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Detect Name Conflicts
			bool nameConflict = false;
			bool nameChanged = false;
			bool nameTypedExistsInList = Globals.StarboundSettings.serverUsers.additionalData.ContainsKey(nameTrimmed);

			if (_isEditing) {

				nameChanged = nameTrimmed != ServerUsersForm.SelectedUser.Value.Key;
				nameConflict = nameChanged && nameTypedExistsInList;
			} else {
				nameConflict = nameTypedExistsInList;
			}

			bool applyChanges = true;
			if (nameConflict) {
				string warning = "There is already a user named " + nameTrimmed + "." + Environment.NewLine + "Do you wish to overwrite and remove that user?";
				DialogResult answer = MessageBox.Show(warning, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				applyChanges = (answer == DialogResult.Yes);
			}

			if (applyChanges) {
				if (_isEditing) {
					dynamic tmp = ServerUsersForm.SelectedUser.Value.Value;
					tmp.password = passTrimmed;
					tmp.admin = chkAdmin.Checked;
					if (nameChanged) ChangeUsername(ServerUsersForm.SelectedUser.Value.Key, nameTrimmed);
				} else {
					JObject userJson = JObject.Parse(String.Format(@"
					{
						""admin"" : {0},
						""password"" : ""{1}""
					}", chkAdmin.Enabled.ToString(), passTrimmed));
					Globals.StarboundSettings.serverUsers.additionalData.Add(nameTrimmed, userJson);
				}
				((ServerUsersForm)this.Owner).PopulateList();
				this.Close();
			}
		}

		public static void ChangeUsername(string oldName, string newName) {
			var userDict = Globals.StarboundSettings.serverUsers.additionalData;
			JToken value = userDict[oldName];
			userDict.Remove(oldName);
			userDict[newName] = value;
		}
	}
}
