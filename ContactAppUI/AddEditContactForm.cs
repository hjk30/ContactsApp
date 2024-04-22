using ContactsApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ContactAppUI
{
    public partial class AddEditContactForm : Form
    {
        Contact _currentContact;
        public Contact CurrentContact { get => _currentContact; set => _currentContact = value; }
        public AddEditContactForm()
        {
            InitializeComponent();
        }
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;
                string surname = surnameTextBox.Text;
                string email = emailTextBox.Text;
                string idVK = VKTextBox.Text;
                DateTime birthDate = birthDateTime.Value;
                PhoneNumber phoneNumber = new PhoneNumber((long)Convert.ToDouble(phoneTextBox.Text));
                if (CurrentContact == null)
                {
                    CurrentContact = new Contact(name, surname, email, idVK, birthDate, phoneNumber);
                }
                else
                {
                    CurrentContact.Name = name;
                    CurrentContact.Surname = surname;
                    CurrentContact.Email = email;
                    CurrentContact.IdVK = idVK;
                    CurrentContact.BirthDate = birthDate;
                    CurrentContact.ContactNumber = phoneNumber;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void AddEditContactForm_Shown(object sender, EventArgs e)
        {
            if (CurrentContact != null)
            {
                nameTextBox.Text = CurrentContact.Name;
                surnameTextBox.Text = CurrentContact.Surname;
                emailTextBox.Text = CurrentContact.Email;
                VKTextBox.Text = CurrentContact.IdVK;
                birthDateTime.Value = CurrentContact.BirthDate;
                phoneTextBox.Text = CurrentContact.ContactNumber.Number.ToString();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
