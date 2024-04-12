using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    public class Project
    {
        private Dictionary<string, Contact> _contacts;
        public Dictionary<string, Contact> Contacts { get => _contacts; set => _contacts = value; }
        public Project(Dictionary<string, Contact> contacts)
        {
            Contacts = contacts;
        }
    }
}
