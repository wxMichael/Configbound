﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Gameloop.Vdf;

namespace Configbound {
	public partial class StarSettings : Form {
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
			} catch (Exception ex) {
				throw new Exception("Failed to open registry. Please report this issue." + Environment.NewLine + ex.Message);
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
				} else {
					throw new Exception("Failed to find libraryfolders.vdf. Please report this issue.");
				}
			} catch (Exception ex) {
				throw new Exception("Failed to parse libraryfolders.vdf. Please report this issue." + Environment.NewLine + ex.Message);
			}

			// Find Starbound App Manifest
			string libraryPath = String.Empty;
			foreach (string library in libraryFolders) {
				if (File.Exists(library + @"\appmanifest_211820.acf")) {
					libraryPath = library;
					break;
				}
			}
			if (libraryPath == String.Empty) throw new Exception("Failed to find Starbound appmanifest! Please report this issue.");
			string manifestPath = libraryPath + @"\appmanifest_211820.acf";

			// Find Starbound Install Directory
			string installDir = String.Empty;
			string[] acfLines = File.ReadAllLines(manifestPath);
			foreach (string line in acfLines) {
				if (line.Contains("installdir")) {
					Globals.GameStoragePath = libraryPath + @"\common\" + line.Replace("\"installdir\"", "").Trim().Trim('"') + @"\storage";
					break;
				}
			}
			if (Globals.GameStoragePath == String.Empty) Globals.GameStoragePath = libraryPath + @"\common\Starbound\storage";
			Globals.GameConfigPath = Globals.GameStoragePath + @"\starbound.config";

			if (File.Exists(Globals.GameConfigPath)) {
				Globals.StarboundSettings = JsonConvert.DeserializeObject<SettingsRoot>(File.ReadAllText(Globals.GameConfigPath));
			} else {
				throw new Exception("Failed to read starbound.config! Please report this issue.");
			}

			InitializeComponent();
		}

		public void StarSettings_Load(object sender, EventArgs e) {
			ApplyConfig();
			lblMusicVolume.DataBindings.Add("Text", barMusicVolume, "Value");
			lblSFXVolume.DataBindings.Add("Text", barSFXVolume, "Value");
			btnSave.Enabled = btnServerUsers.Enabled = btnBannedPlayers.Enabled = true;
		}

		private void btnSave_Click(object sender, EventArgs e) {
			// Display
			Globals.StarboundSettings.fullscreen = chkFullscreen.Checked;
			Globals.StarboundSettings.borderless = chkBorderless.Checked;
			Globals.StarboundSettings.vsync = chkVSync.Checked;
			Globals.StarboundSettings.maximized = chkMaximized.Checked;
			Globals.StarboundSettings.fullscreenResolution[0] = (int)numFullscreenWidth.Value;
			Globals.StarboundSettings.fullscreenResolution[1] = (int)numFullscreenHeight.Value;
			Globals.StarboundSettings.windowedResolution[0] = (int)numWindowedWidth.Value;
			Globals.StarboundSettings.windowedResolution[1] = (int)numWindowedHeight.Value;

			// Audio
			Globals.StarboundSettings.musicVol = barMusicVolume.Value;
			Globals.StarboundSettings.sfxVol = barSFXVolume.Value;

			// Performance
			Globals.StarboundSettings.limitTextureAtlasSize = chkLimitTextureAtlasSize.Checked;

			// Multiplayer
			Globals.StarboundSettings.serverName = txtServerName.Text;
			Globals.StarboundSettings.gameServerPort = (int)numGameServerPort.Value;
			Globals.StarboundSettings.maxPlayers = (int)numMaxPlayers.Value;
			Globals.StarboundSettings.maxTeamSize = (int)numMaxTeamSize.Value;
			Globals.StarboundSettings.clientIPJoinable = chkClientIPJoinable.Checked;
			Globals.StarboundSettings.clientP2PJoinable = chkClientP2PJoinable.Checked;
			Globals.StarboundSettings.allowAssetsMismatch = chkAllowAssetsMismatch.Checked;
			Globals.StarboundSettings.checkAssetsDigest = chkCheckAssetsDigest.Checked;
			Globals.StarboundSettings.allowAdminCommands = chkAllowAdminCommands.Checked;
			Globals.StarboundSettings.allowAdminCommandsFromAnyone = chkAllowAdminCommandsFromAnyone.Checked;
			Globals.StarboundSettings.allowAnonymousConnections = chkAllowAnonymousConnections.Checked;
			Globals.StarboundSettings.anonymousConnectionsAreAdmin = chkAnonymousConnectionsAreAdmin.Checked;

			// Wipe Game Data
			Globals.StarboundSettings.clearPlayerFiles = chkClearPlayerFiles.Checked;
			Globals.StarboundSettings.clearUniverseFiles = chkClearUniverseFiles.Checked;

			try {
				File.Copy(Globals.GameConfigPath, Globals.GameConfigPath + ".bak", true);

				string json = JsonConvert.SerializeObject(Globals.StarboundSettings, Formatting.Indented);
				File.WriteAllText(Globals.GameConfigPath, json, System.Text.Encoding.UTF8);
			} catch (Exception ex) {
				MessageBox.Show("Save Failed!" + Environment.NewLine + ex.Message);
			}
		}

		private void btnServerUsers_Click(object sender, EventArgs e) {
			new ServerUsers().ShowDialog(this);
		}

		private void btnAbout_Click(object sender, EventArgs e) {
			new About().ShowDialog(this);
		}

		private void btnBannedIPs_Click(object sender, EventArgs e) {
			new BannedPlayers().ShowDialog(this);
		}

		private void ApplyConfig() {
			// Display
			chkFullscreen.Checked = Globals.StarboundSettings.fullscreen;
			chkBorderless.Checked = Globals.StarboundSettings.borderless;
			chkVSync.Checked = Globals.StarboundSettings.vsync;
			chkMaximized.Checked = Globals.StarboundSettings.maximized;
			numFullscreenWidth.Value = Globals.StarboundSettings.fullscreenResolution[0];
			numFullscreenHeight.Value = Globals.StarboundSettings.fullscreenResolution[1];
			numWindowedWidth.Value = Globals.StarboundSettings.windowedResolution[0];
			numWindowedHeight.Value = Globals.StarboundSettings.windowedResolution[1];

			// Audio
			barMusicVolume.Value = Globals.StarboundSettings.musicVol;
			barSFXVolume.Value = Globals.StarboundSettings.sfxVol;

			// Performance
			chkLimitTextureAtlasSize.Checked = Globals.StarboundSettings.limitTextureAtlasSize;

			// Multiplayer
			txtServerName.Text = Globals.StarboundSettings.serverName;
			numGameServerPort.Value = Globals.StarboundSettings.gameServerPort;
			numMaxPlayers.Value = Globals.StarboundSettings.maxPlayers;
			numMaxTeamSize.Value = Globals.StarboundSettings.maxTeamSize;
			chkClientIPJoinable.Checked = Globals.StarboundSettings.clientIPJoinable;
			chkClientP2PJoinable.Checked = Globals.StarboundSettings.clientP2PJoinable;
			chkAllowAssetsMismatch.Checked = Globals.StarboundSettings.allowAssetsMismatch;
			chkCheckAssetsDigest.Checked = Globals.StarboundSettings.checkAssetsDigest;
			chkAllowAdminCommands.Checked = Globals.StarboundSettings.allowAdminCommands;
			chkAllowAdminCommandsFromAnyone.Checked = Globals.StarboundSettings.allowAdminCommandsFromAnyone;
			chkAllowAnonymousConnections.Checked = Globals.StarboundSettings.allowAnonymousConnections;
			chkAnonymousConnectionsAreAdmin.Checked = Globals.StarboundSettings.anonymousConnectionsAreAdmin;

			// Wipe Game Data
			chkClearPlayerFiles.Checked = Globals.StarboundSettings.clearPlayerFiles;
			chkClearUniverseFiles.Checked = Globals.StarboundSettings.clearUniverseFiles;
		}
	}

	static class Globals {
		public static string GameStoragePath = String.Empty;
		public static string GameConfigPath = String.Empty;
		public static SettingsRoot StarboundSettings = null;
	}

	class SettingsRoot {
		// Display
		public bool fullscreen;
		public bool borderless;
		public bool vsync;
		public bool maximized;
		public List<int> fullscreenResolution;
		public List<int> windowedResolution;

		// Audio
		public int musicVol;
		public int sfxVol;

		// Performance
		public bool limitTextureAtlasSize;

		// Multiplayer
		public string serverName;
		public int gameServerPort;
		public int maxPlayers;
		public int maxTeamSize;
		public bool clientIPJoinable;
		public bool clientP2PJoinable;
		public bool allowAssetsMismatch;
		public bool checkAssetsDigest;
		public bool allowAdminCommands;
		public bool allowAdminCommandsFromAnyone;
		public bool allowAnonymousConnections;
		public bool anonymousConnectionsAreAdmin;
		public SubSettings serverUsers;
		public List<JToken> bannedIPs;
		public List<JToken> bannedUuids;

		// Wipe Game Data
		public bool clearPlayerFiles;
		public bool clearUniverseFiles;

		[JsonExtensionData]
		public IDictionary<string, JToken> additionalData;

		public class SubSettings {
			[JsonExtensionData]
			public IDictionary<string, JToken> additionalData;
		}


		//
		// Unimplemented starbound.config options:
		//

		//public List<int> audioChannelSeparation;

		//"configurationVersion" : {
		//	"basic" : 1,
		//	"client" : 6
		//},

		//public string gameServerBind;

		//"crafting" : {
		//	"filterHaveMaterials" : false
		//},
		//public bool interactiveHighlight;
		//"inventory" : {
		//	"pickupToActionBar" : true
		//},
		//public bool speechBubbles;
		//public int zoomLevel;
		//public bool tutorialMessages;

		//public bool modsWarningShown;
		//public int playerBackupFileCount;
		//public string queryServerBind;
		//public string rconServerBind;
		//public bool renderSleep;
		//public bool safeScripts;
		//public intLONG? scriptInstructionLimit;
		//public intLONG? scriptInstructionMeasureInterval;
		//public bool scriptProfilingEnabled;
		//public intLONG? scriptRecursionLimit;
		//public string serverFidelity;

		//"title" : {
		//	"multiPlayerAccount" : "",
		//	"multiPlayerAddress" : "",
		//	"multiPlayerPort" : ""
		//},
	}
}
