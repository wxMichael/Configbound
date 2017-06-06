using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Configbound {
	public partial class BannedPlayerEdit : Form {
		bool _isEditing;

		public BannedPlayerEdit(bool isEditing) {
			_isEditing = isEditing;
			InitializeComponent();
		}

		private void BannedPlayerEdit_Load(object sender, EventArgs e) {
			lblBanType.Text = BannedPlayers.BanType == "IP" ? "IP Address" : "Char UUID";

			if (_isEditing) {
				txtBanType.Text = (string)(BannedPlayers.SelectedBans[BannedPlayers.BanType][BannedPlayers.BanType.ToLower()]);
				txtReason.Text = (string)(BannedPlayers.SelectedBans[BannedPlayers.BanType]["reason"]);
			}
		}

		private void btnSaveBan_Click(object sender, EventArgs e) {
			string typeTrimmed = txtBanType.Text.Trim();
			string reasonTrimmed = txtReason.Text.Trim();

			if (typeTrimmed == String.Empty || reasonTrimmed == String.Empty) {
				MessageBox.Show("Please enter both " + BannedPlayers.BanType + " and reason.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (BannedPlayers.BanType == "UUID" && typeTrimmed.Length != 32) {
				MessageBox.Show(String.Format("The UUID entered has an invalid length ({0}/32).", typeTrimmed.Length), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Check if ban list is currently empty
			bool noBans = BannedPlayers.BanSettings[BannedPlayers.BanType] == null;

			if (_isEditing) {
				BannedPlayers.SelectedBans[BannedPlayers.BanType][BannedPlayers.BanType.ToLower()] = typeTrimmed;
				BannedPlayers.SelectedBans[BannedPlayers.BanType]["reason"] = reasonTrimmed;
			} else {
				if (noBans) {
					string jsonKey = BannedPlayers.BanType == "IP" ? "bannedIPs" : "bannedUuids";
					string bannedPlayersJson = String.Format(@"
					{{
						""{0}"" : [{
							""{1}"" : ""{2}"",
							""reason"" : ""{3}""
						}]
					}}", jsonKey, BannedPlayers.BanType.ToLower(), typeTrimmed, reasonTrimmed);
					List<JToken> newSettings = JsonConvert.DeserializeObject<List<JToken>>(bannedPlayersJson);
					BannedPlayers.BanSettings[BannedPlayers.BanType] = newSettings;
				} else {
					JToken banJson = JToken.Parse(String.Format(@"
					{{
						""{0}"" : ""{1}"",
						""reason"" : ""{2}""
					}}", BannedPlayers.BanType.ToLower(), typeTrimmed, reasonTrimmed));
					BannedPlayers.BanSettings[BannedPlayers.BanType].Add(banJson);
				}
			}
			((BannedPlayers)this.Owner).PopulateList();
			this.Close();
		}
	}
}
