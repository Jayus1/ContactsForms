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
            new ContactsDetails().ShowDialog(this);
        }

        public void ShowContats()
        {
            List<Contact> contacts = _businessLogicLayer.GetContacts();
            gridContacts.DataSource = contacts;
        }

        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)gridContacts.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Edit")
            {
                ContactsDetails contactDetails= new ContactsDetails()
            }
        }
    }
}