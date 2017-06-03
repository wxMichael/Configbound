namespace Configbound {
	partial class StarSettingsForm {
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
			this.components = new System.ComponentModel.Container();
			this.btnSave = new System.Windows.Forms.Button();
			this.chkFullscreen = new System.Windows.Forms.CheckBox();
			this.chkBorderless = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.numWindowedHeight = new System.Windows.Forms.NumericUpDown();
			this.numWindowedWidth = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.chkMaximized = new System.Windows.Forms.CheckBox();
			this.numFullscreenHeight = new System.Windows.Forms.NumericUpDown();
			this.numFullscreenWidth = new System.Windows.Forms.NumericUpDown();
			this.chkVSync = new System.Windows.Forms.CheckBox();
			this.chkAllowAssetsMismatch = new System.Windows.Forms.CheckBox();
			this.chkClearPlayerFiles = new System.Windows.Forms.CheckBox();
			this.chkClearUniverseFiles = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.btnServerUsers = new System.Windows.Forms.Button();
			this.btnBannedIPs = new System.Windows.Forms.Button();
			this.btnBannedUUIDs = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.chkClientIPJoinable = new System.Windows.Forms.CheckBox();
			this.chkClientP2PJoinable = new System.Windows.Forms.CheckBox();
			this.chkCheckAssetsDigest = new System.Windows.Forms.CheckBox();
			this.chkAllowAdminCommands = new System.Windows.Forms.CheckBox();
			this.chkAllowAdminCommandsFromAnyone = new System.Windows.Forms.CheckBox();
			this.chkAllowAnonymousConnections = new System.Windows.Forms.CheckBox();
			this.chkAnonymousConnectionsAreAdmin = new System.Windows.Forms.CheckBox();
			this.numGameServerPort = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.txtServerName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.numMaxPlayers = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.numMaxTeamSize = new System.Windows.Forms.NumericUpDown();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.lblSFXVolume = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lblMusicVolume = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.barSFXVolume = new System.Windows.Forms.TrackBar();
			this.barMusicVolume = new System.Windows.Forms.TrackBar();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.chkLimitTextureAtlasSize = new System.Windows.Forms.CheckBox();
			this.tipStarSettings = new System.Windows.Forms.ToolTip(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numWindowedHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numWindowedWidth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numFullscreenHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numFullscreenWidth)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numGameServerPort)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numMaxPlayers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numMaxTeamSize)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.barSFXVolume)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barMusicVolume)).BeginInit();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(227, 372);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(80, 23);
			this.btnSave.TabIndex = 29;
			this.btnSave.Text = "Save Config";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// chkFullscreen
			// 
			this.chkFullscreen.AutoSize = true;
			this.chkFullscreen.Location = new System.Drawing.Point(6, 19);
			this.chkFullscreen.Name = "chkFullscreen";
			this.chkFullscreen.Size = new System.Drawing.Size(74, 17);
			this.chkFullscreen.TabIndex = 1;
			this.chkFullscreen.Text = "Fullscreen";
			this.chkFullscreen.UseVisualStyleBackColor = true;
			// 
			// chkBorderless
			// 
			this.chkBorderless.AutoSize = true;
			this.chkBorderless.Location = new System.Drawing.Point(6, 42);
			this.chkBorderless.Name = "chkBorderless";
			this.chkBorderless.Size = new System.Drawing.Size(75, 17);
			this.chkBorderless.TabIndex = 4;
			this.chkBorderless.Text = "Borderless";
			this.chkBorderless.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(148, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(12, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "x";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.numWindowedHeight);
			this.groupBox1.Controls.Add(this.numWindowedWidth);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.chkMaximized);
			this.groupBox1.Controls.Add(this.numFullscreenHeight);
			this.groupBox1.Controls.Add(this.numFullscreenWidth);
			this.groupBox1.Controls.Add(this.chkVSync);
			this.groupBox1.Controls.Add(this.chkFullscreen);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.chkBorderless);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(232, 126);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Display";
			// 
			// label11
			// 
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label11.Location = new System.Drawing.Point(41, 69);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(150, 2);
			this.label11.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 83);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(69, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Window Size";
			// 
			// numWindowedHeight
			// 
			this.numWindowedHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numWindowedHeight.Location = new System.Drawing.Point(168, 81);
			this.numWindowedHeight.Maximum = new decimal(new int[] {
            9216,
            0,
            0,
            0});
			this.numWindowedHeight.Minimum = new decimal(new int[] {
            480,
            0,
            0,
            0});
			this.numWindowedHeight.Name = "numWindowedHeight";
			this.numWindowedHeight.Size = new System.Drawing.Size(56, 20);
			this.numWindowedHeight.TabIndex = 7;
			this.numWindowedHeight.Value = new decimal(new int[] {
            1080,
            0,
            0,
            0});
			// 
			// numWindowedWidth
			// 
			this.numWindowedWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numWindowedWidth.Location = new System.Drawing.Point(88, 81);
			this.numWindowedWidth.Maximum = new decimal(new int[] {
            9216,
            0,
            0,
            0});
			this.numWindowedWidth.Minimum = new decimal(new int[] {
            640,
            0,
            0,
            0});
			this.numWindowedWidth.Name = "numWindowedWidth";
			this.numWindowedWidth.Size = new System.Drawing.Size(56, 20);
			this.numWindowedWidth.TabIndex = 6;
			this.numWindowedWidth.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(150, 81);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(12, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "x";
			// 
			// chkMaximized
			// 
			this.chkMaximized.AutoSize = true;
			this.chkMaximized.Location = new System.Drawing.Point(6, 101);
			this.chkMaximized.Name = "chkMaximized";
			this.chkMaximized.Size = new System.Drawing.Size(75, 17);
			this.chkMaximized.TabIndex = 8;
			this.chkMaximized.Text = "Maximized";
			this.chkMaximized.UseVisualStyleBackColor = true;
			// 
			// numFullscreenHeight
			// 
			this.numFullscreenHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numFullscreenHeight.Location = new System.Drawing.Point(166, 18);
			this.numFullscreenHeight.Maximum = new decimal(new int[] {
            9216,
            0,
            0,
            0});
			this.numFullscreenHeight.Minimum = new decimal(new int[] {
            480,
            0,
            0,
            0});
			this.numFullscreenHeight.Name = "numFullscreenHeight";
			this.numFullscreenHeight.Size = new System.Drawing.Size(56, 20);
			this.numFullscreenHeight.TabIndex = 3;
			this.numFullscreenHeight.Value = new decimal(new int[] {
            1080,
            0,
            0,
            0});
			// 
			// numFullscreenWidth
			// 
			this.numFullscreenWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numFullscreenWidth.Location = new System.Drawing.Point(86, 18);
			this.numFullscreenWidth.Maximum = new decimal(new int[] {
            9216,
            0,
            0,
            0});
			this.numFullscreenWidth.Minimum = new decimal(new int[] {
            640,
            0,
            0,
            0});
			this.numFullscreenWidth.Name = "numFullscreenWidth";
			this.numFullscreenWidth.Size = new System.Drawing.Size(56, 20);
			this.numFullscreenWidth.TabIndex = 2;
			this.numFullscreenWidth.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
			// 
			// chkVSync
			// 
			this.chkVSync.AutoSize = true;
			this.chkVSync.Location = new System.Drawing.Point(93, 41);
			this.chkVSync.Name = "chkVSync";
			this.chkVSync.Size = new System.Drawing.Size(57, 17);
			this.chkVSync.TabIndex = 5;
			this.chkVSync.Text = "VSync";
			this.chkVSync.UseVisualStyleBackColor = true;
			// 
			// chkAllowAssetsMismatch
			// 
			this.chkAllowAssetsMismatch.AutoSize = true;
			this.chkAllowAssetsMismatch.Location = new System.Drawing.Point(3, 49);
			this.chkAllowAssetsMismatch.Name = "chkAllowAssetsMismatch";
			this.chkAllowAssetsMismatch.Size = new System.Drawing.Size(133, 17);
			this.chkAllowAssetsMismatch.TabIndex = 20;
			this.chkAllowAssetsMismatch.Text = "Allow Assets Mismatch";
			this.chkAllowAssetsMismatch.UseVisualStyleBackColor = true;
			// 
			// chkClearPlayerFiles
			// 
			this.chkClearPlayerFiles.AutoSize = true;
			this.chkClearPlayerFiles.Location = new System.Drawing.Point(6, 19);
			this.chkClearPlayerFiles.Name = "chkClearPlayerFiles";
			this.chkClearPlayerFiles.Size = new System.Drawing.Size(106, 17);
			this.chkClearPlayerFiles.TabIndex = 12;
			this.chkClearPlayerFiles.Text = "Clear Player Files";
			this.tipStarSettings.SetToolTip(this.chkClearPlayerFiles, "WARNING: Do not forget to turn this back off before playing!");
			this.chkClearPlayerFiles.UseVisualStyleBackColor = true;
			// 
			// chkClearUniverseFiles
			// 
			this.chkClearUniverseFiles.AutoSize = true;
			this.chkClearUniverseFiles.Location = new System.Drawing.Point(6, 42);
			this.chkClearUniverseFiles.Name = "chkClearUniverseFiles";
			this.chkClearUniverseFiles.Size = new System.Drawing.Size(119, 17);
			this.chkClearUniverseFiles.TabIndex = 13;
			this.chkClearUniverseFiles.Text = "Clear Universe Files";
			this.tipStarSettings.SetToolTip(this.chkClearUniverseFiles, "WARNING: Do not forget to turn this back off before playing!");
			this.chkClearUniverseFiles.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.chkClearPlayerFiles);
			this.groupBox2.Controls.Add(this.chkClearUniverseFiles);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Location = new System.Drawing.Point(12, 303);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(232, 63);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Wipe Game Data";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.SystemColors.Control;
			this.label10.ForeColor = System.Drawing.Color.DarkRed;
			this.label10.Location = new System.Drawing.Point(108, 13);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(124, 44);
			this.label10.TabIndex = 0;
			this.label10.Text = "-- WARNING --\r\nThese take effect on EVERY game start!";
			this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.flowLayoutPanel2);
			this.groupBox3.Controls.Add(this.flowLayoutPanel1);
			this.groupBox3.Controls.Add(this.numGameServerPort);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.txtServerName);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.numMaxPlayers);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.numMaxTeamSize);
			this.groupBox3.Location = new System.Drawing.Point(250, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(272, 354);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Multiplayer";
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.AutoSize = true;
			this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel2.Controls.Add(this.btnServerUsers);
			this.flowLayoutPanel2.Controls.Add(this.btnBannedIPs);
			this.flowLayoutPanel2.Controls.Add(this.btnBannedUUIDs);
			this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 309);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(257, 29);
			this.flowLayoutPanel2.TabIndex = 0;
			// 
			// btnServerUsers
			// 
			this.btnServerUsers.AutoSize = true;
			this.btnServerUsers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnServerUsers.Enabled = false;
			this.btnServerUsers.Location = new System.Drawing.Point(3, 3);
			this.btnServerUsers.Name = "btnServerUsers";
			this.btnServerUsers.Size = new System.Drawing.Size(78, 23);
			this.btnServerUsers.TabIndex = 26;
			this.btnServerUsers.Text = "Server Users";
			this.btnServerUsers.UseVisualStyleBackColor = true;
			this.btnServerUsers.Click += new System.EventHandler(this.btnServerUsers_Click);
			// 
			// btnBannedIPs
			// 
			this.btnBannedIPs.AutoSize = true;
			this.btnBannedIPs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnBannedIPs.Enabled = false;
			this.btnBannedIPs.Location = new System.Drawing.Point(87, 3);
			this.btnBannedIPs.Name = "btnBannedIPs";
			this.btnBannedIPs.Size = new System.Drawing.Size(72, 23);
			this.btnBannedIPs.TabIndex = 27;
			this.btnBannedIPs.Text = "Banned IPs";
			this.btnBannedIPs.UseVisualStyleBackColor = true;
			// 
			// btnBannedUUIDs
			// 
			this.btnBannedUUIDs.AutoSize = true;
			this.btnBannedUUIDs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnBannedUUIDs.Enabled = false;
			this.btnBannedUUIDs.Location = new System.Drawing.Point(165, 3);
			this.btnBannedUUIDs.Name = "btnBannedUUIDs";
			this.btnBannedUUIDs.Size = new System.Drawing.Size(89, 23);
			this.btnBannedUUIDs.TabIndex = 28;
			this.btnBannedUUIDs.Text = "Banned UUIDs";
			this.btnBannedUUIDs.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.chkClientIPJoinable);
			this.flowLayoutPanel1.Controls.Add(this.chkClientP2PJoinable);
			this.flowLayoutPanel1.Controls.Add(this.chkAllowAssetsMismatch);
			this.flowLayoutPanel1.Controls.Add(this.chkCheckAssetsDigest);
			this.flowLayoutPanel1.Controls.Add(this.chkAllowAdminCommands);
			this.flowLayoutPanel1.Controls.Add(this.chkAllowAdminCommandsFromAnyone);
			this.flowLayoutPanel1.Controls.Add(this.chkAllowAnonymousConnections);
			this.flowLayoutPanel1.Controls.Add(this.chkAnonymousConnectionsAreAdmin);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 117);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(224, 186);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// chkClientIPJoinable
			// 
			this.chkClientIPJoinable.AutoSize = true;
			this.chkClientIPJoinable.Location = new System.Drawing.Point(3, 3);
			this.chkClientIPJoinable.Name = "chkClientIPJoinable";
			this.chkClientIPJoinable.Size = new System.Drawing.Size(107, 17);
			this.chkClientIPJoinable.TabIndex = 18;
			this.chkClientIPJoinable.Text = "Client IP-Joinable";
			this.chkClientIPJoinable.UseVisualStyleBackColor = true;
			// 
			// chkClientP2PJoinable
			// 
			this.chkClientP2PJoinable.AutoSize = true;
			this.chkClientP2PJoinable.Location = new System.Drawing.Point(3, 26);
			this.chkClientP2PJoinable.Name = "chkClientP2PJoinable";
			this.chkClientP2PJoinable.Size = new System.Drawing.Size(117, 17);
			this.chkClientP2PJoinable.TabIndex = 19;
			this.chkClientP2PJoinable.Text = "Client P2P-Joinable";
			this.chkClientP2PJoinable.UseVisualStyleBackColor = true;
			// 
			// chkCheckAssetsDigest
			// 
			this.chkCheckAssetsDigest.AutoSize = true;
			this.chkCheckAssetsDigest.Location = new System.Drawing.Point(3, 72);
			this.chkCheckAssetsDigest.Name = "chkCheckAssetsDigest";
			this.chkCheckAssetsDigest.Size = new System.Drawing.Size(124, 17);
			this.chkCheckAssetsDigest.TabIndex = 21;
			this.chkCheckAssetsDigest.Text = "Check Assets Digest";
			this.tipStarSettings.SetToolTip(this.chkCheckAssetsDigest, "Forces players to have matching assets pack.");
			this.chkCheckAssetsDigest.UseVisualStyleBackColor = true;
			// 
			// chkAllowAdminCommands
			// 
			this.chkAllowAdminCommands.AutoSize = true;
			this.chkAllowAdminCommands.Location = new System.Drawing.Point(3, 95);
			this.chkAllowAdminCommands.Name = "chkAllowAdminCommands";
			this.chkAllowAdminCommands.Size = new System.Drawing.Size(138, 17);
			this.chkAllowAdminCommands.TabIndex = 22;
			this.chkAllowAdminCommands.Text = "Allow Admin Commands";
			this.chkAllowAdminCommands.UseVisualStyleBackColor = true;
			// 
			// chkAllowAdminCommandsFromAnyone
			// 
			this.chkAllowAdminCommandsFromAnyone.AutoSize = true;
			this.chkAllowAdminCommandsFromAnyone.Location = new System.Drawing.Point(3, 118);
			this.chkAllowAdminCommandsFromAnyone.Name = "chkAllowAdminCommandsFromAnyone";
			this.chkAllowAdminCommandsFromAnyone.Size = new System.Drawing.Size(200, 17);
			this.chkAllowAdminCommandsFromAnyone.TabIndex = 23;
			this.chkAllowAdminCommandsFromAnyone.Text = "Allow Admin Commands from Anyone";
			this.tipStarSettings.SetToolTip(this.chkAllowAdminCommandsFromAnyone, "Allows anyone logged into the server to have access to the administrator console." +
        "");
			this.chkAllowAdminCommandsFromAnyone.UseVisualStyleBackColor = true;
			// 
			// chkAllowAnonymousConnections
			// 
			this.chkAllowAnonymousConnections.AutoSize = true;
			this.chkAllowAnonymousConnections.Location = new System.Drawing.Point(3, 141);
			this.chkAllowAnonymousConnections.Name = "chkAllowAnonymousConnections";
			this.chkAllowAnonymousConnections.Size = new System.Drawing.Size(171, 17);
			this.chkAllowAnonymousConnections.TabIndex = 24;
			this.chkAllowAnonymousConnections.Text = "Allow Anonymous Connections";
			this.tipStarSettings.SetToolTip(this.chkAllowAnonymousConnections, "Allows users who are not identified in serverUsers to log in.");
			this.chkAllowAnonymousConnections.UseVisualStyleBackColor = true;
			// 
			// chkAnonymousConnectionsAreAdmin
			// 
			this.chkAnonymousConnectionsAreAdmin.AutoSize = true;
			this.chkAnonymousConnectionsAreAdmin.Location = new System.Drawing.Point(3, 164);
			this.chkAnonymousConnectionsAreAdmin.Name = "chkAnonymousConnectionsAreAdmin";
			this.chkAnonymousConnectionsAreAdmin.Size = new System.Drawing.Size(193, 17);
			this.chkAnonymousConnectionsAreAdmin.TabIndex = 25;
			this.chkAnonymousConnectionsAreAdmin.Text = "Anonymous Connections are Admin";
			this.tipStarSettings.SetToolTip(this.chkAnonymousConnectionsAreAdmin, "Allows users who are not identified in serverUsers to be admin.");
			this.chkAnonymousConnectionsAreAdmin.UseVisualStyleBackColor = true;
			// 
			// numGameServerPort
			// 
			this.numGameServerPort.Location = new System.Drawing.Point(91, 39);
			this.numGameServerPort.Maximum = new decimal(new int[] {
            800000,
            0,
            0,
            0});
			this.numGameServerPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numGameServerPort.Name = "numGameServerPort";
			this.numGameServerPort.Size = new System.Drawing.Size(82, 20);
			this.numGameServerPort.TabIndex = 15;
			this.tipStarSettings.SetToolTip(this.numGameServerPort, "Default: 21025");
			this.numGameServerPort.Value = new decimal(new int[] {
            8000,
            0,
            0,
            0});
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 41);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Server Port";
			// 
			// txtServerName
			// 
			this.txtServerName.Location = new System.Drawing.Point(91, 13);
			this.txtServerName.Name = "txtServerName";
			this.txtServerName.Size = new System.Drawing.Size(172, 20);
			this.txtServerName.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Server Name";
			// 
			// numMaxPlayers
			// 
			this.numMaxPlayers.Location = new System.Drawing.Point(91, 65);
			this.numMaxPlayers.Name = "numMaxPlayers";
			this.numMaxPlayers.Size = new System.Drawing.Size(63, 20);
			this.numMaxPlayers.TabIndex = 16;
			this.tipStarSettings.SetToolTip(this.numMaxPlayers, "Default: 8");
			this.numMaxPlayers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Max Team Size";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Max Players";
			// 
			// numMaxTeamSize
			// 
			this.numMaxTeamSize.Location = new System.Drawing.Point(91, 91);
			this.numMaxTeamSize.Name = "numMaxTeamSize";
			this.numMaxTeamSize.Size = new System.Drawing.Size(63, 20);
			this.numMaxTeamSize.TabIndex = 17;
			this.tipStarSettings.SetToolTip(this.numMaxTeamSize, "Default: 4");
			this.numMaxTeamSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.lblSFXVolume);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Controls.Add(this.lblMusicVolume);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Controls.Add(this.barSFXVolume);
			this.groupBox4.Controls.Add(this.barMusicVolume);
			this.groupBox4.Location = new System.Drawing.Point(12, 144);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(232, 105);
			this.groupBox4.TabIndex = 0;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Audio";
			// 
			// lblSFXVolume
			// 
			this.lblSFXVolume.AutoSize = true;
			this.lblSFXVolume.Location = new System.Drawing.Point(195, 58);
			this.lblSFXVolume.Name = "lblSFXVolume";
			this.lblSFXVolume.Size = new System.Drawing.Size(25, 13);
			this.lblSFXVolume.TabIndex = 0;
			this.lblSFXVolume.Text = "100";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(5, 58);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(76, 13);
			this.label9.TabIndex = 30;
			this.label9.Text = "Sound Volume";
			// 
			// lblMusicVolume
			// 
			this.lblMusicVolume.AutoSize = true;
			this.lblMusicVolume.Location = new System.Drawing.Point(195, 16);
			this.lblMusicVolume.Name = "lblMusicVolume";
			this.lblMusicVolume.Size = new System.Drawing.Size(25, 13);
			this.lblMusicVolume.TabIndex = 0;
			this.lblMusicVolume.Text = "100";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(73, 13);
			this.label8.TabIndex = 29;
			this.label8.Text = "Music Volume";
			// 
			// barSFXVolume
			// 
			this.barSFXVolume.LargeChange = 10;
			this.barSFXVolume.Location = new System.Drawing.Point(85, 57);
			this.barSFXVolume.Maximum = 100;
			this.barSFXVolume.Name = "barSFXVolume";
			this.barSFXVolume.Size = new System.Drawing.Size(104, 45);
			this.barSFXVolume.SmallChange = 5;
			this.barSFXVolume.TabIndex = 10;
			this.barSFXVolume.TickStyle = System.Windows.Forms.TickStyle.None;
			this.barSFXVolume.Value = 100;
			// 
			// barMusicVolume
			// 
			this.barMusicVolume.LargeChange = 10;
			this.barMusicVolume.Location = new System.Drawing.Point(85, 16);
			this.barMusicVolume.Maximum = 100;
			this.barMusicVolume.Name = "barMusicVolume";
			this.barMusicVolume.Size = new System.Drawing.Size(104, 45);
			this.barMusicVolume.SmallChange = 5;
			this.barMusicVolume.TabIndex = 9;
			this.barMusicVolume.TickStyle = System.Windows.Forms.TickStyle.None;
			this.barMusicVolume.Value = 100;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.chkLimitTextureAtlasSize);
			this.groupBox5.Location = new System.Drawing.Point(12, 255);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(232, 42);
			this.groupBox5.TabIndex = 0;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Performance";
			// 
			// chkLimitTextureAtlasSize
			// 
			this.chkLimitTextureAtlasSize.AutoSize = true;
			this.chkLimitTextureAtlasSize.Location = new System.Drawing.Point(6, 19);
			this.chkLimitTextureAtlasSize.Name = "chkLimitTextureAtlasSize";
			this.chkLimitTextureAtlasSize.Size = new System.Drawing.Size(135, 17);
			this.chkLimitTextureAtlasSize.TabIndex = 11;
			this.chkLimitTextureAtlasSize.Text = "Limit Texture Atlas Size";
			this.tipStarSettings.SetToolTip(this.chkLimitTextureAtlasSize, "Starbound v1.2.1: Add “limitTextureAtlasSize” option in starbound.config to manua" +
        "lly limit texture atlas sizes. Should only necessary for video cards significant" +
        "ly below the minimum requirements.");
			this.chkLimitTextureAtlasSize.UseVisualStyleBackColor = true;
			// 
			// tipStarSettings
			// 
			this.tipStarSettings.AutoPopDelay = 30000;
			this.tipStarSettings.InitialDelay = 800;
			this.tipStarSettings.IsBalloon = true;
			this.tipStarSettings.ReshowDelay = 100;
			// 
			// StarSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 402);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "StarSettings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Configbound";
			this.Load += new System.EventHandler(this.StarSettings_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numWindowedHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numWindowedWidth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numFullscreenHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numFullscreenWidth)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numGameServerPort)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numMaxPlayers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numMaxTeamSize)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.barSFXVolume)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barMusicVolume)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.CheckBox chkFullscreen;
		private System.Windows.Forms.CheckBox chkBorderless;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkAllowAssetsMismatch;
		private System.Windows.Forms.CheckBox chkClearPlayerFiles;
		private System.Windows.Forms.CheckBox chkClearUniverseFiles;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtServerName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox chkVSync;
		private System.Windows.Forms.NumericUpDown numFullscreenHeight;
		private System.Windows.Forms.NumericUpDown numFullscreenWidth;
		private System.Windows.Forms.NumericUpDown numMaxTeamSize;
		private System.Windows.Forms.NumericUpDown numMaxPlayers;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox chkAllowAdminCommands;
		private System.Windows.Forms.CheckBox chkMaximized;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown numWindowedHeight;
		private System.Windows.Forms.NumericUpDown numWindowedWidth;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox chkAnonymousConnectionsAreAdmin;
		private System.Windows.Forms.CheckBox chkAllowAnonymousConnections;
		private System.Windows.Forms.CheckBox chkAllowAdminCommandsFromAnyone;
		private System.Windows.Forms.CheckBox chkCheckAssetsDigest;
		private System.Windows.Forms.CheckBox chkClientP2PJoinable;
		private System.Windows.Forms.CheckBox chkClientIPJoinable;
		private System.Windows.Forms.NumericUpDown numGameServerPort;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TrackBar barMusicVolume;
		private System.Windows.Forms.TrackBar barSFXVolume;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblSFXVolume;
		private System.Windows.Forms.Label lblMusicVolume;
		private System.Windows.Forms.Button btnBannedIPs;
		private System.Windows.Forms.Button btnBannedUUIDs;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Button btnServerUsers;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.CheckBox chkLimitTextureAtlasSize;
		private System.Windows.Forms.ToolTip tipStarSettings;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
	}
}

