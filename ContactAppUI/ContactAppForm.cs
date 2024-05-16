using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;

namespace ContactAppUI
{
    /// <summary>
    /// Основная форма приложения
    /// </summary>
    public partial class ContactAppForm : Form
    {
        Project _contactsProject;
        /// <summary>
        /// Список всех контактов
        /// </summary>
        public Project ContactsProject { get => _contactsProject; set => _contactsProject = value; }
        public ContactAppForm()
        {
            InitializeComponent();
            ContactsProject = ProjectManager.LoadFromFile();
            List<Contact> contactsWithBirthday = ContactsProject.GetContactsWithBirthday(DateTime.Now);
            if (contactsWithBirthday.Count == 0)
            {
                birthdayListLabel.Text = "Сегодня нет контактов с днем рождения";
            }
            else
            {
                birthdayListLabel.Text = "Сегодня день рождения у\n";
                for (int index = 0; index < contactsWithBirthday.Count; ++index)
                {
                    birthdayListLabel.Text += contactsWithBirthday[index].ToString();
                    if (index < contactsWithBirthday.Count - 1)
                        birthdayListLabel.Text += ", ";
                }
            }
            CreateContactList();
        }
        /// <summary>
        /// Пересоздаёт лист со всеми контактами
        /// </summary>
        /// <param name="defaultSelectedIndex">номер контакта, который будет выделен после пересоздания</param>
        private void CreateContactList(bool selectSomething = true, int selectedIndex = 0)
        {
            Contact[] contactArray = !(SearchTextBox.Text == "") ? ContactsProject.GetSortedContacts(SearchTextBox.Text).ToArray() : ContactsProject.GetSortedContacts().ToArray();
            ContactsListBox.Items.Clear();
            if (contactArray.Length == 0)
                return;
            for (int index = 0; index < contactArray.Length; ++index)
            {
                ContactsListBox.Items.Add((object)contactArray[index]);
                ContactsListBox.DisplayMember = contactArray[index].ToString();
            }
            if (!selectSomething)
                return;
            ContactsListBox.SelectedIndex = selectedIndex;
        }
        /// <summary>
        /// Обработка кнопки "Добавить контакт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            AddEditContactForm addEditContactForm = new AddEditContactForm();
            if (addEditContactForm.ShowDialog() != DialogResult.OK)
                return;
            Contact currentContact = addEditContactForm.CurrentContact;
            ContactsProject.Contacts.Add(currentContact);
            CreateContactList(false);
            ContactsListBox.SelectedItem = (object)currentContact;
            ProjectManager.SaveToFile(ContactsProject);
        }
        /// <summary>
        /// Обработка кнопки "Редактировать контакт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            if (ContactsListBox.Items.Count == 0 || ContactsListBox.SelectedItem == null)
                return;
            AddEditContactForm addEditContactForm = new AddEditContactForm();
            Contact selectedItem = (Contact)ContactsListBox.SelectedItem;
            addEditContactForm.CurrentContact = selectedItem;
            if (addEditContactForm.ShowDialog() != DialogResult.OK)
                return;
            CreateContactList(false);
            ContactsListBox.SelectedItem = (object)selectedItem;
        }
        /// <summary>
        /// Обработка кнопки "Удалить контакт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            if (ContactsListBox.Items.Count == 0 || ContactsListBox.SelectedItem == null || 
                MessageBox.Show("Вы уверены, что хотите удалить контакт " + 
                ((Contact)ContactsListBox.SelectedItem).ToString(), 
                "Удаление контакта", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            Contact selectedItem = (Contact)ContactsListBox.SelectedItem;
            ContactsListBox.SelectedIndex = 0;
            ContactsProject.Contacts.Remove(selectedItem);
            ContactsListBox.Items.Remove((object)selectedItem);
            ProjectManager.SaveToFile(ContactsProject);
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutProgramForm();
            aboutForm.ShowDialog();
        }
        /// <summary>
        /// Изменение выделения текущего контакта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contact selectedItem = (Contact)ContactsListBox.SelectedItem;
            if (ContactsListBox.Items.Count == 0 || ContactsListBox.SelectedItem == null)
            {
                nameTextBox.Text = "";
                surnameTextBox.Text = "";
                emailTextBox.Text = "";
                VKTextBox.Text = "";
                birthTextBox.Text = "";
                phoneTextBox.Text = "";
            }
            else
            {
                nameTextBox.Text = selectedItem.Name;
                surnameTextBox.Text = selectedItem.Surname;
                emailTextBox.Text = selectedItem.Email;
                VKTextBox.Text = selectedItem.IdVK;
                birthTextBox.Text = selectedItem.BirthDate.ToString("d");
                phoneTextBox.Text = selectedItem.ContactNumber.Number.ToString();
            }
        }
        /// <summary>
        /// Сохранение всех контактов при выходе из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactAppForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProjectManager.SaveToFile(ContactsProject);
        }


        private void SearchTextBox_TextChanged(object sender, EventArgs e) => CreateContactList();

        private void timer1_Tick(object sender, EventArgs e)
        {
            birthdayPanel.Visible = false;
            timer1.Stop();
        }
    }
}
