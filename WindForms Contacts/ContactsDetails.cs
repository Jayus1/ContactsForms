using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindForms_Contacts
{
    public partial class ContactsDetails : Form
    {
        public ContactsDetails()
        {
            InitializeComponent();
            _businessLogicLayer=new BusinessLogicLayer();
        }

        private BusinessLogicLayer _businessLogicLayer;


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
         public void SaveContact()
        {
            Contact contact = new Contact();
            contact.FirstName = txtFirstName.Text;
            contact.LastName = txtLastName.Text;
            contact.Phone = txtPhone.Text;
            contact.Address = txtAddress.Text;

            _businessLogicLayer.SaveContact(contact);
        }

        private void ContactsDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
