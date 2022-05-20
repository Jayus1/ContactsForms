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

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowAdd();
        }

        #region Metodos Privados

        private void ShowAdd()
        {
            new ContactsDetails().ShowDialog(this);
        }

        public void ShowContats(string searchText= null)
        {
            List<Contact> contacts = _businessLogicLayer.GetContacts(searchText);
            dataGridContacts.DataSource = contacts;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowContats();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridContacts.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Edit")
            {
                ContactsDetails contactsDetails = new ContactsDetails();
                contactsDetails.LoadContact(new Contact
                {
                    Id = int.Parse(dataGridContacts.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    FirstName = dataGridContacts.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    LastName = dataGridContacts.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Phone = dataGridContacts.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Address = dataGridContacts.Rows[e.RowIndex].Cells[4].Value.ToString(),
                });
                contactsDetails.ShowDialog(this);
            }
            else if (cell.Value.ToString() == "Delete")
            {
                DeleteContacts(int.Parse(dataGridContacts.Rows[e.RowIndex].Cells[0].Value.ToString()));
                ShowContats();
            }
        }

        private void DeleteContacts(int id)
        {
            _businessLogicLayer.DeleteContacts(id);
        }


        #endregion
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowContats(txtSearch.Text);
            txtSearch.Text = String.Empty;
        }




        private void dataGridContacts_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}