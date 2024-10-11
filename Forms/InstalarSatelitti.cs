using ConfiguratorNewest.Tracker.EmbeddedInstall;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfiguratorNewest.Forms
{
    public partial class InstalarSatelitti : Form
    {
        public InstalarSatelitti()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            InstallTrackerEmbedded installTrackerEmbedded = new InstallTrackerEmbedded();
            installTrackerEmbedded.InstallEmbeddedTracker(logInfo, keyOpenPlatform.Text, ipEmbarcado.Text, ipImpressora.Text, txtPwdMFP.Text);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ipImpressora_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPwdMFP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
