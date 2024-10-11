using ConfiguratorNewest.SmartShare.Epson;
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
    public partial class InstalarShare : Form
    {
        public InstalarShare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InstallServiceEpsonShare installServiceEpsonShare = new InstallServiceEpsonShare();
            installServiceEpsonShare.InstallServiceEpson();
        }
    }
}
