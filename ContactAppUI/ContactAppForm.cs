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
    public partial class ContactAppForm : Form
    {
        Project _contactsProject;

        public Project ContactsProject { get => _contactsProject; set => _contactsProject = value; }

        public ContactAppForm()
        {
            InitializeComponent();
            //SaveAll();
            ContactsProject = ProjectManager.LoadFromFile();
            RecreateContactList();
        }
        void RecreateContactList(int defaultSelectedIndex = 0)
        {
            var contactNames = ContactsProject.Contacts.ToArray();
            ContactsListBox.Items.Clear();
            for (int i = 0; i < contactNames.Length; i++)
            {
                ContactsListBox.Items.Add(contactNames[i].Surname + " " + contactNames[i].Name);
            }
            ContactsListBox.SelectedIndex = defaultSelectedIndex;
            ProjectManager.SaveToFile(ContactsProject);
        }
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            AddEditContactForm addEditContactForm = new AddEditContactForm();
            var dialogResult = addEditContactForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                Contact contact = addEditContactForm.CurrentContact;
                ContactsProject.Contacts.Add(contact);
                RecreateContactList(ContactsProject.Contacts.ToArray().Length - 1);
            }
        }
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            AddEditContactForm addEditContactForm = new AddEditContactForm();
            Contact contact = ContactsProject.Contacts[ContactsListBox.SelectedIndex];
            addEditContactForm.CurrentContact = contact;
            var dialogResult = addEditContactForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                RecreateContactList(ContactsListBox.SelectedIndex);
            }
        }
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            ContactsProject.Contacts.Remove(ContactsProject.Contacts[ContactsListBox.SelectedIndex]);
            RecreateContactList();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutProgramForm();
            aboutForm.ShowDialog();
        }
        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var contact = ContactsProject.Contacts[ContactsListBox.SelectedIndex];

            nameTextBox.Text = contact.Name;
            surnameTextBox.Text = contact.Surname;
            emailTextBox.Text = contact.Email;
            VKTextBox.Text = contact.IdVK;
            birthTextBox.Text = contact.BirthDate.ToString("d");
            phoneTextBox.Text = contact.ContactNumber.Number.ToString();
        }
    }
}
