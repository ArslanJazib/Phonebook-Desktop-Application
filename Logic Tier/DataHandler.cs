using System.Collections.Generic;
using DataTier;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
namespace LogicTier
{
    public class DataHandler
    {
        static DataTable temporaryTable = new DataTable();
        public DataHandler()
        {

        }
        public byte InputValidation(string name,string number, string email)
        {
            string name_pattern = @"(^[A-Za-z ]+$)";
            string number_pattern = @"(^\d{4}-\d{7}$)";
            string email_pattern = @"(^[a-z0-9._]+@[a-z]+.\w{3}$)";
            Match checkName = Regex.Match(name, name_pattern);
            Match checkNumber= Regex.Match(number, number_pattern);
            Match checkMail= Regex.Match(email, email_pattern);
            if(checkName.Success && checkNumber.Success && checkMail.Success)
            {
                return 1;
            }
            else if(checkName.Success!=true && checkNumber.Success == true && checkMail.Success==true)
            {
                return 2;
            }
            else if (checkName.Success == true && checkNumber.Success != true && checkMail.Success == true)
            {
                return 3;
            }
            else if (checkName.Success == true && checkNumber.Success == true && checkMail.Success != true)
            {
                return 4;
            }
            else
            {
                return 5;
            }
        }
        public byte InputValidation(string input,byte choice)
        {
            string name_pattern = @"(^[A-Za-z ]+$)";
            string number_pattern = @"(^\d{4}-\d{7}$)";
            string email_pattern = @"(^[a-z0-9._]+@[a-z]+.\w{3}$)";
            if(choice==1)
            {
                Match checkName = Regex.Match(input, name_pattern);
                if(checkName.Success)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else if(choice==2)
            {
                Match checkNumber = Regex.Match(input, number_pattern);
                if (checkNumber.Success)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                Match checkMail = Regex.Match(input, email_pattern);
                if (checkMail.Success)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            
        }
        public DataTable LoadDataGird()
        {
            DatabaseHandler dataHandler = new DatabaseHandler();
            temporaryTable = dataHandler.LoadData();
            return temporaryTable;
        }
        public string StoreDataGird(string name,string number,string email,string address)
        {
            string check;
            DatabaseHandler databaseHandler = new DatabaseHandler();
            Row tempRow = new Row();
            tempRow.Name=name;
            tempRow.Number=number;
            tempRow.Email=email;
            tempRow.Address=address;
            check=databaseHandler.StoreData(tempRow);
            return check;
        }
        public SqlDataReader Search(string value, byte choice)
        {
            DatabaseHandler dataHandler = new DatabaseHandler();
            return dataHandler.SearchData(value,choice);
        }
        public string Update(string value , byte choice,string identifier)
        {

            DatabaseHandler dataHandler = new DatabaseHandler();
            return dataHandler.UpdateData(value, choice, identifier);
            
        }
        public string Delete(string identifier)
        {

            DatabaseHandler dataHandler = new DatabaseHandler();
            return dataHandler.DeleteData(identifier);

        }
    }
}
