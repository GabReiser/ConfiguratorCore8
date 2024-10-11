namespace ConfiguratorNewest.Forms
{
    partial class InstalarSatelitti
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtPwdMFP = new TextBox();
            label3 = new Label();
            ipImpressora = new TextBox();
            btnConfiguration = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            ipEmbarcado = new TextBox();
            label1 = new Label();
            keyOpenPlatform = new TextBox();
            logInfo = new RichTextBox();
            modelSelected = new GroupBox();
            safeXerox = new RadioButton();
            safeEpson = new RadioButton();
            safeKyocera = new RadioButton();
            safeRicoh = new RadioButton();
            groupBox1.SuspendLayout();
            modelSelected.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(modelSelected);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPwdMFP);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ipImpressora);
            groupBox1.Controls.Add(btnConfiguration);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(ipEmbarcado);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(keyOpenPlatform);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 284);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Instalar Embarcado SafePrint Epson:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(233, 210);
            label4.Name = "label4";
            label4.Size = new Size(245, 25);
            label4.TabIndex = 8;
            label4.Text = "Senha admin da impressora:";
            label4.Click += label4_Click;
            // 
            // txtPwdMFP
            // 
            txtPwdMFP.Location = new Point(233, 238);
            txtPwdMFP.Name = "txtPwdMFP";
            txtPwdMFP.Size = new Size(260, 27);
            txtPwdMFP.TabIndex = 7;
            txtPwdMFP.TextChanged += txtPwdMFP_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(233, 31);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 6;
            label3.Text = "IP impressora:";
            // 
            // ipImpressora
            // 
            ipImpressora.Location = new Point(233, 59);
            ipImpressora.Name = "ipImpressora";
            ipImpressora.Size = new Size(260, 27);
            ipImpressora.TabIndex = 5;
            ipImpressora.TextChanged += ipImpressora_TextChanged;
            // 
            // btnConfiguration
            // 
            btnConfiguration.Dock = DockStyle.Right;
            btnConfiguration.FlatAppearance.BorderSize = 0;
            btnConfiguration.FlatStyle = FlatStyle.Flat;
            btnConfiguration.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfiguration.ForeColor = Color.FromArgb(255, 255, 250);
            btnConfiguration.IconChar = FontAwesome.Sharp.IconChar.Upload;
            btnConfiguration.IconColor = Color.FromArgb(255, 255, 250);
            btnConfiguration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfiguration.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguration.Location = new Point(499, 23);
            btnConfiguration.Name = "btnConfiguration";
            btnConfiguration.Padding = new Padding(10, 0, 20, 0);
            btnConfiguration.Size = new Size(274, 258);
            btnConfiguration.TabIndex = 4;
            btnConfiguration.Text = "Configurar embarcado";
            btnConfiguration.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguration.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfiguration.UseVisualStyleBackColor = true;
            btnConfiguration.Click += btnConfiguration_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(233, 152);
            label2.Name = "label2";
            label2.Size = new Size(194, 25);
            label2.TabIndex = 3;
            label2.Text = "IP Serviço Embarcado:";
            // 
            // ipEmbarcado
            // 
            ipEmbarcado.Location = new Point(233, 180);
            ipEmbarcado.Name = "ipEmbarcado";
            ipEmbarcado.Size = new Size(260, 27);
            ipEmbarcado.TabIndex = 2;
            ipEmbarcado.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(233, 92);
            label1.Name = "label1";
            label1.Size = new Size(224, 25);
            label1.TabIndex = 1;
            label1.Text = "Key Epson OpenPlatform:";
            // 
            // keyOpenPlatform
            // 
            keyOpenPlatform.Location = new Point(233, 120);
            keyOpenPlatform.Name = "keyOpenPlatform";
            keyOpenPlatform.Size = new Size(260, 27);
            keyOpenPlatform.TabIndex = 0;
            // 
            // logInfo
            // 
            logInfo.Location = new Point(12, 312);
            logInfo.Name = "logInfo";
            logInfo.Size = new Size(776, 264);
            logInfo.TabIndex = 1;
            logInfo.Text = "";
            logInfo.TextChanged += richTextBox1_TextChanged;
            // 
            // modelSelected
            // 
            modelSelected.Controls.Add(safeXerox);
            modelSelected.Controls.Add(safeEpson);
            modelSelected.Controls.Add(safeKyocera);
            modelSelected.Controls.Add(safeRicoh);
            modelSelected.FlatStyle = FlatStyle.Flat;
            modelSelected.ForeColor = Color.White;
            modelSelected.Location = new Point(19, 34);
            modelSelected.Name = "modelSelected";
            modelSelected.Size = new Size(157, 201);
            modelSelected.TabIndex = 9;
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
            // InstalarSatelitti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 49, 56);
            ClientSize = new Size(800, 608);
            Controls.Add(logInfo);
            Controls.Add(groupBox1);
            Name = "InstalarSatelitti";
            Text = "InstalarSatelitti";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            modelSelected.ResumeLayout(false);
            modelSelected.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private TextBox ipEmbarcado;
        private Label label1;
        private TextBox keyOpenPlatform;
        private FontAwesome.Sharp.IconButton btnConfiguration;
        private RichTextBox logInfo;
        private Label label3;
        private TextBox ipImpressora;
        private Label label4;
        private TextBox txtPwdMFP;
        private GroupBox modelSelected;
        private RadioButton safeXerox;
        private RadioButton safeEpson;
        private RadioButton safeKyocera;
        private RadioButton safeRicoh;
    }
}