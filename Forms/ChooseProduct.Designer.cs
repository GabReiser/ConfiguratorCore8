namespace ConfiguratorNewest.Forms
{
    partial class ChooseProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseProduct));
            choosePanel = new Panel();
            panel2 = new Panel();
            btnShare = new PictureBox();
            panel3 = new Panel();
            btnSafePrint = new PictureBox();
            panelLogo = new Panel();
            btnSatelitti = new PictureBox();
            choosePanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnShare).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSafePrint).BeginInit();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSatelitti).BeginInit();
            SuspendLayout();
            // 
            // choosePanel
            // 
            choosePanel.Controls.Add(panel2);
            choosePanel.Controls.Add(panel3);
            choosePanel.Controls.Add(panelLogo);
            choosePanel.Location = new Point(-1, 0);
            choosePanel.Name = "choosePanel";
            choosePanel.Size = new Size(803, 453);
            choosePanel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnShare);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 280);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 140);
            panel2.TabIndex = 6;
            // 
            // btnShare
            // 
            btnShare.Image = (Image)resources.GetObject("btnShare.Image");
            btnShare.Location = new Point(268, 22);
            btnShare.Name = "btnShare";
            btnShare.Size = new Size(260, 100);
            btnShare.SizeMode = PictureBoxSizeMode.Zoom;
            btnShare.TabIndex = 0;
            btnShare.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSafePrint);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(803, 140);
            panel3.TabIndex = 5;
            // 
            // btnSafePrint
            // 
            btnSafePrint.Image = (Image)resources.GetObject("btnSafePrint.Image");
            btnSafePrint.Location = new Point(268, 22);
            btnSafePrint.Name = "btnSafePrint";
            btnSafePrint.Size = new Size(260, 100);
            btnSafePrint.SizeMode = PictureBoxSizeMode.Zoom;
            btnSafePrint.TabIndex = 0;
            btnSafePrint.TabStop = false;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnSatelitti);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(803, 140);
            panelLogo.TabIndex = 4;
            // 
            // btnSatelitti
            // 
            btnSatelitti.Image = (Image)resources.GetObject("btnSatelitti.Image");
            btnSatelitti.Location = new Point(268, 22);
            btnSatelitti.Name = "btnSatelitti";
            btnSatelitti.Size = new Size(260, 100);
            btnSatelitti.SizeMode = PictureBoxSizeMode.Zoom;
            btnSatelitti.TabIndex = 0;
            btnSatelitti.TabStop = false;
            btnSatelitti.Click += btnSatelitti_Click;
            // 
            // ChooseProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 7, 53);
            ClientSize = new Size(800, 450);
            Controls.Add(choosePanel);
            Name = "ChooseProduct";
            Text = "ChooseProduct";
            choosePanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnShare).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnSafePrint).EndInit();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnSatelitti).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel choosePanel;
        private Panel panel2;
        private PictureBox btnShare;
        private Panel panel3;
        private PictureBox btnSafePrint;
        private Panel panelLogo;
        private PictureBox btnSatelitti;
    }
}