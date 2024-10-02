using ConfiguratorNewest.SafePrint.Epson;
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
        public ConfigurarSafePrint()
        {
            InitializeComponent();
            smbConfigGroup.Visible = false;
            btnSendConfig.Visible = false;
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
            btnSendConfig.Visible = true;
            if(GetSelectedModel() == "Epson")
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
            string fabricanteSelecionado = GetSelectedModel();
            switch (fabricanteSelecionado)
            {
                case "Ricoh":
                    break;
                case "Kyocera":
                    break;
                case "Epson":
                    safePrintEpsonConfig.setIpSafePrintServer(txtIpServidor.Text);
                    safePrintEpsonConfig.setIpServerService();
                    break;
                case "Xerox":
                    break;
                default:
                    break;
            }
        }
    }
}
