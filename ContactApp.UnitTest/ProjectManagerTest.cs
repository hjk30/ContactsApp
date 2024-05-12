using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactApp;
using ContactsApp;
using NUnit.Framework.Legacy;
using NUnit.Framework;

namespace ContactApp.UnitTests
{
    internal class ProjectManagerTest
    {

        Project _contactsProject;

        [SetUp]
        public void CreateContact()
        {
            List<Contact> contacts = new List<Contact>();
            _contactsProject = new Project(contacts);
            contacts.Add(new Contact("Шифман", "Демид", "уу@уу", "77777", DateTime.Now, new PhoneNumber(77777777777)));
            contacts.Add(new Contact("Ли", "Александр", "уу@уу", "77777", DateTime.Now, new PhoneNumber(77777777777)));
            _contactsProject.Contacts = contacts;
        }
        [Test(Description = "Сохранение проекта контактов")]
        public void TestSave_CorrectString()
        {
            Assert.DoesNotThrow(
            () => {
                ProjectManager.SaveToFile(_contactsProject);
            },
            "Не должно вохникать исключения");
        }
        [Test(Description = "Загрузка проекта контактов")]
        public void TestLoad_CorrectString()
        {
            Assert.DoesNotThrow(
            () => {
                _contactsProject = ProjectManager.LoadFromFile();
            },
            "Не должно вохникать исключения");
        }
    }
}
