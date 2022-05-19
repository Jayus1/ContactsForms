using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindForms_Contacts
{
    public class DataAccessLayer
    {
        private SqlConnection conn= new SqlConnection("Data Source=DESKTOP-0SC2BM1;Initial Catalog=Contacts;Integrated Security=True");

        public void InsertContact(Contact contact)
        {
            try
            {
                conn.Open();
                string query = @"INSERT INTO Contacts () VALUES (@FirstName, @LastName, @Phone, @Address)";
                SqlParameter firstName = new SqlParameter();
                firstName.ParameterName = "@FirstName";
                firstName.Value = contact.FirstName;
                firstName.DbType = System.Data.DbType.String;

                SqlParameter lastName = new SqlParameter("@LastName", contact.LastName);
                SqlParameter phone = new SqlParameter("@Phone", contact.Phone);
                SqlParameter address = new SqlParameter("@Address", contact.Address);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(firstName);
                command.Parameters.Add(lastName);
                command.Parameters.Add(phone);
                command.Parameters.Add(address);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

            public List<Contact> GetContacts()
            {
                List<Contact> contacts = new List<Contact>();
                try
                {
                    string query = @"SELECT * FROM Contacts";
                    SqlCommand command= new SqlCommand(query, conn);

                    SqlDataReader reader= command.ExecuteReader();
                    while (reader.Read())
                    {
                       contacts.Add(new Contact
                       {
                           Id=
                           FirstName = reader.GetString(0),
                           LastName = reader.GetString(1),
                           Phone = reader.GetString(2),
                           Address = reader.GetString(3),

                       }
                      )
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
