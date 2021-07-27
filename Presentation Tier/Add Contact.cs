using System;
using System.Drawing;
using System.Windows.Forms;

namespace J10
{
    public partial class Add_Contact : Form
    {
        phone_book phonebook_ref;
        public Add_Contact()
        {
            InitializeComponent();
        }
        public Add_Contact(phone_book phonebook)
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
        }
        private void Add_Contact_Load(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if(name_tbox.Text!= "Enter Name" && number_tbox.Text!= "Enter Number" && mail_tbox.Text!= "Enter Email" && address_tbox.Text!= "Enter Address")
            {
                string check;
                byte status = phonebook_ref.dataHandler.InputValidation(name_tbox.Text, number_tbox.Text, mail_tbox.Text);
                if (status == 1)
                {
                    check=phonebook_ref.dataHandler.StoreDataGird(name_tbox.Text, number_tbox.Text, mail_tbox.Text, address_tbox.Text);
                    phonebook_ref.phoneBook.DataSource = phonebook_ref.dataHandler.LoadDataGird();
                    if(check!="")
                    {
                        MessageBox.Show(check, "Invalid number", MessageBoxButtons.OK, MessageBoxIcon.Error);                   
                    }
                    else
                    {
                        MessageBox.Show("Contact added ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else if (status == 2)
                {
                    MessageBox.Show("Name can only have alphabets from A-z/a-z and space ", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (status == 3)
                {
                    MessageBox.Show("Number can only have digits and must be in the following format 1234-5678910 ", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (status == 4)
                {
                    MessageBox.Show("Email can only have digits, lower case alphabets , . , _ and must be in the following abc@mail.com ", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (status == 5)
                {
                    MessageBox.Show("Name can only have alphabets from A-z/a-z and space ", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Number can only have digits and must be in the following format 1234-5678910 ", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Email can only have digits, lower case alphabets , . , _ and must be in the following abc@mail.com ", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all textboxes", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void name_tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_tbox_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private void OnNameFocus(object sender, EventArgs e)
        {
            name_tbox.Clear();
            name_tbox.ForeColor = Color.Black;
        }

        private void OnNameDefocus(object sender, EventArgs e)
        {
            if(name_tbox.Text.Length==0)
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

        private void Add_Contact_FormClosing(object sender, FormClosingEventArgs e)
        {
            phonebook_ref.Show();
        }
    }
}
