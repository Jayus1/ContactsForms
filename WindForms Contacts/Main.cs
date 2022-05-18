namespace WindForms_Contacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowAdd();
        }

        #region Metodos Privados

        private void ShowAdd()
        {
            new ContactsDetails().ShowDialog();
        }

        #endregion
    }
}