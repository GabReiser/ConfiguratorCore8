using ConfiguratorNewest.SafePrint.Epson;
using ConfiguratorNewest.SafePrint.Kyocera;
using ConfiguratorNewest.Utils;
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
    public partial class ConfigurarSafePrint : Form
    {
        private readonly ILoggerService _logger;
        public ConfigurarSafePrint()
        {
            InitializeComponent();
            smbConfigGroup.Visible = false;
            btnSendConfig.Visible = false;
            lblPort.Visible = false;
            txtPort.Visible = false;
            safeXerox.Enabled = false;
            safeRicoh.Enabled = false;
        }

        private void hasScanToMeSafePrint_CheckedChanged(object sender, EventArgs e)
        {
            string selectedModel = GetSelectedModel();
            if (hasScanToMeSafePrint.Checked)
            {
                switch (selectedModel)
                {
                    case "Ricoh":
                        break;
                    case "Kyocera":
                        smbConfigGroup.Visible = true;
                        break;
                    case "Epson":
                        smbConfigGroup.Visible = true;
                        break;
                    case "Xerox":
                        break;
                    default:
                        break;
                }
            }
            else
            {
                smbConfigGroup.Visible = false;
            }

        }

        private void modelSelected_Enter(object sender, EventArgs e)
        {
            string selectedModel = GetSelectedModel();
            btnSendConfig.Visible = true;
            if (selectedModel == "Epson")
            {
                lblMfpIp.Text = "IP do Serviço do Embarcado";
            }
            else
            {

            }
        }
        private string GetSelectedModel()
        {
            foreach (Control control in modelSelected.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text; // ou radioButton.Tag, se você estiver usando a propriedade Tag para armazenar o valor do modelo
                }
            }
            return null;
        }

        private void modelSelected_ParentChanged(object sender, EventArgs e)
        {
            btnSendConfig.Visible = true;
        }

        private void btnSendConfig_Click(object sender, EventArgs e)
        {
            SafePrintEpsonConfig safePrintEpsonConfig = new SafePrintEpsonConfig();
            SafePrintKyoceraConfig safePrintKyoceraConfig = new SafePrintKyoceraConfig();
            SendKyoceraConfig sendKyoceraConfig = new SendKyoceraConfig(_logger);
            SendEpsonConfig sendEpsonConfig = new SendEpsonConfig(_logger);

            string fabricanteSelecionado = GetSelectedModel();
            switch (fabricanteSelecionado)
            {
                case "Ricoh":
                    break;
                case "Kyocera":
                    safePrintKyoceraConfig.setIpSafePrintServer(txtIpServidor.Text);
                    safePrintKyoceraConfig.setIpPrinter(txtIpMfp.Text);
                    safePrintKyoceraConfig.setHasScanToMe(hasScanToMeSafePrint.Checked);
                    if (hasScanToMeSafePrint.Checked)
                    {
                        ScanToMeKyocera scanToMeKyocera = new ScanToMeKyocera();
                        scanToMeKyocera.setPort(txtPort.Text);
                        scanToMeKyocera.setDirectory(txtDestiny.Text);
                        scanToMeKyocera.setAccount(txtUser.Text);
                        scanToMeKyocera.setPassword(txtPassword.Text);
                        scanToMeKyocera.setMaxSize(Int32.Parse(txtMaxSize.Text));
                        safePrintKyoceraConfig.ScanToMeKyocera = scanToMeKyocera;
                    }
                    sendKyoceraConfig.SafePrintKyoceraConfig = safePrintKyoceraConfig;
                    sendKyoceraConfig.sendConfigToKyoceraAsync();
                    break;
                case "Epson":
                    safePrintEpsonConfig.setIpSafePrintServer(txtIpServidor.Text);
                    safePrintEpsonConfig.setIpServerService(txtIpMfp.Text);
                    if (hasScanToMeSafePrint.Checked)
                    {
                        ScanToMeEpson scanToMeEpson = new ScanToMeEpson();
                        scanToMeEpson.setDomain(txtDomain.Text);
                        scanToMeEpson.setDestination(txtDestiny.Text);
                        scanToMeEpson.setAccount(txtUser.Text);
                        scanToMeEpson.setPassword(txtPassword.Text);
                        scanToMeEpson.setMaxSize(Int32.Parse(txtMaxSize.Text));
                        safePrintEpsonConfig.ScanToMeEpson = scanToMeEpson;

                    }
                    sendEpsonConfig.SafePrintEpsonConfig = safePrintEpsonConfig;
                    sendEpsonConfig.sendConfigToEpson();
                    break;
                case "Xerox":
                    break;
                default:
                    break;
            }
        }

        private void safeEpson_CheckedChanged(object sender, EventArgs e)
        {
            Reset();
            lblMfpIp.Text = "IP Serviço do Embarcado";
            lbl_IpServerSafePrint.Text = "IP Servidor SafePrint";
            btnSendConfig.Visible = true;

        }

        private void safeKyocera_CheckedChanged(object sender, EventArgs e)
        {
            Reset();
            lblDomain.Text = "IP Servidor:";
            lblPort.Visible = true;
            txtPort.Visible = true;
            btnSendConfig.Visible = true;
        }

        private void Reset()
        {
            lbl_IpServerSafePrint.Text = "IP do Servidor:";
            lblDomain.Text = "Domínio:";
            lblMfpIp.Text = "IP da MFP:";
            lblPort.Visible = false;
            txtPort.Visible = false;
            smbConfigGroup.Visible = false;
            btnSendConfig.Visible = false;
            hasScanToMeSafePrint.Checked = false;
        }

        private void EnterFocusTxt(TextBox txt)
        {
            txt.ForeColor = Color.SteelBlue;
        }
        private void LeaveFocusTxt(TextBox txt)
        {
            txt.ForeColor = Color.Gray;
        }

        private void txtIpMfp_Enter(object sender, EventArgs e)
        {
            EnterFocusTxt(txtIpMfp);
        }

        private void txtIpMfp_Leave(object sender, EventArgs e)
        {
            LeaveFocusTxt(txtIpMfp);
        }
    }
}
