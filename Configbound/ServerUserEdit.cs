using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Configbound {
	public partial class ServerUserEdit : Form {
		bool _isEditing;

		public ServerUserEdit(bool isEditing) {
			_isEditing = isEditing;
			InitializeComponent();
		}

		private void ServerUserEdit_Load(object sender, EventArgs e) {
			if (_isEditing) {
				txtUsername.Text = ServerUsers.SelectedUser.Value.Key;
				txtPassword.Text = ((dynamic)ServerUsers.SelectedUser.Value.Value).password;
				chkAdmin.Checked = ((dynamic)ServerUsers.SelectedUser.Value.Value).admin;
			}
		}

		private void btnSaveUser_Click(object sender, EventArgs e) {
			string nameTrimmed = txtUsername.Text.Trim();
			string passTrimmed = txtPassword.Text.Trim();

			if (nameTrimmed == String.Empty | passTrimmed == String.Empty) {
				MessageBox.Show("Please enter both a name and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// also need to test if removing the last user causes issues saving, and also then readding a user and saving

			// Check if serverUsers is currently empty
			bool noUsers = Globals.StarboundSettings.serverUsers.additionalData == null;

			// Detect Name Conflicts
			bool nameConflict = false;
			bool nameChanged = false;
			bool nameTypedExistsInList = !noUsers && Globals.StarboundSettings.serverUsers.additionalData.ContainsKey(nameTrimmed);

			if (_isEditing) {

				nameChanged = nameTrimmed != ServerUsers.SelectedUser.Value.Key;
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
					dynamic tmp = ServerUsers.SelectedUser.Value.Value;
					tmp.password = passTrimmed;
					tmp.admin = chkAdmin.Checked;
					if (nameChanged) ChangeUsername(ServerUsers.SelectedUser.Value.Key, nameTrimmed);
				} else {
					if (noUsers) {
						string serverUsersJson = String.Format(@"
						{{
							""fullscreen"" : false,
							""serverUsers"" : {{
								""{0}"" : {{
									""admin"" : {1},
									""password"" : ""{2}""
								}}
							}}
						}}", nameTrimmed, chkAdmin.Checked.ToString().ToLower(), passTrimmed);
						SettingsRoot newSettings = JsonConvert.DeserializeObject<SettingsRoot>(serverUsersJson);
						Globals.StarboundSettings.serverUsers = newSettings.serverUsers;
					} else {
						System.Diagnostics.Debug.WriteLine(chkAdmin.Enabled.ToString().ToLower());
						JObject userJson = JObject.Parse(String.Format(@"
						{{
							""admin"" : {0},
							""password"" : ""{1}""
						}}", chkAdmin.Checked.ToString().ToLower(), passTrimmed));
						Globals.StarboundSettings.serverUsers.additionalData[nameTrimmed] = userJson;
					}
				}
				((ServerUsers)this.Owner).PopulateList();
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
