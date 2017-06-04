using System;
using System.Windows.Forms;

namespace Configbound {
	public partial class About : Form {
		public About() {
			InitializeComponent();
		}

		private void About_Load(object sender, EventArgs e) {
			Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
			lblVersion.Text = String.Format("v{0}.{1}", version.Major, version.Minor);
		}

		private void btnClose_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			System.Diagnostics.Process.Start("https://github.com/wxMichael/Configbound");
		}
	}
}
