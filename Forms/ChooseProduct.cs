using FontAwesome.Sharp;

namespace ConfiguratorNewest.Forms
{
    public partial class ChooseProduct : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel chooseProductPanel;
        private Form currentChildForm;
        public ChooseProduct()
        {
            InitializeComponent();
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(78, 20, 140);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                chooseProductPanel.BackColor = color;
                chooseProductPanel.Location = new Point(0, currentBtn.Location.Y);
                chooseProductPanel.Visible = true;
                chooseProductPanel.BringToFront();
                //Icon Current Child Form
                //iconCurrentChildForm.IconChar = currentBtn.IconChar;
                //iconCurrentChildForm.IconColor = color;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            // Fechar o formulário filho atual, se houver
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            // Atribuir o novo formulário filho
            currentChildForm = childForm;

            // Configurar o novo formulário filho
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Adicionar o novo formulário filho ao painel
            choosePanel.Controls.Add(childForm);
            choosePanel.Tag = childForm;

            // Trazer o novo formulário filho para a frente e mostrar
            childForm.BringToFront();
            childForm.Show();

        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(44, 7, 53);
                currentBtn.ForeColor = Color.FromArgb(133, 138, 227);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(133, 138, 227);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnSafePrint_Click(object sender, EventArgs e)
        {

        }

        private void btnSmartShare_Click(object sender, EventArgs e)
        {

        }

        private void btnSatelitti_Click(object sender, EventArgs e)
        {
            // Fechar o formulário atual
            this.Close();

            // Abrir o novo formulário
            Form newForm = new InstalacaoDeEmbarcado();
            newForm.Show();
        }
    }
}
