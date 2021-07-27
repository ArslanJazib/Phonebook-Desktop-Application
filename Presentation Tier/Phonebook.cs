using System;
using System.Windows.Forms;
using LogicTier;
namespace J8
{
    public partial class phone_book : Form
    {
        public DataHandler dataHandler = new DataHandler();
        public int index;
        bool delete_flag=false;
        public int counter = 1;
        public phone_book()
        {
            InitializeComponent();
        }


        private void phone_book_Load(object sender, EventArgs e)
        {
            for (int index=0;index<DataHandler.total;index++)
            {
                string serial=null;
                string name=null;
                string number=null;
                string email=null;
                string address=null;
                dataHandler.LoadDataGird(ref serial, ref name, ref number, ref email, ref address);
                phoneBook.Rows.Add(serial, name, number, email, address);
                counter = int.Parse(serial);
                if(index+1== DataHandler.total)
                {
                    counter ++;
                }
            }

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
                foreach (DataGridViewRow row in phoneBook.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        row.Visible = false;
                    }
                }
                if (search_name.Checked == true)
                {
                    foreach (DataGridViewRow row in phoneBook.Rows)
                    {
                        try
                        {
                            if (row.Cells[1].Value.ToString().Equals(search_tbox.Text))
                            {
                                row.Visible = true;

                                for (int loop = row.Index + 1; loop < phoneBook.RowCount - 1; loop++)
                                {
                                    if (phoneBook.Rows[loop].Cells[1].Value.ToString().Equals(search_tbox.Text))
                                    {
                                        phoneBook.Rows[loop].Visible = true;
                                    }

                                }


                                break;
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                if (search_email.Checked == true)
                {
                    foreach (DataGridViewRow row in phoneBook.Rows)
                    {
                        try
                        {
                            if (row.Cells[3].Value.ToString().Equals(search_tbox.Text))
                            {
                                row.Visible = true;
                                break;
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                if (search_number.Checked == true)
                {
                    foreach (DataGridViewRow row in phoneBook.Rows)
                    {
                        try
                        {
                            if (row.Cells[2].Value.ToString().Equals(search_tbox.Text))
                            {
                                row.Visible = true;
                                break;
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
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
                foreach (DataGridViewRow row in phoneBook.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        row.Visible = false;
                    }
                }
                if (search_name.Checked == true)
                {
                    foreach (DataGridViewRow row in phoneBook.Rows)
                    {
                        try
                        {
                            if (row.Cells[1].Value.ToString().Equals(search_tbox.Text))
                            {
                                index = row.Index;
                                row.Visible = true;
                                input update = new input(this);
                                update.Show();
                                break;
                            }
                        }
                        catch(Exception exception)
                        {
                            MessageBox.Show(exception.Message, "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }

                }
                if (search_email.Checked == true)
                {
                    foreach (DataGridViewRow row in phoneBook.Rows)
                    {
                        try
                        {
                            if (row.Cells[3].Value.ToString().Equals(search_tbox.Text))
                            {
                                row.Visible = true;
                                input update = new input(this);
                                update.Show();
                                break;
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                if (search_number.Checked == true)
                {
                    foreach (DataGridViewRow row in phoneBook.Rows)
                    {
                        try
                        {
                            if (row.Cells[2].Value.ToString().Equals(search_tbox.Text))
                            {
                                row.Visible = true;
                                input update = new input(this);
                                update.Show();
                                break;
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Textbox is empty please input", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(search_tbox.Text.Length>0)
            {
                foreach (DataGridViewRow row in phoneBook.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        row.Visible = false;
                    }
                }
                if (search_name.Checked == true)
                {
                    foreach (DataGridViewRow row in phoneBook.Rows)
                    {
                        try
                        {
                            if (row.Cells[1].Value.ToString().Equals(search_tbox.Text))
                            {
                                row.Visible = true;
                                for (int loop = row.Index + 1; loop < phoneBook.RowCount - 1; loop++)
                                {
                                    if (phoneBook.Rows[loop].Cells[1].Value.ToString().Equals(search_tbox.Text))
                                    {
                                        phoneBook.Rows[loop].Visible = true;
                                    }

                                }
                                delete_flag = true;
                                MessageBox.Show("Double click on any cell of the record you want to delete", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                }
                if (search_email.Checked == true)
                {
                    foreach (DataGridViewRow row in phoneBook.Rows)
                    {
                        try
                        {
                            if (row.Cells[3].Value.ToString().Equals(search_tbox.Text))
                            {
                                row.Visible = true;
                                delete_flag = true;
                                MessageBox.Show("Double click on any cell of the record you want to delete", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                if (search_number.Checked == true)
                {
                    foreach (DataGridViewRow row in phoneBook.Rows)
                    {
                        try
                        {
                            if (row.Cells[2].Value.ToString().Equals(search_tbox.Text))
                            {
                                row.Visible = true;
                                delete_flag = true;
                                MessageBox.Show("Double click on any cell of the record you want to delete", "Choose", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
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
                phoneBook.Rows.RemoveAt(e.RowIndex);
                delete_flag = false;
            }
        }

        private void phone_book_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (DataGridViewRow row in phoneBook.Rows)
            {
                if (!row.IsNewRow)
                {
                    try
                    {
                        dataHandler.StoreDataGird
                        (row.Cells[0].Value.ToString(),
                        row.Cells[1].Value.ToString(),
                        row.Cells[2].Value.ToString(),
                        row.Cells[3].Value.ToString(),
                        row.Cells[4].Value.ToString());
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }

        }
    }
}
