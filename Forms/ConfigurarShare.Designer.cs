namespace ConfiguratorNewest.Forms
{
    partial class ConfigurarShare
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
            button1 = new Button();
            chkDevMode = new CheckBox();
            checkBoxSsl = new CheckBox();
            label3 = new Label();
            txtWsDest = new TextBox();
            lblIpMFP = new Label();
            txtIPMFP = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUser = new TextBox();
            lblUser = new Label();
            btnSendConfig = new Button();
            modelSelected = new GroupBox();
            safeXerox = new RadioButton();
            safeEpson = new RadioButton();
            safeKyocera = new RadioButton();
            rdRicohMfp = new RadioButton();
            txtLog = new RichTextBox();
            groupBox1 = new GroupBox();
            progressBar1 = new ProgressBar();
            groupBox2.SuspendLayout();
            modelSelected.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(chkDevMode);
            groupBox2.Controls.Add(checkBoxSsl);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtWsDest);
            groupBox2.Controls.Add(lblIpMFP);
            groupBox2.Controls.Add(txtIPMFP);
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Controls.Add(lblPassword);
            groupBox2.Controls.Add(txtUser);
            groupBox2.Controls.Add(lblUser);
            groupBox2.Controls.Add(btnSendConfig);
            groupBox2.Controls.Add(modelSelected);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(746, 280);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Configurador SmartShare";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(51, 49, 56);
            button1.Location = new Point(701, 16);
            button1.Name = "button1";
            button1.Size = new Size(39, 29);
            button1.TabIndex = 17;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // chkDevMode
            // 
            chkDevMode.AutoSize = true;
            chkDevMode.FlatStyle = FlatStyle.Flat;
            chkDevMode.ForeColor = Color.White;
            chkDevMode.Location = new Point(586, 161);
            chkDevMode.Name = "chkDevMode";
            chkDevMode.Size = new Size(92, 24);
            chkDevMode.TabIndex = 16;
            chkDevMode.Text = "DevMode";
            chkDevMode.UseVisualStyleBackColor = true;
            chkDevMode.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBoxSsl
            // 
            checkBoxSsl.AutoSize = true;
            checkBoxSsl.Location = new Point(586, 131);
            checkBoxSsl.Name = "checkBoxSsl";
            checkBoxSsl.Size = new Size(116, 24);
            checkBoxSsl.TabIndex = 15;
            checkBoxSsl.Text = "Habilitar SSL";
            checkBoxSsl.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(243, 54);
            label3.Name = "label3";
            label3.Size = new Size(162, 23);
            label3.TabIndex = 14;
            label3.Text = "URL do SmartShare:";
            // 
            // txtWsDest
            // 
            txtWsDest.Location = new Point(243, 80);
            txtWsDest.Name = "txtWsDest";
            txtWsDest.Size = new Size(294, 27);
            txtWsDest.TabIndex = 13;
            // 
            // lblIpMFP
            // 
            lblIpMFP.AutoSize = true;
            lblIpMFP.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIpMFP.Location = new Point(243, 118);
            lblIpMFP.Name = "lblIpMFP";
            lblIpMFP.Size = new Size(91, 23);
            lblIpMFP.TabIndex = 12;
            lblIpMFP.Text = "IP da MFP:";
            lblIpMFP.Click += label2_Click;
            // 
            // txtIPMFP
            // 
            txtIPMFP.Location = new Point(243, 144);
            txtIPMFP.Name = "txtIPMFP";
            txtIPMFP.Size = new Size(294, 27);
            txtIPMFP.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(393, 203);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(144, 27);
            txtPassword.TabIndex = 10;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(393, 177);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(61, 23);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Senha:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(243, 203);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(144, 27);
            txtUser.TabIndex = 8;
            txtUser.Text = "admin";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(243, 177);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(72, 23);
            lblUser.TabIndex = 7;
            lblUser.Text = "Usuário:";
            lblUser.Click += lbl_IpServerSafePrint_Click;
            // 
            // btnSendConfig
            // 
            btnSendConfig.BackColor = Color.FromArgb(255, 49, 46);
            btnSendConfig.FlatStyle = FlatStyle.Flat;
            btnSendConfig.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendConfig.ForeColor = Color.FromArgb(255, 209, 208);
            btnSendConfig.Location = new Point(555, 80);
            btnSendConfig.Name = "btnSendConfig";
            btnSendConfig.Size = new Size(173, 37);
            btnSendConfig.TabIndex = 6;
            btnSendConfig.Text = "Enviar configuração";
            btnSendConfig.UseVisualStyleBackColor = false;
            btnSendConfig.Click += btnSendConfig_Click;
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
            safeXerox.CheckedChanged += safeXerox_CheckedChanged;
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
            // txtLog
            // 
            txtLog.Location = new Point(17, 26);
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(729, 213);
            txtLog.TabIndex = 4;
            txtLog.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLog);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(12, 298);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(761, 258);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Log de Eventos";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 562);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(761, 37);
            progressBar1.TabIndex = 9;
            // 
            // ConfigurarShare
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 49, 56);
            ClientSize = new Size(800, 635);
            Controls.Add(progressBar1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "ConfigurarShare";
            Text = "ConfigurarShare";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            modelSelected.ResumeLayout(false);
            modelSelected.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox txtUser;
        private Label lblUser;
        private Button btnSendConfig;
        private GroupBox modelSelected;
        private RadioButton safeXerox;
        private RadioButton safeEpson;
        private RadioButton safeKyocera;
        private RadioButton rdRicohMfp;
        private RichTextBox txtLog;
        private GroupBox groupBox1;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblIpMFP;
        private TextBox txtIPMFP;
        private Label label3;
        private TextBox txtWsDest;
        private CheckBox checkBoxSsl;
        private ProgressBar progressBar1;
        private CheckBox chkDevMode;
        private Button button1;
    }
}