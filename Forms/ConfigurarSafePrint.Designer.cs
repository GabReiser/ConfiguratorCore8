namespace ConfiguratorNewest.Forms
{
    partial class ConfigurarSafePrint
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
            modelSelected = new GroupBox();
            safeXerox = new RadioButton();
            safeEpson = new RadioButton();
            safeKyocera = new RadioButton();
            safeRicoh = new RadioButton();
            groupBox2 = new GroupBox();
            txtIpServidor = new TextBox();
            lbl_IpServerSafePrint = new Label();
            btnSendConfig = new Button();
            hasScanToMeSafePrint = new CheckBox();
            txtIpMfp = new TextBox();
            lblMfpIp = new Label();
            smbConfigGroup = new GroupBox();
            lblPort = new Label();
            txtPort = new TextBox();
            lblMaxSize = new Label();
            lblUser = new Label();
            lblPassword = new Label();
            lblDestiny = new Label();
            lblDomain = new Label();
            txtMaxSize = new TextBox();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            txtDestiny = new TextBox();
            txtDomain = new TextBox();
            modelSelected.SuspendLayout();
            groupBox2.SuspendLayout();
            smbConfigGroup.SuspendLayout();
            SuspendLayout();
            // 
            // modelSelected
            // 
            modelSelected.Controls.Add(safeXerox);
            modelSelected.Controls.Add(safeEpson);
            modelSelected.Controls.Add(safeKyocera);
            modelSelected.Controls.Add(safeRicoh);
            modelSelected.FlatStyle = FlatStyle.Flat;
            modelSelected.ForeColor = Color.White;
            modelSelected.Location = new Point(41, 42);
            modelSelected.Name = "modelSelected";
            modelSelected.Size = new Size(157, 201);
            modelSelected.TabIndex = 0;
            modelSelected.TabStop = false;
            modelSelected.Text = "Selecione o modelo";
            modelSelected.Enter += modelSelected_Enter;
            modelSelected.ParentChanged += modelSelected_ParentChanged;
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
            safeKyocera.CheckedChanged += safeKyocera_CheckedChanged;
            // 
            // safeRicoh
            // 
            safeRicoh.AutoSize = true;
            safeRicoh.Location = new Point(6, 26);
            safeRicoh.Name = "safeRicoh";
            safeRicoh.Size = new Size(67, 24);
            safeRicoh.TabIndex = 4;
            safeRicoh.TabStop = true;
            safeRicoh.Text = "Ricoh";
            safeRicoh.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtIpServidor);
            groupBox2.Controls.Add(lbl_IpServerSafePrint);
            groupBox2.Controls.Add(btnSendConfig);
            groupBox2.Controls.Add(hasScanToMeSafePrint);
            groupBox2.Controls.Add(txtIpMfp);
            groupBox2.Controls.Add(lblMfpIp);
            groupBox2.Controls.Add(modelSelected);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(12, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(746, 280);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Configurador SafePrint";
            // 
            // txtIpServidor
            // 
            txtIpServidor.BorderStyle = BorderStyle.None;
            txtIpServidor.Location = new Point(472, 115);
            txtIpServidor.Name = "txtIpServidor";
            txtIpServidor.Size = new Size(226, 20);
            txtIpServidor.TabIndex = 8;
            // 
            // lbl_IpServerSafePrint
            // 
            lbl_IpServerSafePrint.AutoSize = true;
            lbl_IpServerSafePrint.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_IpServerSafePrint.Location = new Point(472, 89);
            lbl_IpServerSafePrint.Name = "lbl_IpServerSafePrint";
            lbl_IpServerSafePrint.Size = new Size(121, 23);
            lbl_IpServerSafePrint.TabIndex = 7;
            lbl_IpServerSafePrint.Text = "IP do Servidor:";
            // 
            // btnSendConfig
            // 
            btnSendConfig.BackColor = Color.FromArgb(255, 49, 46);
            btnSendConfig.FlatStyle = FlatStyle.Flat;
            btnSendConfig.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendConfig.ForeColor = Color.FromArgb(255, 209, 208);
            btnSendConfig.Location = new Point(525, 155);
            btnSendConfig.Name = "btnSendConfig";
            btnSendConfig.Size = new Size(173, 37);
            btnSendConfig.TabIndex = 6;
            btnSendConfig.Text = "Enviar configuração";
            btnSendConfig.UseVisualStyleBackColor = false;
            btnSendConfig.Click += btnSendConfig_Click;
            // 
            // hasScanToMeSafePrint
            // 
            hasScanToMeSafePrint.AutoSize = true;
            hasScanToMeSafePrint.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hasScanToMeSafePrint.Location = new Point(255, 162);
            hasScanToMeSafePrint.Name = "hasScanToMeSafePrint";
            hasScanToMeSafePrint.Size = new Size(158, 24);
            hasScanToMeSafePrint.TabIndex = 5;
            hasScanToMeSafePrint.Text = "Possui ScanToMe?";
            hasScanToMeSafePrint.UseVisualStyleBackColor = true;
            hasScanToMeSafePrint.CheckedChanged += hasScanToMeSafePrint_CheckedChanged;
            // 
            // txtIpMfp
            // 
            txtIpMfp.BorderStyle = BorderStyle.None;
            txtIpMfp.Location = new Point(255, 115);
            txtIpMfp.Name = "txtIpMfp";
            txtIpMfp.Size = new Size(209, 20);
            txtIpMfp.TabIndex = 4;
            // 
            // lblMfpIp
            // 
            lblMfpIp.AutoSize = true;
            lblMfpIp.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMfpIp.Location = new Point(255, 89);
            lblMfpIp.Name = "lblMfpIp";
            lblMfpIp.Size = new Size(91, 23);
            lblMfpIp.TabIndex = 3;
            lblMfpIp.Text = "IP da MFP:";
            // 
            // smbConfigGroup
            // 
            smbConfigGroup.Controls.Add(lblPort);
            smbConfigGroup.Controls.Add(txtPort);
            smbConfigGroup.Controls.Add(lblMaxSize);
            smbConfigGroup.Controls.Add(lblUser);
            smbConfigGroup.Controls.Add(lblPassword);
            smbConfigGroup.Controls.Add(lblDestiny);
            smbConfigGroup.Controls.Add(lblDomain);
            smbConfigGroup.Controls.Add(txtMaxSize);
            smbConfigGroup.Controls.Add(txtPassword);
            smbConfigGroup.Controls.Add(txtUser);
            smbConfigGroup.Controls.Add(txtDestiny);
            smbConfigGroup.Controls.Add(txtDomain);
            smbConfigGroup.ForeColor = Color.White;
            smbConfigGroup.Location = new Point(12, 327);
            smbConfigGroup.Name = "smbConfigGroup";
            smbConfigGroup.Size = new Size(746, 275);
            smbConfigGroup.TabIndex = 3;
            smbConfigGroup.TabStop = false;
            smbConfigGroup.Text = "Configuração SMB";
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(414, 172);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(46, 20);
            lblPort.TabIndex = 11;
            lblPort.Text = "Porta:";
            // 
            // txtPort
            // 
            txtPort.BorderStyle = BorderStyle.None;
            txtPort.Location = new Point(414, 195);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(125, 20);
            txtPort.TabIndex = 10;
            // 
            // lblMaxSize
            // 
            lblMaxSize.AutoSize = true;
            lblMaxSize.Location = new Point(47, 172);
            lblMaxSize.Name = "lblMaxSize";
            lblMaxSize.Size = new Size(130, 20);
            lblMaxSize.TabIndex = 9;
            lblMaxSize.Text = "Tamanho máximo:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(47, 107);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(62, 20);
            lblUser.TabIndex = 8;
            lblUser.Text = "Usuário:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(414, 107);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(52, 20);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Senha:";
            // 
            // lblDestiny
            // 
            lblDestiny.AutoSize = true;
            lblDestiny.Location = new Point(414, 40);
            lblDestiny.Name = "lblDestiny";
            lblDestiny.Size = new Size(63, 20);
            lblDestiny.TabIndex = 6;
            lblDestiny.Text = "Destíno:";
            // 
            // lblDomain
            // 
            lblDomain.AutoSize = true;
            lblDomain.Location = new Point(47, 40);
            lblDomain.Name = "lblDomain";
            lblDomain.Size = new Size(67, 20);
            lblDomain.TabIndex = 5;
            lblDomain.Text = "Domínio";
            // 
            // txtMaxSize
            // 
            txtMaxSize.BorderStyle = BorderStyle.None;
            txtMaxSize.Location = new Point(47, 195);
            txtMaxSize.Name = "txtMaxSize";
            txtMaxSize.Size = new Size(130, 20);
            txtMaxSize.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(414, 130);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(256, 20);
            txtPassword.TabIndex = 3;
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Location = new Point(47, 130);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(256, 20);
            txtUser.TabIndex = 2;
            // 
            // txtDestiny
            // 
            txtDestiny.BorderStyle = BorderStyle.None;
            txtDestiny.Location = new Point(414, 68);
            txtDestiny.Name = "txtDestiny";
            txtDestiny.Size = new Size(256, 20);
            txtDestiny.TabIndex = 1;
            // 
            // txtDomain
            // 
            txtDomain.BorderStyle = BorderStyle.None;
            txtDomain.Location = new Point(47, 68);
            txtDomain.Name = "txtDomain";
            txtDomain.Size = new Size(256, 20);
            txtDomain.TabIndex = 0;
            // 
            // ConfigurarSafePrint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(51, 49, 56);
            ClientSize = new Size(1078, 645);
            Controls.Add(smbConfigGroup);
            Controls.Add(groupBox2);
            Name = "ConfigurarSafePrint";
            Text = "ConfigurarSafePrint";
            modelSelected.ResumeLayout(false);
            modelSelected.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            smbConfigGroup.ResumeLayout(false);
            smbConfigGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox modelSelected;
        private GroupBox groupBox2;
        private TextBox txtIpMfp;
        private Label lblMfpIp;
        private CheckBox hasScanToMeSafePrint;
        private RadioButton safeXerox;
        private RadioButton safeEpson;
        private RadioButton safeKyocera;
        private RadioButton safeRicoh;
        private GroupBox smbConfigGroup;
        private Button btnSendConfig;
        private TextBox txtIpServidor;
        private Label lbl_IpServerSafePrint;
        private Label lblUser;
        private Label lblPassword;
        private Label lblDestiny;
        private Label lblDomain;
        private TextBox txtMaxSize;
        private TextBox txtPassword;
        private TextBox txtUser;
        private TextBox txtDestiny;
        private TextBox txtDomain;
        private Label lblMaxSize;
        private TextBox txtPort;
        private Label lblPort;
    }
}