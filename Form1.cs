using ConfiguratorNewest.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace ConfiguratorNewest
{
    public partial class Form1 : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelConfigurationSubmenu.Visible = false;
            panelInstalarEmbarcadoSubMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelConfigurationSubmenu.Visible == true)
                panelConfigurationSubmenu.Visible = false;
            if (panelInstalarEmbarcadoSubMenu.Visible == true)
                panelInstalarEmbarcadoSubMenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(255, 209, 208);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(51, 49, 56);
                currentBtn.ForeColor = Color.FromArgb(255, 255, 250);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(255, 255, 250);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Reset();
            ActivateButton(sender, Color.FromArgb(255, 49, 46));
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Reset();
            showSubMenu(panelConfigurationSubmenu);
            ActivateButton(sender, Color.FromArgb(255, 49, 46));
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 49, 46));
            //OpenChildForm(new ChooseProduct());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(255, 255, 250);
            lblTitleChildForm.Text = "Home";
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm(new ConfigurarSatelitti());
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelInstalarEmbarcadoSubMenu);
            ActivateButton(sender, Color.FromArgb(255, 49, 46));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm(new ConfigurarSafePrint());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm(new ConfigurarShare());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm(new InstalarSafePrint());
        }
    }
}
