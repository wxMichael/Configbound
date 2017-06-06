namespace Configbound {
	partial class BannedPlayerEdit {
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
			this.btnSaveBan = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.lblBanType = new System.Windows.Forms.Label();
			this.txtReason = new System.Windows.Forms.TextBox();
			this.txtBanType = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnSaveBan
			// 
			this.btnSaveBan.Location = new System.Drawing.Point(217, 58);
			this.btnSaveBan.Name = "btnSaveBan";
			this.btnSaveBan.Size = new System.Drawing.Size(75, 23);
			this.btnSaveBan.TabIndex = 2;
			this.btnSaveBan.Text = "Save";
			this.btnSaveBan.UseVisualStyleBackColor = true;
			this.btnSaveBan.Click += new System.EventHandler(this.btnSaveBan_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Reason";
			// 
			// lblBanType
			// 
			this.lblBanType.AutoSize = true;
			this.lblBanType.Location = new System.Drawing.Point(12, 9);
			this.lblBanType.Name = "lblBanType";
			this.lblBanType.Size = new System.Drawing.Size(50, 13);
			this.lblBanType.TabIndex = 0;
			this.lblBanType.Text = "BanType";
			// 
			// txtReason
			// 
			this.txtReason.Location = new System.Drawing.Point(73, 32);
			this.txtReason.MaxLength = 200;
			this.txtReason.Name = "txtReason";
			this.txtReason.Size = new System.Drawing.Size(219, 20);
			this.txtReason.TabIndex = 1;
			// 
			// txtBanType
			// 
			this.txtBanType.Location = new System.Drawing.Point(73, 6);
			this.txtBanType.MaxLength = 45;
			this.txtBanType.Name = "txtBanType";
			this.txtBanType.Size = new System.Drawing.Size(219, 20);
			this.txtBanType.TabIndex = 0;
			// 
			// BannedPlayerEdit
			// 
			this.AcceptButton = this.btnSaveBan;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 90);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblBanType);
			this.Controls.Add(this.txtReason);
			this.Controls.Add(this.txtBanType);
			this.Controls.Add(this.btnSaveBan);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BannedPlayerEdit";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Banned Player";
			this.Load += new System.EventHandler(this.BannedPlayerEdit_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSaveBan;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblBanType;
		private System.Windows.Forms.TextBox txtReason;
		private System.Windows.Forms.TextBox txtBanType;
	}
}