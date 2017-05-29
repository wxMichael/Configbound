using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using Newtonsoft.Json;
using Gameloop.Vdf;

namespace Configbound {
	public partial class StarSettings : Form {
		string gameStoragePath = String.Empty;
		StarConfig starConfig;

		public StarSettings() {
			string steamPath;


			// Find Steam Install Path
			// HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Valve\Steam\InstallPath
			try {
				using (RegistryKey Reg32Base = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32)) {
					using (RegistryKey Reg32Steam = Reg32Base.OpenSubKey(@"SOFTWARE\Valve\Steam")) {
						steamPath = Reg32Steam.GetValue("InstallPath").ToString();
					}
				}
			} catch (Exception e) {
				throw new Exception("Failed to open registry. Try running the application as Admin." + Environment.NewLine + e.Message);
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
			} catch (Exception e) {
				throw new Exception("Failed to parse libraryfolders.vdf." + Environment.NewLine + e.Message);
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

			starConfig = new StarConfig(gameStoragePath + @"\starbound.config");

			InitializeComponent();
		}

		public void StarSettings_Load(object sender, EventArgs e) {
			ReadConfig();
			lblMusicVolume.DataBindings.Add("Text", barMusicVolume, "Value");
			lblSFXVolume.DataBindings.Add("Text", barSFXVolume, "Value");
		}

		private void ReadConfig() {
			// Display
			chkFullscreen.Checked = starConfig.Fullscreen;
			chkBorderless.Checked = starConfig.Borderless;
			chkVSync.Checked = starConfig.VSync;
			chkMaximized.Checked = starConfig.Maximized;
			numFullscreenWidth.Value = starConfig.FullscreenResolution[0].ToObject<int>();
			numFullscreenHeight.Value = starConfig.FullscreenResolution[1].ToObject<int>();
			numWindowedWidth.Value = starConfig.WindowedResolution[0].ToObject<int>();
			numWindowedHeight.Value = starConfig.WindowedResolution[1].ToObject<int>();

			// Audio
			barMusicVolume.Value = starConfig.MusicVolume;
			barSFXVolume.Value = starConfig.SFXVolume;

			// Performance
			chkLimitTextureAtlasSize.Checked = starConfig.LimitTextureAtlasSize;

			// Multiplayer
			txtServerName.Text = starConfig.ServerName;
			numGameServerPort.Value = starConfig.GameServerPort;
			numMaxPlayers.Value = starConfig.MaxPlayers;
			numMaxTeamSize.Value = starConfig.MaxTeamSize;
			chkClientIPJoinable.Checked = starConfig.ClientIPJoinable;
			chkClientP2PJoinable.Checked = starConfig.ClientP2PJoinable;
			chkAllowAssetsMismatch.Checked = starConfig.AllowAssetsMismatch;
			chkCheckAssetsDigest.Checked = starConfig.CheckAssetsDigest;
			chkAllowAdminCommands.Checked = starConfig.AllowAdminCommands;
			chkAllowAdminCommandsFromAnyone.Checked = starConfig.AllowAdminCommandsFromAnyone;
			chkAllowAnonymousConnections.Checked = starConfig.AllowAnonymousConnections;
			chkAnonymousConnectionsAreAdmin.Checked = starConfig.AnonymousConnectionsAreAdmin;

			// Wipe Game Data
			chkClearPlayerFiles.Checked = starConfig.ClearPlayerFiles;
			chkClearUniverseFiles.Checked = starConfig.ClearUniverseFiles;
		}

		private void btnSave_Click(object sender, EventArgs e) {
			if (starConfig != null) {
				// Display
				starConfig.Fullscreen = chkFullscreen.Checked;
				starConfig.Borderless = chkBorderless.Checked;
				starConfig.VSync = chkVSync.Checked;
				starConfig.Maximized = chkMaximized.Checked;
				starConfig.FullscreenResolution[0] = (int)numFullscreenWidth.Value;
				starConfig.FullscreenResolution[1] = (int)numFullscreenHeight.Value;
				starConfig.WindowedResolution[0] = (int)numWindowedWidth.Value;
				starConfig.WindowedResolution[1] = (int)numWindowedHeight.Value;

				// Audio
				starConfig.MusicVolume = barMusicVolume.Value;
				starConfig.SFXVolume = barSFXVolume.Value;

				// Performance
				starConfig.LimitTextureAtlasSize = chkLimitTextureAtlasSize.Checked;

				// Multiplayer
				starConfig.ServerName = txtServerName.Text;
				starConfig.GameServerPort = (int)numGameServerPort.Value;
				starConfig.MaxPlayers = (int)numMaxPlayers.Value;
				starConfig.MaxTeamSize = (int)numMaxTeamSize.Value;
				starConfig.ClientIPJoinable = chkClientIPJoinable.Checked;
				starConfig.ClientP2PJoinable = chkClientP2PJoinable.Checked;
				starConfig.AllowAssetsMismatch = chkAllowAssetsMismatch.Checked;
				starConfig.CheckAssetsDigest = chkCheckAssetsDigest.Checked;
				starConfig.AllowAdminCommands = chkAllowAdminCommands.Checked;
				starConfig.AllowAdminCommandsFromAnyone = chkAllowAdminCommandsFromAnyone.Checked;
				starConfig.AllowAnonymousConnections = chkAllowAnonymousConnections.Checked;
				starConfig.AnonymousConnectionsAreAdmin = chkAnonymousConnectionsAreAdmin.Checked;

				// Wipe Game Data
				starConfig.ClearPlayerFiles = chkClearPlayerFiles.Checked;
				starConfig.ClearUniverseFiles = chkClearUniverseFiles.Checked;

				starConfig.SaveConfig(gameStoragePath + @"\starbound.config");
			}
		}
	}

	class StarConfig {
		dynamic _starConfig;

		public StarConfig(string configFile) {
			string json = File.ReadAllText(configFile);
			_starConfig = JsonConvert.DeserializeObject(json);
		}
		public void SaveConfig(string configFile) {
			string json = JsonConvert.SerializeObject(_starConfig, Formatting.Indented);
			File.WriteAllText(configFile, json, System.Text.Encoding.UTF8);
		}
		
		// Display
		public bool Fullscreen {
			get { return _starConfig.fullscreen; }
			set { _starConfig.fullscreen = value; }
		}
		public bool Borderless {
			get { return _starConfig.borderless; }
			set { _starConfig.borderless = value; }
		}
		public bool VSync {
			get { return _starConfig.vsync; }
			set { _starConfig.vsync = value; }
		}
		public bool Maximized {
			get { return _starConfig.maximized; }
			set { _starConfig.maximized = value; }
		}
		public Newtonsoft.Json.Linq.JArray FullscreenResolution {
			get { return _starConfig.fullscreenResolution; }
			set { _starConfig.fullscreenResolution = value; }
		}
		public Newtonsoft.Json.Linq.JArray WindowedResolution {
			get { return _starConfig.windowedResolution; }
			set { _starConfig.windowedResolution = value; }
		}

		// Audio
		public int MusicVolume {
			get { return _starConfig.musicVol; }
			set { _starConfig.musicVol = value; }
		}
		public int SFXVolume {
			get { return _starConfig.sfxVol; }
			set { _starConfig.sfxVol = value; }
		}

		// Performance
		public bool LimitTextureAtlasSize {
			get { return _starConfig.limitTextureAtlasSize; }
			set { _starConfig.limitTextureAtlasSize = value; }
		}

		// Multiplayer
		public string ServerName {
			get { return _starConfig.serverName; }
			set { _starConfig.serverName = value; }
		}
		public int GameServerPort {
			get { return _starConfig.gameServerPort; }
			set { _starConfig.gameServerPort = value; }
		}
		public int MaxPlayers {
			get { return _starConfig.maxPlayers; }
			set { _starConfig.maxPlayers = value; }
		}
		public int MaxTeamSize {
			get { return _starConfig.maxTeamSize; }
			set { _starConfig.maxTeamSize = value; }
		}
		public bool ClientIPJoinable {
			get { return _starConfig.clientIPJoinable; }
			set { _starConfig.clientIPJoinable = value; }
		}
		public bool ClientP2PJoinable {
			get { return _starConfig.clientP2PJoinable; }
			set { _starConfig.clientP2PJoinable = value; }
		}
		public bool AllowAssetsMismatch {
			get { return _starConfig.allowAssetsMismatch; }
			set { _starConfig.allowAssetsMismatch = value; }
		}
		public bool CheckAssetsDigest {
			get { return _starConfig.checkAssetsDigest; }
			set { _starConfig.checkAssetsDigest = value; }
		}
		public bool AllowAdminCommands {
			get { return _starConfig.allowAdminCommands; }
			set { _starConfig.allowAdminCommands = value; }
		}
		public bool AllowAdminCommandsFromAnyone {
			get { return _starConfig.allowAdminCommandsFromAnyone; }
			set { _starConfig.allowAdminCommandsFromAnyone = value; }
		}
		public bool AllowAnonymousConnections {
			get { return _starConfig.allowAnonymousConnections; }
			set { _starConfig.allowAnonymousConnections = value; }
		}
		public bool AnonymousConnectionsAreAdmin {
			get { return _starConfig.anonymousConnectionsAreAdmin; }
			set { _starConfig.anonymousConnectionsAreAdmin = value; }
		}

		//public object bannedIPs { get; set; }
		//public object bannedUuids { get; set; }

		//"serverUsers" : {
		//},

		// Wipe Game Data
		public bool ClearPlayerFiles {
			get { return _starConfig.clearPlayerFiles; }
			set { _starConfig.clearPlayerFiles = value; }
		}

		public bool ClearUniverseFiles {
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
