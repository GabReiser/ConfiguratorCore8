namespace ConfiguratorNewest.Forms
{
    partial class ConfigurarSatelitti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            hasScanToMe = new CheckBox();
            button1 = new Button();
            modelSelected = new GroupBox();
            safeXerox = new RadioButton();
            safeEpson = new RadioButton();
            safeKyocera = new RadioButton();
            rdRicohMfp = new RadioButton();
            chkDevMode = new CheckBox();
            label3 = new Label();
            checkBoxSsl = new CheckBox();
            btnSendConfig = new Button();
            txtUser = new TextBox();
            txtWsDest = new TextBox();
            txtPassword = new TextBox();
            txtIPMFP = new TextBox();
            progressBar1 = new ProgressBar();
            txtLog = new RichTextBox();
            groupBox2.SuspendLayout();
            modelSelected.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(hasScanToMe);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(modelSelected);
            groupBox2.Controls.Add(chkDevMode);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(checkBoxSsl);
            groupBox2.Controls.Add(btnSendConfig);
            groupBox2.Controls.Add(txtUser);
            groupBox2.Controls.Add(txtWsDest);
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Controls.Add(txtIPMFP);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(766, 280);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Configurador SafePrint";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(395, 174);
            label4.Name = "label4";
            label4.Size = new Size(61, 23);
            label4.TabIndex = 30;
            label4.Text = "Senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(245, 174);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 29;
            label2.Text = "Usuário:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(245, 118);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 28;
            label1.Text = "IP da MFP:";
            // 
            // hasScanToMe
            // 
            hasScanToMe.AutoSize = true;
            hasScanToMe.Location = new Point(588, 191);
            hasScanToMe.Name = "hasScanToMe";
            hasScanToMe.Size = new Size(99, 24);
            hasScanToMe.TabIndex = 27;
            hasScanToMe.Text = "ScanToMe";
            hasScanToMe.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(51, 49, 56);
            button1.Location = new Point(721, 14);
            button1.Name = "button1";
            button1.Size = new Size(39, 29);
            button1.TabIndex = 26;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // modelSelected
            // 
            modelSelected.Controls.Add(safeXerox);
            modelSelected.Controls.Add(safeEpson);
            modelSelected.Controls.Add(safeKyocera);
            modelSelected.Controls.Add(rdRicohMfp);
            modelSelected.FlatStyle = FlatStyle.Flat;
            modelSelected.ForeColor = Color.White;
            modelSelected.Location = new Point(41, 42);
            modelSelected.Name = "modelSelected";
            modelSelected.Size = new Size(157, 201);
            modelSelected.TabIndex = 0;
            modelSelected.TabStop = false;
            modelSelected.Text = "Selecione o modelo";
            // 
            // safeXerox
            // 
            safeXerox.AutoSize = true;
            safeXerox.Location = new Point(6, 118);
            safeXerox.Name = "safeXerox";
            safeXerox.Size = new Size(68, 24);
            safeXerox.TabIndex = 7;
            safeXerox.TabStop = true;
            safeXerox.Text = "Xerox";
            safeXerox.UseVisualStyleBackColor = true;
            // 
            // safeEpson
            // 
            safeEpson.AutoSize = true;
            safeEpson.Location = new Point(6, 88);
            safeEpson.Name = "safeEpson";
            safeEpson.Size = new Size(70, 24);
            safeEpson.TabIndex = 6;
            safeEpson.TabStop = true;
            safeEpson.Text = "Epson";
            safeEpson.UseVisualStyleBackColor = true;
            safeEpson.CheckedChanged += safeEpson_CheckedChanged;
            // 
            // safeKyocera
            // 
            safeKyocera.AutoSize = true;
            safeKyocera.Location = new Point(6, 56);
            safeKyocera.Name = "safeKyocera";
            safeKyocera.Size = new Size(82, 24);
            safeKyocera.TabIndex = 5;
            safeKyocera.TabStop = true;
            safeKyocera.Text = "Kyocera";
            safeKyocera.UseVisualStyleBackColor = true;
            // 
            // rdRicohMfp
            // 
            rdRicohMfp.AutoSize = true;
            rdRicohMfp.Location = new Point(6, 26);
            rdRicohMfp.Name = "rdRicohMfp";
            rdRicohMfp.Size = new Size(67, 24);
            rdRicohMfp.TabIndex = 4;
            rdRicohMfp.TabStop = true;
            rdRicohMfp.Text = "Ricoh";
            rdRicohMfp.UseVisualStyleBackColor = true;
            rdRicohMfp.CheckedChanged += rdRicohMfp_CheckedChanged;
            // 
            // chkDevMode
            // 
            chkDevMode.AutoSize = true;
            chkDevMode.FlatStyle = FlatStyle.Flat;
            chkDevMode.ForeColor = Color.White;
            chkDevMode.Location = new Point(588, 161);
            chkDevMode.Name = "chkDevMode";
            chkDevMode.Size = new Size(92, 24);
            chkDevMode.TabIndex = 25;
            chkDevMode.Text = "DevMode";
            chkDevMode.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(245, 54);
            label3.Name = "label3";
            label3.Size = new Size(128, 23);
            label3.TabIndex = 23;
            label3.Text = "URL do Tracker:";
            // 
            // checkBoxSsl
            // 
            checkBoxSsl.AutoSize = true;
            checkBoxSsl.Location = new Point(588, 131);
            checkBoxSsl.Name = "checkBoxSsl";
            checkBoxSsl.Size = new Size(116, 24);
            checkBoxSsl.TabIndex = 24;
            checkBoxSsl.Text = "Habilitar SSL";
            checkBoxSsl.UseVisualStyleBackColor = true;
            // 
            // btnSendConfig
            // 
            btnSendConfig.BackColor = Color.FromArgb(255, 49, 46);
            btnSendConfig.FlatStyle = FlatStyle.Flat;
            btnSendConfig.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendConfig.ForeColor = Color.FromArgb(255, 209, 208);
            btnSendConfig.Location = new Point(557, 80);
            btnSendConfig.Name = "btnSendConfig";
            btnSendConfig.Size = new Size(173, 37);
            btnSendConfig.TabIndex = 18;
            btnSendConfig.Text = "Enviar configuração";
            btnSendConfig.UseVisualStyleBackColor = false;
            btnSendConfig.Click += btnSendConfig_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(245, 203);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(144, 27);
            txtUser.TabIndex = 19;
            txtUser.Text = "admin";
            // 
            // txtWsDest
            // 
            txtWsDest.Location = new Point(245, 80);
            txtWsDest.Name = "txtWsDest";
            txtWsDest.Size = new Size(294, 27);
            txtWsDest.TabIndex = 22;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(395, 203);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(144, 27);
            txtPassword.TabIndex = 20;
            // 
            // txtIPMFP
            // 
            txtIPMFP.Location = new Point(245, 144);
            txtIPMFP.Name = "txtIPMFP";
            txtIPMFP.Size = new Size(294, 27);
            txtIPMFP.TabIndex = 21;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 409);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(766, 29);
            progressBar1.TabIndex = 4;
            // 
            // txtLog
            // 
            txtLog.Location = new Point(12, 298);
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(766, 105);
            txtLog.TabIndex = 5;
            txtLog.Text = "";
            // 
            // ConfigurarSatelitti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 49, 56);
            ClientSize = new Size(800, 450);
            Controls.Add(txtLog);
            Controls.Add(progressBar1);
            Controls.Add(groupBox2);
            Name = "ConfigurarSatelitti";
            Text = "ConfigurarSatelitti";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            modelSelected.ResumeLayout(false);
            modelSelected.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox modelSelected;
        private RadioButton safeXerox;
        private RadioButton safeEpson;
        private RadioButton safeKyocera;
        private RadioButton rdRicohMfp;
        private Button button1;
        private CheckBox chkDevMode;
        private Label label3;
        private CheckBox checkBoxSsl;
        private Button btnSendConfig;
        private TextBox txtUser;
        private TextBox txtWsDest;
        private TextBox txtPassword;
        private TextBox txtIPMFP;
        private ProgressBar progressBar1;
        private RichTextBox txtLog;
        private CheckBox hasScanToMe;
        private Label label4;
        private Label label2;
        private Label label1;
    }
}