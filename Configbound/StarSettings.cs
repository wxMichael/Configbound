using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Gameloop.Vdf;

// TODO:
// Add to ApplyConfig(): ServerUsers, bannedIPs, bannedUuids
// Add to StarConfig.Save(): ServerUsers, bannedIPs, bannedUuids


namespace Configbound {
	public partial class StarSettingsForm : Form {
		string gameStoragePath = String.Empty;
		string gameConfigPath = String.Empty;
		//StarConfig starConfig;

		public StarSettingsForm() {
			string steamPath;

			// Find Steam Install Path
			// HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Valve\Steam\InstallPath
			try {
				using (RegistryKey Reg32Base = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32)) {
					using (RegistryKey Reg32Steam = Reg32Base.OpenSubKey(@"SOFTWARE\Valve\Steam")) {
						steamPath = Reg32Steam.GetValue("InstallPath").ToString();
					}
				}
			} catch (Exception ex) {
				throw new Exception("Failed to open registry. Try running the application as Admin." + Environment.NewLine + ex.Message);
			}

			// Find Steam Library Folders
			List<string> libraryFolders = new List<string>();
			libraryFolders.Add(steamPath + @"\SteamApps");

			try {
				string libraryFile = steamPath + @"\SteamApps\libraryfolders.vdf";
				if (File.Exists(libraryFile)) {
					string vdfText = File.ReadAllText(libraryFile);
					VObject vdfObject = VdfConvert.Deserialize(vdfText);
					if (vdfObject.Count >= 3) {
						vdfObject.Remove("TimeNextStatsReport");
						vdfObject.Remove("ContentStatsID");

						foreach (VProperty child in vdfObject.Children()) {
							libraryFolders.Add(child.Value.ToString());
						}
					}
				}
			} catch (Exception ex) {
				throw new Exception("Failed to parse libraryfolders.vdf." + Environment.NewLine + ex.Message);
			}


			// Find Starbound App Manifest
			string libraryPath = String.Empty;
			foreach (string library in libraryFolders) {
				if (File.Exists(library + @"\appmanifest_211820.acf")) {
					libraryPath = library;
					break;
				}
			}
			if (libraryPath == String.Empty) throw new Exception("Failed to find Starbound appmanifest!");
			string manifestPath = libraryPath + @"\appmanifest_211820.acf";


			// Find Starbound Install Directory
			string installDir = String.Empty;
			string[] acfLines = File.ReadAllLines(manifestPath);
			foreach (string line in acfLines) {
				if (line.Contains("installdir")) {
					gameStoragePath = libraryPath + @"\common\" + line.Replace("\"installdir\"", "").Trim().Trim('"') + @"\storage";
					break;
				}
			}
			if (gameStoragePath == String.Empty) gameStoragePath = libraryPath + @"\common\Starbound\storage";

			gameConfigPath = gameStoragePath + @"\starbound.config";

			StarConfig.Load(gameConfigPath);

			InitializeComponent();
		}

		public void StarSettings_Load(object sender, EventArgs e) {
			ApplyConfig();
			lblMusicVolume.DataBindings.Add("Text", barMusicVolume, "Value");
			lblSFXVolume.DataBindings.Add("Text", barSFXVolume, "Value");
			btnSave.Enabled = true;
			btnServerUsers.Enabled = true;
			//btnBannedIPs.Enabled = true;
			//btnBannedUUIDs.Enabled = true;
		}

		private void ApplyConfig() {
			//foreach (KeyValuePair<string, JToken> user in starConfig.ServerUsers) {
			//	//MessageBox.Show(user.Key + "\n\n" + user.Value);
			//	MessageBox.Show(user.Value.ToString());
			//}
			// Display
			chkFullscreen.Checked = StarConfig.Fullscreen;
			chkBorderless.Checked = StarConfig.Borderless;
			chkVSync.Checked = StarConfig.VSync;
			chkMaximized.Checked = StarConfig.Maximized;
			numFullscreenWidth.Value = StarConfig.FullscreenResolution[0].ToObject<int>();
			numFullscreenHeight.Value = StarConfig.FullscreenResolution[1].ToObject<int>();
			numWindowedWidth.Value = StarConfig.WindowedResolution[0].ToObject<int>();
			numWindowedHeight.Value = StarConfig.WindowedResolution[1].ToObject<int>();

			// Audio
			barMusicVolume.Value = StarConfig.MusicVolume;
			barSFXVolume.Value = StarConfig.SFXVolume;

			// Performance
			chkLimitTextureAtlasSize.Checked = StarConfig.LimitTextureAtlasSize;

			// Multiplayer
			txtServerName.Text = StarConfig.ServerName;
			numGameServerPort.Value = StarConfig.GameServerPort;
			numMaxPlayers.Value = StarConfig.MaxPlayers;
			numMaxTeamSize.Value = StarConfig.MaxTeamSize;
			chkClientIPJoinable.Checked = StarConfig.ClientIPJoinable;
			chkClientP2PJoinable.Checked = StarConfig.ClientP2PJoinable;
			chkAllowAssetsMismatch.Checked = StarConfig.AllowAssetsMismatch;
			chkCheckAssetsDigest.Checked = StarConfig.CheckAssetsDigest;
			chkAllowAdminCommands.Checked = StarConfig.AllowAdminCommands;
			chkAllowAdminCommandsFromAnyone.Checked = StarConfig.AllowAdminCommandsFromAnyone;
			chkAllowAnonymousConnections.Checked = StarConfig.AllowAnonymousConnections;
			chkAnonymousConnectionsAreAdmin.Checked = StarConfig.AnonymousConnectionsAreAdmin;

			// Wipe Game Data
			chkClearPlayerFiles.Checked = StarConfig.ClearPlayerFiles;
			chkClearUniverseFiles.Checked = StarConfig.ClearUniverseFiles;
		}

		private void btnSave_Click(object sender, EventArgs e) {
			if (StarConfig.IsLoaded) {
				// Display
				StarConfig.Fullscreen = chkFullscreen.Checked;
				StarConfig.Borderless = chkBorderless.Checked;
				StarConfig.VSync = chkVSync.Checked;
				StarConfig.Maximized = chkMaximized.Checked;
				StarConfig.FullscreenResolution[0] = (int)numFullscreenWidth.Value;
				StarConfig.FullscreenResolution[1] = (int)numFullscreenHeight.Value;
				StarConfig.WindowedResolution[0] = (int)numWindowedWidth.Value;
				StarConfig.WindowedResolution[1] = (int)numWindowedHeight.Value;

				// Audio
				StarConfig.MusicVolume = barMusicVolume.Value;
				StarConfig.SFXVolume = barSFXVolume.Value;

				// Performance
				StarConfig.LimitTextureAtlasSize = chkLimitTextureAtlasSize.Checked;

				// Multiplayer
				StarConfig.ServerName = txtServerName.Text;
				StarConfig.GameServerPort = (int)numGameServerPort.Value;
				StarConfig.MaxPlayers = (int)numMaxPlayers.Value;
				StarConfig.MaxTeamSize = (int)numMaxTeamSize.Value;
				StarConfig.ClientIPJoinable = chkClientIPJoinable.Checked;
				StarConfig.ClientP2PJoinable = chkClientP2PJoinable.Checked;
				StarConfig.AllowAssetsMismatch = chkAllowAssetsMismatch.Checked;
				StarConfig.CheckAssetsDigest = chkCheckAssetsDigest.Checked;
				StarConfig.AllowAdminCommands = chkAllowAdminCommands.Checked;
				StarConfig.AllowAdminCommandsFromAnyone = chkAllowAdminCommandsFromAnyone.Checked;
				StarConfig.AllowAnonymousConnections = chkAllowAnonymousConnections.Checked;
				StarConfig.AnonymousConnectionsAreAdmin = chkAnonymousConnectionsAreAdmin.Checked;

				// Wipe Game Data
				StarConfig.ClearPlayerFiles = chkClearPlayerFiles.Checked;
				StarConfig.ClearUniverseFiles = chkClearUniverseFiles.Checked;

				StarConfig.Save();
			}
		}

		private void btnServerUsers_Click(object sender, EventArgs e) {
			ServerUsersForm frmServerUsers = new ServerUsersForm();
			frmServerUsers.ShowDialog(this);
		}
	}

	static class StarConfig {
		static dynamic _starConfig;
		static string _configPath;

		public static void Load(string configPath) {
			string json = File.ReadAllText(configPath);
			_starConfig = JsonConvert.DeserializeObject(json);
			_configPath = configPath;
		}

		public static void Save() {
			try {
				File.Copy(_configPath, _configPath + ".bak", true);

				string json = JsonConvert.SerializeObject(_starConfig, Formatting.Indented);
				File.WriteAllText(_configPath, json, System.Text.Encoding.UTF8);
			} catch (Exception ex) {
				MessageBox.Show("Save Failed!" + Environment.NewLine + ex.Message);
			}
		}

		public static bool IsLoaded {
			get { return _starConfig != default(dynamic); }
		}

		// Display
		public static bool Fullscreen {
			get { return _starConfig.fullscreen; }
			set { _starConfig.fullscreen = value; }
		}
		public static bool Borderless {
			get { return _starConfig.borderless; }
			set { _starConfig.borderless = value; }
		}
		public static bool VSync {
			get { return _starConfig.vsync; }
			set { _starConfig.vsync = value; }
		}
		public static bool Maximized {
			get { return _starConfig.maximized; }
			set { _starConfig.maximized = value; }
		}
		public static JArray FullscreenResolution {
			get { return _starConfig.fullscreenResolution; }
			set { _starConfig.fullscreenResolution = value; }
		}
		public static JArray WindowedResolution {
			get { return _starConfig.windowedResolution; }
			set { _starConfig.windowedResolution = value; }
		}

		// Audio
		public static int MusicVolume {
			get { return _starConfig.musicVol; }
			set { _starConfig.musicVol = value; }
		}
		public static int SFXVolume {
			get { return _starConfig.sfxVol; }
			set { _starConfig.sfxVol = value; }
		}

		// Performance
		public static bool LimitTextureAtlasSize {
			get { return _starConfig.limitTextureAtlasSize; }
			set { _starConfig.limitTextureAtlasSize = value; }
		}

		// Multiplayer
		public static string ServerName {
			get { return _starConfig.serverName; }
			set { _starConfig.serverName = value; }
		}
		public static int GameServerPort {
			get { return _starConfig.gameServerPort; }
			set { _starConfig.gameServerPort = value; }
		}
		public static int MaxPlayers {
			get { return _starConfig.maxPlayers; }
			set { _starConfig.maxPlayers = value; }
		}
		public static int MaxTeamSize {
			get { return _starConfig.maxTeamSize; }
			set { _starConfig.maxTeamSize = value; }
		}
		public static bool ClientIPJoinable {
			get { return _starConfig.clientIPJoinable; }
			set { _starConfig.clientIPJoinable = value; }
		}
		public static bool ClientP2PJoinable {
			get { return _starConfig.clientP2PJoinable; }
			set { _starConfig.clientP2PJoinable = value; }
		}
		public static bool AllowAssetsMismatch {
			get { return _starConfig.allowAssetsMismatch; }
			set { _starConfig.allowAssetsMismatch = value; }
		}
		public static bool CheckAssetsDigest {
			get { return _starConfig.checkAssetsDigest; }
			set { _starConfig.checkAssetsDigest = value; }
		}
		public static bool AllowAdminCommands {
			get { return _starConfig.allowAdminCommands; }
			set { _starConfig.allowAdminCommands = value; }
		}
		public static bool AllowAdminCommandsFromAnyone {
			get { return _starConfig.allowAdminCommandsFromAnyone; }
			set { _starConfig.allowAdminCommandsFromAnyone = value; }
		}
		public static bool AllowAnonymousConnections {
			get { return _starConfig.allowAnonymousConnections; }
			set { _starConfig.allowAnonymousConnections = value; }
		}
		public static bool AnonymousConnectionsAreAdmin {
			get { return _starConfig.anonymousConnectionsAreAdmin; }
			set { _starConfig.anonymousConnectionsAreAdmin = value; }
		}
		public static JObject ServerUsers {
			get { return _starConfig.serverUsers; }
			set { _starConfig.serverUsers = value; }
		}
		//public static List<JProperty> ServerUsers {
		//	get {
		//		IEnumerable<JProperty> properties = ((JObject)_starConfig.serverUsers).Properties();
		//		return new List<JProperty>(properties);
		//	}
		//	set { ((JObject)_starConfig.serverUsers). = value; }
		//}

		//public static object bannedIPs { get; set; }
		//public static object bannedUuids { get; set; }

		//"serverUsers" : {
		//},

		// Wipe Game Data
		public static bool ClearPlayerFiles {
			get { return _starConfig.clearPlayerFiles; }
			set { _starConfig.clearPlayerFiles = value; }
		}

		public static bool ClearUniverseFiles {
			get { return _starConfig.clearUniverseFiles; }
			set { _starConfig.clearUniverseFiles = value; }
		}

		//public List<int> audioChannelSeparation { get; set; }

		//"configurationVersion" : {
		//	"basic" : 1,
		//	"client" : 6
		//},

		//public string gameServerBind { get; set; }

		//"crafting" : {
		//	"filterHaveMaterials" : false
		//},
		//public bool interactiveHighlight { get; set; }
		//"inventory" : {
		//	"pickupToActionBar" : true
		//},
		//public bool speechBubbles { get; set; }
		//public int zoomLevel { get; set; }
		//public bool tutorialMessages { get; set; }

		//public bool modsWarningShown { get; set; }
		//public int playerBackupFileCount { get; set; }
		//public string queryServerBind { get; set; }
		//public string rconServerBind { get; set; }
		//public bool renderSleep { get; set; }
		//public bool safeScripts { get; set; }
		//public intLONG? scriptInstructionLimit { get; set; }
		//public intLONG? scriptInstructionMeasureInterval { get; set; }
		//public bool scriptProfilingEnabled { get; set; }
		//public intLONG? scriptRecursionLimit { get; set; }
		//public string serverFidelity { get; set; }

		//"title" : {
		//	"multiPlayerAccount" : "",
		//	"multiPlayerAddress" : "",
		//	"multiPlayerPort" : ""
		//},
	}
}
