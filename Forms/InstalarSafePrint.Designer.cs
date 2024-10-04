namespace ConfiguratorNewest.Forms
{
    partial class InstalarSafePrint
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
            btnInstallLote = new Button();
            label5 = new Label();
            txtWsDest = new TextBox();
            progressBar1 = new ProgressBar();
            btnUninstall = new Button();
            btnInstall = new Button();
            checkBoxSsl = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            label2 = new Label();
            txtIpMFP = new TextBox();
            label1 = new Label();
            txtLog = new RichTextBox();
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
            groupBox1.Controls.Add(btnInstallLote);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtWsDest);
            groupBox1.Controls.Add(progressBar1);
            groupBox1.Controls.Add(btnUninstall);
            groupBox1.Controls.Add(btnInstall);
            groupBox1.Controls.Add(checkBoxSsl);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUser);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtIpMFP);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtLog);
            groupBox1.Controls.Add(modelSelected);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(12, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1098, 627);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Instalador MFP SafePrint";
            // 
            // btnInstallLote
            // 
            btnInstallLote.BackColor = Color.FromArgb(255, 49, 46);
            btnInstallLote.FlatStyle = FlatStyle.Flat;
            btnInstallLote.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInstallLote.ForeColor = Color.FromArgb(255, 209, 208);
            btnInstallLote.Location = new Point(799, 140);
            btnInstallLote.Name = "btnInstallLote";
            btnInstallLote.Size = new Size(198, 39);
            btnInstallLote.TabIndex = 17;
            btnInstallLote.Text = "Instalar";
            btnInstallLote.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(212, 55);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 16;
            label5.Text = "URL do SafePrint:";
            // 
            // txtWsDest
            // 
            txtWsDest.Cursor = Cursors.Hand;
            txtWsDest.Location = new Point(212, 80);
            txtWsDest.Name = "txtWsDest";
            txtWsDest.Size = new Size(543, 27);
            txtWsDest.TabIndex = 15;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 581);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1071, 33);
            progressBar1.TabIndex = 14;
            // 
            // btnUninstall
            // 
            btnUninstall.FlatStyle = FlatStyle.Flat;
            btnUninstall.Location = new Point(471, 248);
            btnUninstall.Name = "btnUninstall";
            btnUninstall.Size = new Size(139, 39);
            btnUninstall.TabIndex = 13;
            btnUninstall.Text = "Desinstalar";
            btnUninstall.UseVisualStyleBackColor = true;
            // 
            // btnInstall
            // 
            btnInstall.BackColor = Color.FromArgb(255, 49, 46);
            btnInstall.FlatStyle = FlatStyle.Flat;
            btnInstall.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInstall.ForeColor = Color.FromArgb(255, 209, 208);
            btnInstall.Location = new Point(616, 248);
            btnInstall.Name = "btnInstall";
            btnInstall.Size = new Size(139, 39);
            btnInstall.TabIndex = 12;
            btnInstall.Text = "Instalar";
            btnInstall.UseVisualStyleBackColor = false;
            btnInstall.Click += button2_Click;
            // 
            // checkBoxSsl
            // 
            checkBoxSsl.AutoSize = true;
            checkBoxSsl.Location = new Point(673, 202);
            checkBoxSsl.Name = "checkBoxSsl";
            checkBoxSsl.Size = new Size(82, 24);
            checkBoxSsl.TabIndex = 10;
            checkBoxSsl.Text = "Use SSL";
            checkBoxSsl.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(451, 180);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 9;
            label4.Text = "Senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 180);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 8;
            label3.Text = "Usuário:";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(451, 203);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(206, 20);
            txtPassword.TabIndex = 7;
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Location = new Point(212, 203);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(206, 20);
            txtUser.TabIndex = 6;
            txtUser.Text = "admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 115);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 5;
            label2.Text = "IP da MFP:";
            // 
            // txtIpMFP
            // 
            txtIpMFP.Cursor = Cursors.Hand;
            txtIpMFP.Location = new Point(212, 140);
            txtIpMFP.Name = "txtIpMFP";
            txtIpMFP.Size = new Size(543, 27);
            txtIpMFP.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 289);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 3;
            label1.Text = "Log de Eventos";
            // 
            // txtLog
            // 
            txtLog.Location = new Point(12, 312);
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(1071, 259);
            txtLog.TabIndex = 2;
            txtLog.Text = "";
            // 
            // modelSelected
            // 
            modelSelected.Controls.Add(safeXerox);
            modelSelected.Controls.Add(safeEpson);
            modelSelected.Controls.Add(safeKyocera);
            modelSelected.Controls.Add(safeRicoh);
            modelSelected.FlatStyle = FlatStyle.Flat;
            modelSelected.ForeColor = Color.White;
            modelSelected.Location = new Point(12, 55);
            modelSelected.Name = "modelSelected";
            modelSelected.Size = new Size(157, 201);
            modelSelected.TabIndex = 1;
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
            // InstalarSafePrint
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(51, 49, 56);
            ClientSize = new Size(1122, 649);
            Controls.Add(groupBox1);
            Name = "InstalarSafePrint";
            Text = "InstalarSafePrint";
            Load += InstalarSafePrint_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            modelSelected.ResumeLayout(false);
            modelSelected.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox modelSelected;
        private RadioButton safeXerox;
        private RadioButton safeEpson;
        private RadioButton safeKyocera;
        private RadioButton safeRicoh;
        private Label label1;
        private RichTextBox txtLog;
        private TextBox txtIpMFP;
        private Label label2;
        private TextBox txtUser;
        private Button btnUninstall;
        private Button btnInstall;
        private CheckBox checkBoxSsl;
        private Label label4;
        private Label label3;
        private TextBox txtPassword;
        private ProgressBar progressBar1;
        private Label label5;
        private TextBox txtWsDest;
        private Button btnInstallLote;
    }
}