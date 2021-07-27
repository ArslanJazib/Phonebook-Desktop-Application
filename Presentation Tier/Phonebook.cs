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
        public static bool search_name = false;
        public static bool search_number = false;
        public static bool search_email = false;
        public phone_book()
        {
            InitializeComponent();
            
        }

        private void phone_book_Load(object sender, EventArgs e)
        {
            phoneBook.DataSource=dataHandler.LoadDataGird();

        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addicon_Click(object sender, EventArgs e)
        {
            Add_Contact add = new Add_Contact(this);
            add.Show();
            this.Hide();
        }

        private void search_name_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void search_number_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void search_email_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void search_icon_Click(object sender, EventArgs e)
        {
           
        }

        private void update_Click(object sender, EventArgs e)
        {
            
        }

        private void delete_Click(object sender, EventArgs e)
        {

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

        private void phone_book_FormClosing(object sender, FormClosingEventArgs e)
        {

            
        }

        private void phone_book_Shown(object sender, EventArgs e)
        {

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

                }

            }
            return true;
        }

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

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_tbox.Enabled = true;
            search_name = true;
            search_number = false;
            search_email = false;

        }

        private void numberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_tbox.Enabled = true;
            search_number = true;
            search_name = false;
            search_email = false;

        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_tbox.Enabled = true;
            search_email = true;
            search_number = false;
            search_name = false;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Add_Contact add = new Add_Contact(this);
            add.Show();
            this.Hide();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (search_name || search_number || search_email == true)
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
                    if (search_name == true)
                    {
                        UpdateComparison(search_tbox.Text, 1);
                    }
                    if (search_email == true)
                    {
                        UpdateComparison(search_tbox.Text, 2);

                    }
                    if (search_number == true)
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
            else
            {
                MessageBox.Show("Choose from options first", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (search_name || search_number || search_email == true)
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
                    if (search_name == true)
                    {
                        SearchComparsion(search_tbox.Text, 1);
                    }
                    if (search_email == true)
                    {
                        SearchComparsion(search_tbox.Text, 2);
                    }
                    if (search_number == true)
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
            else
            {
                MessageBox.Show("Choose from options first", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (search_name || search_number || search_email == true)
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
                    if (search_name == true)
                    {
                        DeleteComparison(search_tbox.Text, 1);
                    }
                    if (search_email == true)
                    {
                        DeleteComparison(search_tbox.Text, 2);

                    }
                    if (search_number == true)
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
            else
            {
                MessageBox.Show("Choose from options first", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void operationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (search_name || search_number || search_email == true)
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
                    if (search_name == true)
                    {
                        SearchComparsion(search_tbox.Text, 1);
                    }
                    if (search_email == true)
                    {
                        SearchComparsion(search_tbox.Text, 2);
                    }
                    if (search_number == true)
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
            else
            {
                MessageBox.Show("Choose from options first", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            if (search_name || search_number || search_email == true)
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
                    if (search_name == true)
                    {
                        UpdateComparison(search_tbox.Text, 1);
                    }
                    if (search_email == true)
                    {
                        UpdateComparison(search_tbox.Text, 2);

                    }
                    if (search_number == true)
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
            else
            {
                MessageBox.Show("Choose from options first", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (search_name || search_number || search_email == true)
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
                    if (search_name == true)
                    {
                        DeleteComparison(search_tbox.Text, 1);
                    }
                    if (search_email == true)
                    {
                        DeleteComparison(search_tbox.Text, 2);

                    }
                    if (search_number == true)
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
            else
            {
                MessageBox.Show("Choose from options first", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Add_Contact add = new Add_Contact(this);
            add.Show();
            this.Hide();
        }

        private void search_tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = optionsToolStripMenuItem.Text;
        }

        private void nameToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = nameToolStripMenuItem.Text;
        }

        private void numberToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = numberToolStripMenuItem.Text;
        }

        private void emailToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = emailToolStripMenuItem.Text;
        }

        private void operationsToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = operationsToolStripMenuItem.Text;
        }

        private void addToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = addToolStripMenuItem.Text;
        }

        private void updateToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = updateToolStripMenuItem.Text;
        }

        private void searchToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = searchToolStripMenuItem.Text;
        }

        private void deleteToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = deleteToolStripMenuItem.Text;
        }

        private void toolStripButton1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Search button";
        }

        private void toolStripButton2_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Update button";
        }

        private void toolStripButton3_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Delete button";
        }

        private void toolStripButton4_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Add button";
        }

        private void search_tbox_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Search bar";
        }

        private void phoneBook_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Phonebook";

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void refreashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            phoneBook.DataSource = dataHandler.LoadDataGird();

        }
    }
}
