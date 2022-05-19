namespace WindForms_Contacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _businessLogicLayer= new BusinessLogicLayer();
        }
        private BusinessLogicLayer _businessLogicLayer;

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowContats();
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

        private void ShowContats()
        {
            List<Contact> contacts = _businessLogicLayer
        }

        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}