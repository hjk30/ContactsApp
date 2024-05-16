using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class Project
    {
        private List<Contact> _contacts;
        public List<Contact> Contacts { get => _contacts; set => _contacts = value; }
        public Project(List<Contact> contacts)
        {
            Contacts = contacts;
        }

        public List<Contact> GetContactsWithBirthday(DateTime birthday)
        {
            List<Contact> contactsWithBirthday = new List<Contact>();
            for (int index = 0; index < this.Contacts.Count; ++index)
            {
                DateTime birthDate = this.Contacts[index].BirthDate;
                int num;
                if (birthDate.Day == birthday.Day)
                {
                    birthDate = this.Contacts[index].BirthDate;
                    num = birthDate.Month == birthday.Month ? 1 : 0;
                }
                else
                    num = 0;
                if (num != 0)
                    contactsWithBirthday.Add(this.Contacts[index]);
            }
            return contactsWithBirthday;
        }

        private List<Contact> SortList(List<Contact> list)
        {
            for (int index1 = 0; index1 < list.Count - 1; ++index1)
            {
                for (int index2 = index1 + 1; index2 < list.Count; ++index2)
                {
                    if (list[index1].ToString().CompareTo(list[index2].ToString()) > 0)
                    {
                        Contact contact = list[index1];
                        list[index1] = list[index2];
                        list[index2] = contact;
                    }
                }
            }
            return list;
        }

        public List<Contact> GetSortedContacts()
        {
            return this.SortList(new List<Contact>((IEnumerable<Contact>)this.Contacts));
        }

        public List<Contact> GetSortedContacts(string inculded)
        {
            List<Contact> sortedContacts = this.SortList(new List<Contact>((IEnumerable<Contact>)this.Contacts));
            int count = sortedContacts.Count;
            while (count != 0)
            {
                --count;
                Contact contact = sortedContacts[count];
                if (!contact.ToString().Contains(inculded))
                    sortedContacts.Remove(contact);
            }
            return sortedContacts;
        }
    }
}
