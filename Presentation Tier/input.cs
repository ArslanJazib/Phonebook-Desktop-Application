using System;
using System.Drawing;
using System.Windows.Forms;
using LogicTier;
namespace J10
{
    public partial class input : Form
    {
        phone_book phonebook_ref;

        public input(phone_book phonebook)
        {
            InitializeComponent();
            this.phonebook_ref = phonebook;
            name_tbox.GotFocus += OnNameFocus;
            name_tbox.LostFocus += OnNameDefocus;
            number_tbox.GotFocus += OnNumFocus;
            number_tbox.LostFocus += OnNumDefocus;
            mail_tbox.GotFocus += OnMailFocus;
            mail_tbox.LostFocus += OnMailDefocus;
            address_tbox.GotFocus += OnAddrFocus;
            address_tbox.LostFocus += OnAddrDefocus;
            name_tbox.Enabled = false;
            number_tbox.Enabled = false;
            mail_tbox.Enabled = false;

        }

        private void input_Load(object sender, EventArgs e)
        {
            if(phone_book.search_name==true)
            {
                name_tbox.Enabled = true;
            }
            else if(phone_book.search_number == true)
            {
                number_tbox.Enabled = true;
            }
            else if (phone_book.search_email == true)
            {
                mail_tbox.Enabled = true;
            }
        }
        private void OnNameFocus(object sender, EventArgs e)
        {
            name_tbox.Clear();
            name_tbox.ForeColor = Color.Black;
        }

        private void OnNameDefocus(object sender, EventArgs e)
        {
            if (name_tbox.Text.Length == 0)
            {
                name_tbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
                name_tbox.Text = "Enter Name";
            }
        }

        private void OnNumFocus(object sender, EventArgs e)
        {
            number_tbox.Clear();
            number_tbox.ForeColor = Color.Black;
        }

        private void OnNumDefocus(object sender, EventArgs e)
        {
            if (number_tbox.Text.Length == 0)
            {
                number_tbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
                number_tbox.Text = "Enter Number";
            }

        }

        private void OnMailFocus(object sender, EventArgs e)
        {
            mail_tbox.Clear();
            mail_tbox.ForeColor = Color.Black;
        }

        private void OnMailDefocus(object sender, EventArgs e)
        {
            if (mail_tbox.Text.Length == 0)
            {
                mail_tbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
                mail_tbox.Text = "Enter Email";
            }

        }

        private void OnAddrFocus(object sender, EventArgs e)
        {
            address_tbox.Clear();
            address_tbox.ForeColor = Color.Black;
        }

        private void OnAddrDefocus(object sender, EventArgs e)
        {
            if (address_tbox.Text.Length == 0)
            {
                address_tbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
                address_tbox.Text = "Enter Address";
            }

        }
        private void phonebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            phonebook_ref.Show();
            this.Hide();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            DataHandler dataHandler = new DataHandler();
            if (phone_book.search_name==true)
            {
                if(dataHandler.InputValidation(name_tbox.Text, 1)==1)
                {
                    string check=phonebook_ref.dataHandler.Update(name_tbox.Text, 1, phonebook_ref.phoneBook.Rows[phonebook_ref.index].Cells[1].Value.ToString());
                    phonebook_ref.phoneBook.DataSource = phonebook_ref.dataHandler.LoadDataGird();
                    if (check != "")
                    {
                        MessageBox.Show(check, "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Contact updated ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Name can only have alphabets from A-z/a-z and space ", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (phone_book.search_number == true)
            {
                if(dataHandler.InputValidation(number_tbox.Text, 2)==1)
                {
                    string check = phonebook_ref.dataHandler.Update(number_tbox.Text, 2, phonebook_ref.phoneBook.Rows[phonebook_ref.index].Cells[1].Value.ToString());
                    phonebook_ref.phoneBook.DataSource = phonebook_ref.dataHandler.LoadDataGird();
                    if (check != "")
                    {
                        MessageBox.Show(check, "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Contact updated ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Number can only have digits and must be in the following format 1234-5678910 ", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (phone_book.search_email == true)
            {
                if(dataHandler.InputValidation(mail_tbox.Text, 3)==1)
                {
                    string check = phonebook_ref.dataHandler.Update(mail_tbox.Text, 3, phonebook_ref.phoneBook.Rows[phonebook_ref.index].Cells[1].Value.ToString());
                    phonebook_ref.phoneBook.DataSource = phonebook_ref.dataHandler.LoadDataGird();
                    if (check != "")
                    {
                        MessageBox.Show(check, "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Contact updated ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Email can only have digits, lower case alphabets , . , _ and must be in the following abc@mail.com ", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void input_FormClosing(object sender, FormClosingEventArgs e)
        {
            phonebook_ref.Show();
        }

        private void mail_tbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
