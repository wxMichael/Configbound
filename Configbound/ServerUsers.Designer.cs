namespace Configbound {
	partial class ServerUsers {
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
			this.lstServerUsers = new System.Windows.Forms.ListView();
			this.colUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colAdmin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnAdd = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdmin = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstServerUsers
			// 
			this.lstServerUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUsername,
            this.colPassword,
            this.colAdmin});
			this.lstServerUsers.FullRowSelect = true;
			this.lstServerUsers.GridLines = true;
			this.lstServerUsers.HideSelection = false;
			this.lstServerUsers.Location = new System.Drawing.Point(12, 12);
			this.lstServerUsers.Name = "lstServerUsers";
			this.lstServerUsers.Size = new System.Drawing.Size(289, 195);
			this.lstServerUsers.TabIndex = 0;
			this.lstServerUsers.UseCompatibleStateImageBehavior = false;
			this.lstServerUsers.View = System.Windows.Forms.View.Details;
			this.lstServerUsers.SelectedIndexChanged += new System.EventHandler(this.lstServerUsers_SelectedIndexChanged);
			// 
			// colUsername
			// 
			this.colUsername.Text = "Username";
			this.colUsername.Width = 100;
			// 
			// colPassword
			// 
			this.colPassword.Text = "Password";
			this.colPassword.Width = 100;
			// 
			// colAdmin
			// 
			this.colAdmin.Text = "Admin";
			this.colAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnAdd
			// 
			this.btnAdd.Enabled = false;
			this.btnAdd.Location = new System.Drawing.Point(3, 3);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(82, 23);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel1.Controls.Add(this.btnAdd);
			this.flowLayoutPanel1.Controls.Add(this.btnEdit);
			this.flowLayoutPanel1.Controls.Add(this.btnAdmin);
			this.flowLayoutPanel1.Controls.Add(this.btnRemove);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(307, 12);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(88, 195);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// btnEdit
			// 
			this.btnEdit.Enabled = false;
			this.btnEdit.Location = new System.Drawing.Point(3, 32);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(82, 23);
			this.btnEdit.TabIndex = 2;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAdmin
			// 
			this.btnAdmin.AutoSize = true;
			this.btnAdmin.Enabled = false;
			this.btnAdmin.Location = new System.Drawing.Point(3, 61);
			this.btnAdmin.Name = "btnAdmin";
			this.btnAdmin.Size = new System.Drawing.Size(82, 23);
			this.btnAdmin.TabIndex = 3;
			this.btnAdmin.Text = "Toggle Admin";
			this.btnAdmin.UseVisualStyleBackColor = true;
			this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Enabled = false;
			this.btnRemove.Location = new System.Drawing.Point(3, 90);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(82, 23);
			this.btnRemove.TabIndex = 4;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// ServerUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 218);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.lstServerUsers);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ServerUsers";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Server Users";
			this.Load += new System.EventHandler(this.ServerUsers_Load);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lstServerUsers;
		private System.Windows.Forms.ColumnHeader colUsername;
		private System.Windows.Forms.ColumnHeader colPassword;
		private System.Windows.Forms.ColumnHeader colAdmin;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnAdmin;
	}
}