using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DataTier
{
    public class DatabaseHandler
    {
        SqlConnection connection;
        public DatabaseHandler()
        {
            try
            {
                connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Me\source\repos\J10\DataTier\PhoneBookDatabase.mdf;Integrated Security=True");
                connection.Open();
            }
            catch (Exception e){}
        }
        public DataTable LoadData()
        {
            string loadQuery = "Select Name , Number ,Email ,Address from PhonebookRecords";
            DataTable Phonebook = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(loadQuery, connection);
            dataAdapter.Fill(Phonebook);
            return Phonebook;
        }
        public string StoreData(Row tempRow)
        {
            try
            {
                string storeQuery = "Insert into PhonebookRecords (Name , Number ,Email ,Address) values ('" + tempRow.Name + "','" + tempRow.Number + "','" + tempRow.Email + "','" + tempRow.Address + "')";
                SqlCommand insert = new SqlCommand(storeQuery, connection);
                insert.ExecuteNonQuery();
                return "";
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }
        public SqlDataReader SearchData(string value, byte choice)
        {
            if(choice==1)
            {
                string searchQuery = "Select Number from PhonebookRecords where name = '" + value + "'";
                SqlCommand search = new SqlCommand(searchQuery, connection);
                SqlDataReader reader = search.ExecuteReader();
                return reader;
            }
            else if (choice == 2)
            {
                string searchQuery = "Select Number from PhonebookRecords where email = '" + value + "'";
                SqlCommand search = new SqlCommand(searchQuery, connection);
                SqlDataReader reader = search.ExecuteReader();
                return reader;
            }
            else
            {
                string searchQuery = "Select Number from PhonebookRecords where number = '" + value + "'";
                SqlCommand search = new SqlCommand(searchQuery, connection);
                SqlDataReader reader = search.ExecuteReader();
                return reader;
            }
        }
        public string UpdateData(string value,byte choice,string identifier)
        {

            try
            {
                if (choice == 1)
                {
                    string updateQuery = "Update PhonebookRecords set name = '" + value + "'where Number = '" + identifier + "'";
                    SqlCommand update = new SqlCommand(updateQuery, connection);
                    update.ExecuteReader();
                }
                else if (choice == 2)
                {
                    string updateQuery = "Update PhonebookRecords set number = '" + value + "'where Number = '" + identifier + "'";
                    SqlCommand update = new SqlCommand(updateQuery, connection);
                    update.ExecuteReader();
                }
                else
                {
                    string updateQuery = "Update PhonebookRecords set email = '" + value + "'where Number = '" + identifier + "'";
                    SqlCommand update = new SqlCommand(updateQuery, connection);
                    update.ExecuteReader();
                }
                return "";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        public string DeleteData(string identifier)
        {
            try
            {
                string deleteQuery = "Delete from PhonebookRecords where number = '" + identifier + "'";
                SqlCommand delete = new SqlCommand(deleteQuery, connection);
                delete.ExecuteReader();
                return "";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
