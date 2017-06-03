using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Configbound {
	public partial class ServerUserEditForm : Form {
		public ServerUserEditForm() {
			InitializeComponent();
		}

		private void ServerUserEdit_Load(object sender, EventArgs e) {
			txtUsername.Text = ServerUsersForm.SelectedUser.Username;
			txtPassword.Text = ServerUsersForm.SelectedUser.Password;
			chkAdmin.Checked = ServerUsersForm.SelectedUser.IsAdmin;
		}

		private void btnSaveUser_Click(object sender, EventArgs e) {
			ServerUsersForm.SelectedUser.Username = txtUsername.Text;
			ServerUsersForm.SelectedUser.Password = txtPassword.Text;
			ServerUsersForm.SelectedUser.IsAdmin = chkAdmin.Checked;
			((ServerUsersForm)this.Owner).ApplySelectedUserChanges();
			this.Close();
		}
	}
}
