﻿using System;
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
            //SaveAll();
            ContactsProject = ProjectManager.LoadFromFile();
            CreateContactList();
        }
        /// <summary>
        /// Пересоздаёт лист со всеми контактами
        /// </summary>
        /// <param name="defaultSelectedIndex">номер контакта, который будет выделен после пересоздания</param>
        void CreateContactList()
        {
            var contactNames = ContactsProject.Contacts.ToArray();
            ContactsListBox.Items.Clear();
            for (int i = 0; i < contactNames.Length; i++)
            {
                ContactsListBox.Items.Add(ContactsProject.Contacts[i]);
                ContactsListBox.DisplayMember = ContactsProject.Contacts[i].ToString();
            }
            ContactsListBox.SelectedIndex = 0;
        }
        /// <summary>
        /// Обработка кнопки "Добавить контакт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            AddEditContactForm addEditContactForm = new AddEditContactForm();
            var dialogResult = addEditContactForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                Contact contact = addEditContactForm.CurrentContact;
                ContactsProject.Contacts.Add(contact);
                ContactsListBox.Items.Add(contact);
                ContactsListBox.DisplayMember = contact.ToString();
                ContactsListBox.SelectedIndex = ContactsProject.Contacts.ToArray().Length - 1;
                ProjectManager.SaveToFile(ContactsProject);
            }
        }
        /// <summary>
        /// Обработка кнопки "Редактировать контакт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            AddEditContactForm addEditContactForm = new AddEditContactForm();
            Contact contact = (Contact)ContactsListBox.SelectedItem;
            var oldContactIndex = ContactsListBox.SelectedIndex;
            addEditContactForm.CurrentContact = contact;
            var dialogResult = addEditContactForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                ContactsListBox.SelectedItem = (contact);
                ContactsListBox.DisplayMember = contact.ToString();
                ContactsListBox.SelectedIndex = oldContactIndex;
            }
        }
        /// <summary>
        /// Обработка кнопки "Удалить контакт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            Contact contact = (Contact)ContactsListBox.SelectedItem;
            ContactsListBox.SelectedIndex = 0;
            ContactsProject.Contacts.Remove(contact);
            ContactsListBox.Items.Remove(contact);
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
            var contact = (Contact)ContactsListBox.SelectedItem;

            nameTextBox.Text = contact.Name;
            surnameTextBox.Text = contact.Surname;
            emailTextBox.Text = contact.Email;
            VKTextBox.Text = contact.IdVK;
            birthTextBox.Text = contact.BirthDate.ToString("d");
            phoneTextBox.Text = contact.ContactNumber.Number.ToString();
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
    }
}
