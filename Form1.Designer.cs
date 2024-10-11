namespace ConfiguratorNewest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenu = new Panel();
            panelInstalarEmbarcadoSubMenu = new Panel();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panelConfigurationSubmenu = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnConfiguration = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            panelTitleBar = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panelInstalarEmbarcadoSubMenu.SuspendLayout();
            panelConfigurationSubmenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 49, 56);
            panelMenu.Controls.Add(panelInstalarEmbarcadoSubMenu);
            panelMenu.Controls.Add(iconButton2);
            panelMenu.Controls.Add(panelConfigurationSubmenu);
            panelMenu.Controls.Add(btnConfiguration);
            panelMenu.Controls.Add(iconButton1);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(274, 664);
            panelMenu.TabIndex = 0;
            // 
            // panelInstalarEmbarcadoSubMenu
            // 
            panelInstalarEmbarcadoSubMenu.BackColor = Color.FromArgb(81, 80, 82);
            panelInstalarEmbarcadoSubMenu.Controls.Add(button4);
            panelInstalarEmbarcadoSubMenu.Controls.Add(button5);
            panelInstalarEmbarcadoSubMenu.Controls.Add(button6);
            panelInstalarEmbarcadoSubMenu.Dock = DockStyle.Top;
            panelInstalarEmbarcadoSubMenu.Location = new Point(0, 469);
            panelInstalarEmbarcadoSubMenu.Name = "panelInstalarEmbarcadoSubMenu";
            panelInstalarEmbarcadoSubMenu.Size = new Size(274, 149);
            panelInstalarEmbarcadoSubMenu.TabIndex = 5;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(255, 255, 250);
            button4.Location = new Point(0, 98);
            button4.Name = "button4";
            button4.Padding = new Padding(60, 0, 0, 0);
            button4.Size = new Size(274, 49);
            button4.TabIndex = 2;
            button4.Text = "SmartShare";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(255, 255, 250);
            button5.Location = new Point(0, 49);
            button5.Name = "button5";
            button5.Padding = new Padding(60, 0, 0, 0);
            button5.Size = new Size(274, 49);
            button5.TabIndex = 1;
            button5.Text = "SafePrint";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button6.ForeColor = Color.FromArgb(255, 255, 250);
            button6.Location = new Point(0, 0);
            button6.Name = "button6";
            button6.Padding = new Padding(60, 0, 0, 0);
            button6.Size = new Size(274, 49);
            button6.TabIndex = 0;
            button6.Text = "Satelitti/Rportal";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.ForeColor = Color.FromArgb(255, 255, 250);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Download;
            iconButton2.IconColor = Color.FromArgb(255, 255, 250);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 409);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(10, 0, 20, 0);
            iconButton2.Size = new Size(274, 60);
            iconButton2.TabIndex = 4;
            iconButton2.Text = "Instalar embarcado";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click_1;
            // 
            // panelConfigurationSubmenu
            // 
            panelConfigurationSubmenu.BackColor = Color.FromArgb(81, 80, 82);
            panelConfigurationSubmenu.Controls.Add(button3);
            panelConfigurationSubmenu.Controls.Add(button2);
            panelConfigurationSubmenu.Controls.Add(button1);
            panelConfigurationSubmenu.Dock = DockStyle.Top;
            panelConfigurationSubmenu.Location = new Point(0, 260);
            panelConfigurationSubmenu.Name = "panelConfigurationSubmenu";
            panelConfigurationSubmenu.Size = new Size(274, 149);
            panelConfigurationSubmenu.TabIndex = 3;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(255, 255, 250);
            button3.Location = new Point(0, 98);
            button3.Name = "button3";
            button3.Padding = new Padding(60, 0, 0, 0);
            button3.Size = new Size(274, 49);
            button3.TabIndex = 2;
            button3.Text = "SmartShare";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(255, 255, 250);
            button2.Location = new Point(0, 49);
            button2.Name = "button2";
            button2.Padding = new Padding(60, 0, 0, 0);
            button2.Size = new Size(274, 49);
            button2.TabIndex = 1;
            button2.Text = "SafePrint";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(255, 255, 250);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Padding = new Padding(60, 0, 0, 0);
            button1.Size = new Size(274, 49);
            button1.TabIndex = 0;
            button1.Text = "Satelitti/Rportal";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnConfiguration
            // 
            btnConfiguration.Dock = DockStyle.Top;
            btnConfiguration.FlatAppearance.BorderSize = 0;
            btnConfiguration.FlatStyle = FlatStyle.Flat;
            btnConfiguration.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfiguration.ForeColor = Color.FromArgb(255, 255, 250);
            btnConfiguration.IconChar = FontAwesome.Sharp.IconChar.Cog;
            btnConfiguration.IconColor = Color.FromArgb(255, 255, 250);
            btnConfiguration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfiguration.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguration.Location = new Point(0, 200);
            btnConfiguration.Name = "btnConfiguration";
            btnConfiguration.Padding = new Padding(10, 0, 20, 0);
            btnConfiguration.Size = new Size(274, 60);
            btnConfiguration.TabIndex = 2;
            btnConfiguration.Text = "Configurar embarcado";
            btnConfiguration.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguration.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfiguration.UseVisualStyleBackColor = true;
            btnConfiguration.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.FromArgb(255, 255, 250);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.House;
            iconButton1.IconColor = Color.FromArgb(255, 255, 250);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 140);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 20, 0);
            iconButton1.Size = new Size(274, 60);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "Home";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(274, 140);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(36, 28);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(195, 72);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 1, 3);
            panelTitleBar.Controls.Add(nightControlBox1);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(274, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(790, 75);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(651, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 2;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleChildForm.ForeColor = Color.FromArgb(255, 255, 250);
            lblTitleChildForm.Location = new Point(60, 28);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(50, 20);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(0, 1, 3);
            iconCurrentChildForm.ForeColor = Color.FromArgb(255, 255, 250);
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = Color.FromArgb(255, 255, 250);
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 40;
            iconCurrentChildForm.Location = new Point(18, 18);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(40, 40);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(0, 1, 3);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(274, 75);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(790, 9);
            panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(51, 49, 56);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(274, 84);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(790, 580);
            panelDesktop.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1064, 664);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "Form1";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelInstalarEmbarcadoSubMenu.ResumeLayout(false);
            panelConfigurationSubmenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panelLogo;
        private PictureBox btnHome;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Panel panelConfigurationSubmenu;
        private Button button3;
        private Button button2;
        private Button button1;
        private FontAwesome.Sharp.IconButton btnConfiguration;
        private Panel panelInstalarEmbarcadoSubMenu;
        private Button button4;
        private Button button5;
        private Button button6;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}
