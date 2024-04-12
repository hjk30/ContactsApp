using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;

namespace ContactAppUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void VKTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string surname = surnameTextBox.Text;
            string email = emailTextBox.Text;
            string idVK = VKTextBox.Text;
            DateTime birthDate = birthDateTime.Value;
            PhoneNumber phoneNumber = new PhoneNumber((long)Convert.ToDouble(phoneTextBox.Text));
            Contact contact = new Contact(name, surname, email, idVK, birthDate, phoneNumber);

            var contacts = new Dictionary<string, Contact>();
            contacts.Add("0", contact);
         
            Project project = new Project(contacts);

            ProjectManager.SaveToFile(project);
            MessageBox.Show("Saved");
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            Project project = ProjectManager.LoadFromFile();

            var contact = project.Contacts["0"];

            nameTextBox.Text = contact.Name;
            surnameTextBox.Text = contact.Surname;
            emailTextBox.Text = contact.Email;
            VKTextBox.Text = contact.IdVK;
            birthDateTime.Value = contact.BirthDate;
            phoneTextBox.Text = contact.PhoneNumber.Number.ToString();
        }
    }
}
