using ConfiguratorNewest.Enum;
using ConfiguratorNewest.SmartShare;
using ConfiguratorNewest.Tracker;
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
    public partial class ConfigurarSatelitti : Form
    {
        #region properties
        const string MSG_EXAMPLE_WS = "http://[ip_address]:64655/RPortalService";
        delegate void FillLogComponent(String msg);
        private static readonly EmbeddedManagement embeddedCore = new EmbeddedManagement();
        private ActionType action;
        #endregion
        public ConfigurarSatelitti()
        {
            InitializeComponent();
            safeKyocera.Enabled = false;
            safeXerox.Enabled = false;
            chkDevMode.Visible = false;
            txtUser.Enabled = false;
            txtPassword.Enabled = false;
            hasScanToMe.Visible = false;
        }

        private void btnSendConfig_Click(object sender, EventArgs e)
        {
            try
            {

                string model = GetSelectedModel();
                if (model == "Epson")
                {
                    SendConfigurationTracker sendConfigurationTracker = new SendConfigurationTracker();
                    sendConfigurationTracker.SendConfiguration(txtIPMFP.Text, txtWsDest.Text, chkDevMode.Checked, hasScanToMe.Checked);
                    return;
                }
                string actionS = (sender as Button).Text.ToLower();
                action = ActionType.Install;

                EmbeddedParamsInfo info = new EmbeddedParamsInfo()
                {
                    DsUrlWebService = txtIPMFP.Text,
                    DsIPMFP = txtIPMFP.Text,
                    DsPassword = txtUser.Text,
                    DsUser = txtUser.Text,
                    SslActive = checkBoxSsl.Checked,
                    Product = Product.Tracker
                };

                if (info.Validate(action))
                {

                    DialogResult dr = MessageBox.Show(String.Format("Confirma configurar a URL do Embarcado SmartShare no equipamento com IP:{0}?", info.DsIPMFP), "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        new Thread(() =>
                        {
                            Thread.CurrentThread.IsBackground = true;
                            ProcessConfiguration(info);
                            //progressBar1.Value = 100;
                        }).Start();
                    }
                }

            }
            catch (Exception ex)
            {
                LogMessage(String.Concat("ERROR: ", ex.Message));

                DisableEnableAll(true);
                //LogMessage("Finished.");
                progressBar1.Value = 100;
                this.Refresh();
            }
        }

        private void ProcessConfiguration(EmbeddedParamsInfo info)
        {
            DisableEnableAll(false);
            progressBar1.Value = 0;
            this.Refresh();

            ClearLog();
            LogMessage("Starting...");

            try
            {
                if (action == ActionType.Install)
                {
                    if (rdRicohMfp.Checked)
                        embeddedCore.Install(info, Company.Ricoh, true);
                }


            }
            catch (HttpRequestException e)
            {
                LogMessage(string.Format("Url is invalid. " + e.Message));
            }
            catch (Exception e)
            {
                LogMessage(string.Format("Something went wrong during the configuration process. Please, contact the System Administrator. " + e.Message));
            }
            finally
            {
                DisableEnableAll(true);
                //LogMessage("Finished.");
                //progressBar1.Value = 100;
                this.Refresh();
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

        private void LogMessage(String msg)
        {
            txtLog.SelectionStart = txtLog.TextLength;
            txtLog.SelectionLength = 0;

            txtLog.SelectionColor = BLL.EmbeddedBLL.ChoiceColor(msg);

            ValidateProgressPerMessage(msg);

            if (!String.IsNullOrEmpty(msg)) txtLog.AppendText(String.Format("{0} {1} {2}", DateTime.Now.ToString("T"), msg, Environment.NewLine));

            txtLog.SelectionColor = txtLog.ForeColor;

            txtLog.SelectionStart = txtLog.Text.Length;
            try
            {
                txtLog.ScrollToCaret();
                this.Refresh();
            }
            catch (Exception) { }
        }

        private void DisableEnableAll(bool isEnable)
        {
            txtWsDest.Enabled = isEnable;
            txtIPMFP.Enabled = isEnable;
        }

        private void ValidateProgressPerMessage(String msg)
        {
            if (!String.IsNullOrEmpty(msg))
            {
                if (msg.ToUpper().Contains("STATE_GET_APP_INFO_START") && progressBar1.Value < 100) progressBar1.Value = 10;
                if (msg.ToUpper().Contains("STATE_GET_APP_INFO_END") && progressBar1.Value < 100) progressBar1.Value = 20;
                if (msg.ToUpper().Contains("STATE_STOP_APP_START") && progressBar1.Value < 100) progressBar1.Value = 30;
                if (msg.ToUpper().Contains("STATE_STOP_APP_END") && progressBar1.Value < 100) progressBar1.Value = 40;

                if (action == ActionType.Install)
                {
                    if (msg.ToUpper().Contains("STATE_UNINSTALL_START") && progressBar1.Value < 100) progressBar1.Value = 50;
                    if (msg.ToUpper().Contains("STATE_UNINSTALL_END") && progressBar1.Value < 100) progressBar1.Value = 60;
                    if (msg.ToUpper().Contains("STATE_INSTALL_START") && progressBar1.Value < 50) progressBar1.Value = 70;
                    if (msg.ToUpper().Contains("STATE_INSTALL_END") && progressBar1.Value < 50) progressBar1.Value = 80;
                    if (msg.ToUpper().Contains("STATE_REBOOT_START") && progressBar1.Value < 100) progressBar1.Value = 90;
                    if (msg.ToUpper().Contains("STATE_REBOOT_WAIT") && progressBar1.Value < 100) progressBar1.Value = 95;
                    if (msg.ToUpper().Contains("PLEASE WAIT") && progressBar1.Value < 100) progressBar1.Value = 95;
                    if (msg.ToUpper().Contains("SETUP ANDROID APP IS DONE!") && progressBar1.Value <= 100) progressBar1.Value = 100;

                }
                if (action == ActionType.Uninstall)
                {
                    if (msg.ToUpper().Contains("STATE_UNINSTALL_START") && progressBar1.Value < 100) progressBar1.Value = 80;
                    if (msg.ToUpper().Contains("STATE_UNINSTALL_COMMIT") && progressBar1.Value < 50) progressBar1.Value = 90;
                    if (msg.ToUpper().Contains("STATE_UNINSTALL_END") && progressBar1.Value < 100) progressBar1.Value = 95;
                    if (msg.ToUpper().Contains("REBOOT_END") && progressBar1.Value < 100) progressBar1.Value = 100;
                }

                this.Refresh();
                progressBar1.Refresh();
            }
        }
        private void ClearLog()
        {
            txtLog.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chkDevMode.Visible == true)
            {
                chkDevMode.Visible = false;
            }
            else
            {
                chkDevMode.Visible = true;
            }
            
        }

        private void safeEpson_CheckedChanged(object sender, EventArgs e)
        {
            ResetModelsSelected();
            txtUser.Visible = false;
            txtPassword.Visible = false;
            label1.Text = "IP do Serviço Embarcado:";
            label3.Text = "IP do Serviço Agent:";
            hasScanToMe.Visible = true;
            label2.Visible = false;
            label4.Visible = false;

        }
        private void ResetModelsSelected()
        {
            label1.Text = "URL do Tracker:";
            label3.Text = "IP da MFP:";
            label2.Visible = true;
            label4.Visible = true;
            txtUser.Visible = true;
            txtPassword.Visible = true;
            hasScanToMe.Visible = false;
            chkDevMode.Visible = false;

        }

        private void rdRicohMfp_CheckedChanged(object sender, EventArgs e)
        {
            ResetModelsSelected();
        }
    }
}
