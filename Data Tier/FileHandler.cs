using System.Collections.Generic;
using System.IO;
namespace DataTier
{
    public class FileHandler
    {
        static bool fileStatus = false;
        List<Row> AllRows = new List<Row>();
        public List<Row> LoadData()
        {
            StreamReader reader = new StreamReader("Phonebook.txt");
            while (!reader.EndOfStream)
            {
                Row temporaryRow = new Row();
                temporaryRow.Serial = reader.ReadLine();
                temporaryRow.Name = reader.ReadLine();
                temporaryRow.Number = reader.ReadLine();
                temporaryRow.Email = reader.ReadLine();
                temporaryRow.Address = reader.ReadLine();
                AllRows.Add(temporaryRow);
            }
            reader.Close();
            return AllRows;
        }
        public void StoreData(Row tempRow)
        {
            if(fileStatus==false)
            {
                StreamWriter temp = new StreamWriter("Phonebook.txt");
                temp.Close();
            }
            StreamWriter writer = new StreamWriter("Phonebook.txt",true);
            writer.WriteLine(tempRow.Serial);
            writer.WriteLine(tempRow.Name);
            writer.WriteLine(tempRow.Number);
            writer.WriteLine(tempRow.Email);
            writer.WriteLine(tempRow.Address);
            writer.Close();
            fileStatus = true;
        }
    }
}
