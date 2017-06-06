namespace Configbound {
	partial class BannedPlayers {
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
			this.lstBannedIPs = new System.Windows.Forms.ListView();
			this.colIPAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colIPReason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lstBannedUUIDs = new System.Windows.Forms.ListView();
			this.colUUID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colUUIDReason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnIPAdd = new System.Windows.Forms.Button();
			this.btnIPEdit = new System.Windows.Forms.Button();
			this.btnIPRemove = new System.Windows.Forms.Button();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnUUIDAdd = new System.Windows.Forms.Button();
			this.btnUUIDEdit = new System.Windows.Forms.Button();
			this.btnUUIDRemove = new System.Windows.Forms.Button();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstBannedIPs
			// 
			this.lstBannedIPs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIPAddress,
            this.colIPReason});
			this.lstBannedIPs.FullRowSelect = true;
			this.lstBannedIPs.GridLines = true;
			this.lstBannedIPs.HideSelection = false;
			this.lstBannedIPs.Location = new System.Drawing.Point(12, 12);
			this.lstBannedIPs.MultiSelect = false;
			this.lstBannedIPs.Name = "lstBannedIPs";
			this.lstBannedIPs.Size = new System.Drawing.Size(366, 160);
			this.lstBannedIPs.TabIndex = 0;
			this.lstBannedIPs.UseCompatibleStateImageBehavior = false;
			this.lstBannedIPs.View = System.Windows.Forms.View.Details;
			this.lstBannedIPs.SelectedIndexChanged += new System.EventHandler(this.BannedPlayers_SelectedIndexChanged);
			// 
			// colIPAddress
			// 
			this.colIPAddress.Text = "IP Address";
			this.colIPAddress.Width = 100;
			// 
			// colIPReason
			// 
			this.colIPReason.Text = "Ban Reason";
			this.colIPReason.Width = 240;
			// 
			// lstBannedUUIDs
			// 
			this.lstBannedUUIDs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUUID,
            this.colUUIDReason});
			this.lstBannedUUIDs.FullRowSelect = true;
			this.lstBannedUUIDs.GridLines = true;
			this.lstBannedUUIDs.HideSelection = false;
			this.lstBannedUUIDs.Location = new System.Drawing.Point(12, 178);
			this.lstBannedUUIDs.MultiSelect = false;
			this.lstBannedUUIDs.Name = "lstBannedUUIDs";
			this.lstBannedUUIDs.Size = new System.Drawing.Size(366, 160);
			this.lstBannedUUIDs.TabIndex = 4;
			this.lstBannedUUIDs.UseCompatibleStateImageBehavior = false;
			this.lstBannedUUIDs.View = System.Windows.Forms.View.Details;
			this.lstBannedUUIDs.SelectedIndexChanged += new System.EventHandler(this.BannedPlayers_SelectedIndexChanged);
			// 
			// colUUID
			// 
			this.colUUID.Text = "Character UUID";
			this.colUUID.Width = 100;
			// 
			// colUUIDReason
			// 
			this.colUUIDReason.Text = "Ban Reason";
			this.colUUIDReason.Width = 240;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel1.Controls.Add(this.btnIPAdd);
			this.flowLayoutPanel1.Controls.Add(this.btnIPEdit);
			this.flowLayoutPanel1.Controls.Add(this.btnIPRemove);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(384, 12);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(88, 160);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// btnIPAdd
			// 
			this.btnIPAdd.Enabled = false;
			this.btnIPAdd.Location = new System.Drawing.Point(3, 3);
			this.btnIPAdd.Name = "btnIPAdd";
			this.btnIPAdd.Size = new System.Drawing.Size(82, 23);
			this.btnIPAdd.TabIndex = 1;
			this.btnIPAdd.Text = "Add";
			this.btnIPAdd.UseVisualStyleBackColor = true;
			this.btnIPAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnIPEdit
			// 
			this.btnIPEdit.Enabled = false;
			this.btnIPEdit.Location = new System.Drawing.Point(3, 32);
			this.btnIPEdit.Name = "btnIPEdit";
			this.btnIPEdit.Size = new System.Drawing.Size(82, 23);
			this.btnIPEdit.TabIndex = 2;
			this.btnIPEdit.Text = "Edit";
			this.btnIPEdit.UseVisualStyleBackColor = true;
			this.btnIPEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnIPRemove
			// 
			this.btnIPRemove.Enabled = false;
			this.btnIPRemove.Location = new System.Drawing.Point(3, 61);
			this.btnIPRemove.Name = "btnIPRemove";
			this.btnIPRemove.Size = new System.Drawing.Size(82, 23);
			this.btnIPRemove.TabIndex = 3;
			this.btnIPRemove.Text = "Remove";
			this.btnIPRemove.UseVisualStyleBackColor = true;
			this.btnIPRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel2.Controls.Add(this.btnUUIDAdd);
			this.flowLayoutPanel2.Controls.Add(this.btnUUIDEdit);
			this.flowLayoutPanel2.Controls.Add(this.btnUUIDRemove);
			this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(384, 178);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(88, 160);
			this.flowLayoutPanel2.TabIndex = 5;
			// 
			// btnUUIDAdd
			// 
			this.btnUUIDAdd.Enabled = false;
			this.btnUUIDAdd.Location = new System.Drawing.Point(3, 3);
			this.btnUUIDAdd.Name = "btnUUIDAdd";
			this.btnUUIDAdd.Size = new System.Drawing.Size(82, 23);
			this.btnUUIDAdd.TabIndex = 5;
			this.btnUUIDAdd.Text = "Add";
			this.btnUUIDAdd.UseVisualStyleBackColor = true;
			this.btnUUIDAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUUIDEdit
			// 
			this.btnUUIDEdit.Enabled = false;
			this.btnUUIDEdit.Location = new System.Drawing.Point(3, 32);
			this.btnUUIDEdit.Name = "btnUUIDEdit";
			this.btnUUIDEdit.Size = new System.Drawing.Size(82, 23);
			this.btnUUIDEdit.TabIndex = 6;
			this.btnUUIDEdit.Text = "Edit";
			this.btnUUIDEdit.UseVisualStyleBackColor = true;
			this.btnUUIDEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnUUIDRemove
			// 
			this.btnUUIDRemove.Enabled = false;
			this.btnUUIDRemove.Location = new System.Drawing.Point(3, 61);
			this.btnUUIDRemove.Name = "btnUUIDRemove";
			this.btnUUIDRemove.Size = new System.Drawing.Size(82, 23);
			this.btnUUIDRemove.TabIndex = 7;
			this.btnUUIDRemove.Text = "Remove";
			this.btnUUIDRemove.UseVisualStyleBackColor = true;
			this.btnUUIDRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// BannedPlayers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 351);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.lstBannedUUIDs);
			this.Controls.Add(this.lstBannedIPs);
			this.Controls.Add(this.flowLayoutPanel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BannedPlayers";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Banned Players";
			this.Load += new System.EventHandler(this.BannedPlayers_Load);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lstBannedIPs;
		private System.Windows.Forms.ColumnHeader colIPAddress;
		private System.Windows.Forms.ColumnHeader colIPReason;
		private System.Windows.Forms.ListView lstBannedUUIDs;
		private System.Windows.Forms.ColumnHeader colUUID;
		private System.Windows.Forms.ColumnHeader colUUIDReason;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button btnIPAdd;
		private System.Windows.Forms.Button btnIPEdit;
		private System.Windows.Forms.Button btnIPRemove;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Button btnUUIDAdd;
		private System.Windows.Forms.Button btnUUIDEdit;
		private System.Windows.Forms.Button btnUUIDRemove;
	}
}