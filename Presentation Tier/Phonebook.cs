using System;
using System.Windows.Forms;
using LogicTier;
using System.Data.SqlClient;
using System.Collections.Generic;
namespace J10
{
    public partial class phone_book : Form
    {
        public DataHandler dataHandler = new DataHandler();
        public int index;
        bool delete_flag=false;
        bool update_flag = false;

        public phone_book()
        {
            InitializeComponent();
            
        }

        private void phone_book_Load(object sender, EventArgs e)
        {
            phoneBook.DataSource=dataHandler.LoadDataGird();

        }
       
        private void addicon_Click(object sender, EventArgs e)
        {
            Add_Contact add = new Add_Contact(this);
            add.Show();
            this.Hide();
        }

        private void search_name_CheckedChanged(object sender, EventArgs e)
        {
            search_bar.Enabled = true;
        }

        private void search_number_CheckedChanged(object sender, EventArgs e)
        {
            search_bar.Enabled = true;
        }

        private void search_email_CheckedChanged(object sender, EventArgs e)
        {
            search_bar.Enabled = true;
        }

        private void search_icon_Click(object sender, EventArgs e)
        {
            if(search_tbox.Text.Length>0)
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[phoneBook.DataSource];
                foreach (DataGridViewRow row in phoneBook.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        cm.SuspendBinding();
                        row.Visible = false;
                    }
                }
                if (search_name.Checked == true)
                {
                    SearchComparsion(search_tbox.Text, 1);
                }
                if (search_email.Checked == true)
                {
                    SearchComparsion(search_tbox.Text, 2);
                }
                if (search_number.Checked == true)
                {
                    SearchComparsion(search_tbox.Text, 3);

                }
                cm.ResumeBinding();
            }
            else
            {
                MessageBox.Show("Textbox is empty please input", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if(search_tbox.Text.Length>0)
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[phoneBook.DataSource];
                foreach (DataGridViewRow row in phoneBook.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        cm.SuspendBinding();
                        row.Visible = false;
                    }
                }
                if (search_name.Checked == true)
                {
                    UpdateComparison(search_tbox.Text, 1);
                }
                if (search_email.Checked == true)
                {
                    UpdateComparison(search_tbox.Text, 2);

                }
                if (search_number.Checked == true)
                {
                    UpdateComparison(search_tbox.Text, 3);

                }
                cm.ResumeBinding();

            }
            else
            {
                MessageBox.Show("Textbox is empty please input", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {

            if (search_tbox.Text.Length > 0)
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[phoneBook.DataSource];
                foreach (DataGridViewRow row in phoneBook.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        cm.SuspendBinding();
                        row.Visible = false;
                    }
                }
                if (search_name.Checked == true)
                {
                    DeleteComparison(search_tbox.Text, 1);
                }
                if (search_email.Checked == true)
                {
                    DeleteComparison(search_tbox.Text, 2);

                }
                if (search_number.Checked == true)
                {
                    DeleteComparison(search_tbox.Text, 3);

                }
                cm.ResumeBinding();

            }
            else
            {
                MessageBox.Show("Textbox is empty please input", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void phoneBook_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(delete_flag==true)
            {
                index = e.RowIndex;
                string check=dataHandler.Delete(phoneBook.Rows[index].Cells[1].Value.ToString());
                if(check=="")
                {
                    phoneBook.DataSource = dataHandler.LoadDataGird();
                    MessageBox.Show("Record Deleted", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Wrong input", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                delete_flag = false;
            }
            if(update_flag==true)
            {
                index = e.RowIndex;
                input update = new input(this);
                update.Show();
                update_flag = false;
            }
        }

        private bool SearchComparsion(string input,byte choice)
        {
            SqlDataReader reader = dataHandler.Search(input, choice);
            var values = new List<string>();
            int counter = 0;
            while (reader.Read())
            {
                values.Add(reader.GetString(0));
            }
            foreach (DataGridViewRow row in phoneBook.Rows)
            {
                if (counter < values.Count && !row.IsNewRow)
                {
                    try
                    {
                        foreach (var number in values)
                        {
                            if (row.Cells[1].Value.ToString().Equals(number))
                            {
                                row.Visible = true;
                                counter++;
                                break;
                            }
                        }
                        
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }}
            return true;}

        private void UpdateComparison(string input,byte choice)
        {
            update_flag=SearchComparsion(input, choice);
            MessageBox.Show("Double click on any cell of the record you want to update", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteComparison(string input, byte choice)
        {
            delete_flag = SearchComparsion(input, choice);
            MessageBox.Show("Double click on any cell of the record you want to delete", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
