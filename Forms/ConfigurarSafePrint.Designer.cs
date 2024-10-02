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
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtIpServidor = new TextBox();
            lbl_IpServerSafePrint = new Label();
            btnSendConfig = new Button();
            hasScanToMeSafePrint = new CheckBox();
            textBox1 = new TextBox();
            lblMfpIp = new Label();
            txtWsDestSafePrint = new TextBox();
            smbConfigGroup = new GroupBox();
            modelSelected.SuspendLayout();
            groupBox2.SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 23);
            label1.Name = "label1";
            label1.Size = new Size(209, 23);
            label1.TabIndex = 1;
            label1.Text = "URL WebService SafePrint:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtIpServidor);
            groupBox2.Controls.Add(lbl_IpServerSafePrint);
            groupBox2.Controls.Add(btnSendConfig);
            groupBox2.Controls.Add(hasScanToMeSafePrint);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(lblMfpIp);
            groupBox2.Controls.Add(txtWsDestSafePrint);
            groupBox2.Controls.Add(label1);
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
            txtIpServidor.Location = new Point(457, 113);
            txtIpServidor.Name = "txtIpServidor";
            txtIpServidor.Size = new Size(226, 27);
            txtIpServidor.TabIndex = 8;
            // 
            // lbl_IpServerSafePrint
            // 
            lbl_IpServerSafePrint.AutoSize = true;
            lbl_IpServerSafePrint.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_IpServerSafePrint.Location = new Point(457, 87);
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
            btnSendConfig.Location = new Point(510, 153);
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
            hasScanToMeSafePrint.Location = new Point(240, 160);
            hasScanToMeSafePrint.Name = "hasScanToMeSafePrint";
            hasScanToMeSafePrint.Size = new Size(158, 24);
            hasScanToMeSafePrint.TabIndex = 5;
            hasScanToMeSafePrint.Text = "Possui ScanToMe?";
            hasScanToMeSafePrint.UseVisualStyleBackColor = true;
            hasScanToMeSafePrint.CheckedChanged += hasScanToMeSafePrint_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(240, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 27);
            textBox1.TabIndex = 4;
            // 
            // lblMfpIp
            // 
            lblMfpIp.AutoSize = true;
            lblMfpIp.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMfpIp.Location = new Point(240, 87);
            lblMfpIp.Name = "lblMfpIp";
            lblMfpIp.Size = new Size(91, 23);
            lblMfpIp.TabIndex = 3;
            lblMfpIp.Text = "IP da MFP:";
            // 
            // txtWsDestSafePrint
            // 
            txtWsDestSafePrint.Location = new Point(240, 49);
            txtWsDestSafePrint.Name = "txtWsDestSafePrint";
            txtWsDestSafePrint.Size = new Size(443, 27);
            txtWsDestSafePrint.TabIndex = 2;
            // 
            // smbConfigGroup
            // 
            smbConfigGroup.ForeColor = Color.White;
            smbConfigGroup.Location = new Point(12, 327);
            smbConfigGroup.Name = "smbConfigGroup";
            smbConfigGroup.Size = new Size(746, 275);
            smbConfigGroup.TabIndex = 3;
            smbConfigGroup.TabStop = false;
            smbConfigGroup.Text = "Configuração SMB";
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
            ResumeLayout(false);
        }

        #endregion

        private GroupBox modelSelected;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Label lblMfpIp;
        private TextBox txtWsDestSafePrint;
        private CheckBox hasScanToMeSafePrint;
        private RadioButton safeXerox;
        private RadioButton safeEpson;
        private RadioButton safeKyocera;
        private RadioButton safeRicoh;
        private GroupBox smbConfigGroup;
        private Button btnSendConfig;
        private TextBox txtIpServidor;
        private Label lbl_IpServerSafePrint;
    }
}