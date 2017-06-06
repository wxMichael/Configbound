using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Configbound {
	public partial class BannedPlayers : Form {
		public static string BanType;

		public static Dictionary<string, JToken> SelectedBans = new Dictionary<string, JToken>() {
			["IP"] = null,
			["UUID"] = null
		};

		public static Dictionary<string, List<JToken>> BanSettings = new Dictionary<string, List<JToken>> {
			["IP"] = Globals.StarboundSettings.bannedIPs,
			["UUID"] = Globals.StarboundSettings.bannedUuids
		};

		Dictionary<string, ListView> BanLists;

		public BannedPlayers() {
			InitializeComponent();
		}
		
		private void BannedPlayers_Load(object sender, EventArgs e) {
			BanLists = new Dictionary<string, ListView> {
				["IP"] = lstBannedIPs,
				["UUID"] = lstBannedUUIDs
			};

			BanType = "IP";
			PopulateList();
			BanType = "UUID";
			PopulateList();
			BanType = null;

			btnIPAdd.Enabled = btnUUIDAdd.Enabled = true;
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			SetBanType(sender);

			// Hacky way to deselect ListView items; will fix it later ¯\_(ツ)_/¯
			PopulateList();

			new BannedPlayerEdit(false).ShowDialog(this);
		}

		private void btnEdit_Click(object sender, EventArgs e) {
			SetBanType(sender);

			if (SelectedBans[BanType] != null) new BannedPlayerEdit(true).ShowDialog(this);
		}

		private void btnRemove_Click(object sender, EventArgs e) {
			SetBanType(sender);

			if (SelectedBans[BanType] != null) {
				BanSettings[BanType].Remove(SelectedBans[BanType]);
				BanLists[BanType].Items.Remove(BanLists[BanType].SelectedItems[0]);
				SelectedBans[BanType] = null;
			}
		}

		private void BannedPlayers_SelectedIndexChanged(object sender, EventArgs e) {
			SetBanType(sender);

			if (BanSettings[BanType].Count > 0 && BanLists[BanType].SelectedIndices.Count == 1) {
				ListViewItem selection = BanLists[BanType].SelectedItems[0];
				JToken ban = (from banitem in BanSettings[BanType]
							  where (string)(banitem[BanType.ToLower()]) == selection.Text
							  select banitem).First();
				SelectedBans[BanType] = ban;
			} else {
				SelectedBans[BanType] = null;
			}

			SetControlsEnabled(SelectedBans[BanType] != null);
		}

		public void SetBanType(object control) {
			BanType = ((Control)control).Name.Contains("UUID") ? "UUID" : "IP";
		}

		public void SetControlsEnabled(bool enabled) {
			if (BanType == "IP") btnIPEdit.Enabled = btnIPRemove.Enabled = enabled;
			else btnUUIDEdit.Enabled = btnUUIDRemove.Enabled = enabled;
		}

		public void PopulateList() {
			SelectedBans[BanType] = null;
			SetControlsEnabled(false);

			BanLists[BanType].Items.Clear();
			if (BanSettings[BanType] != null) {
				foreach (JToken ban in BanSettings[BanType]) {
					ListViewItem li = new ListViewItem((string)(ban[BanType.ToLower()]));
					li.SubItems.Add((string)(ban["reason"]));
					BanLists[BanType].Items.Add(li);
				}
			}
		}
	}
}
