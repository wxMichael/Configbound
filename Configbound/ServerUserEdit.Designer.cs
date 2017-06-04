namespace Configbound {
	partial class ServerUserEdit {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.chkAdmin = new System.Windows.Forms.CheckBox();
			this.btnSaveUser = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(73, 6);
			this.txtUsername.MaxLength = 60;
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(160, 20);
			this.txtUsername.TabIndex = 0;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(73, 32);
			this.txtPassword.MaxLength = 60;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(160, 20);
			this.txtPassword.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Password";
			// 
			// chkAdmin
			// 
			this.chkAdmin.AutoSize = true;
			this.chkAdmin.Location = new System.Drawing.Point(73, 62);
			this.chkAdmin.Name = "chkAdmin";
			this.chkAdmin.Size = new System.Drawing.Size(55, 17);
			this.chkAdmin.TabIndex = 2;
			this.chkAdmin.Text = "Admin";
			this.chkAdmin.UseVisualStyleBackColor = true;
			// 
			// btnSaveUser
			// 
			this.btnSaveUser.Location = new System.Drawing.Point(158, 58);
			this.btnSaveUser.Name = "btnSaveUser";
			this.btnSaveUser.Size = new System.Drawing.Size(75, 23);
			this.btnSaveUser.TabIndex = 3;
			this.btnSaveUser.Text = "Save";
			this.btnSaveUser.UseVisualStyleBackColor = true;
			this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
			// 
			// ServerUserEdit
			// 
			this.AcceptButton = this.btnSaveUser;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(249, 90);
			this.Controls.Add(this.btnSaveUser);
			this.Controls.Add(this.chkAdmin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ServerUserEdit";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Server User";
			this.Load += new System.EventHandler(this.ServerUserEdit_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox chkAdmin;
		private System.Windows.Forms.Button btnSaveUser;
	}
}