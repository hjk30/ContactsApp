using ContactsApp;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.UnitTests
{
    internal class ProjectTest
    {

        Project _contactsProject;

        [SetUp]
        public void CreateContact()
        {
            List<Contact> contacts = new List<Contact>();
            _contactsProject = new Project(contacts);
        }
        [Test(Description = "Присвоение верного списка")]
        public void TestContactsSet_CorrectString()
        {
            var expected = new PhoneNumber(77777777777);
            Assert.DoesNotThrow(
            () => {
                List<Contact> contacts = new List<Contact>();
                contacts.Add(new Contact("Шифман", "Демид", "уу@уу", "77777", DateTime.Now, new PhoneNumber(77777777777))); 
                _contactsProject.Contacts = contacts; },
            "Не должно вохникать исключения");
        }
        [Test(Description = "Получение верного списка")]
        public void TestContactsGet_CorrectString()
        {
            List<Contact> contacts = new List<Contact>();
            contacts.Add(new Contact("Шифман", "Демид", "уу@уу", "77777", DateTime.Now, new PhoneNumber(77777777777)));
            var expected = contacts;

            _contactsProject.Contacts = expected;
            var actual = _contactsProject.Contacts;
            ClassicAssert.AreEqual(expected, actual, "Геттер Contacts возвращает неправильный список");
        }
    }
}
