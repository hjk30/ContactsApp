using ContactsApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.UnitTests
{
    internal class ContactTest
    {
        [Test(Description = "Присвоение пустой строки в качестве фамилии")]
        public void TestSurnameSet_EmptyString()
        {
            var wrongSurname = "11111111111111111111111111111111111111111111111111111111111111";
            var contact = new Contact("Шифман", "Демид", "уу@уу", "77777", DateTime.Now, new PhoneNumber(77777777777));
            Assert.Throws<ArgumentException>(
            () => { contact.Surname = wrongSurname; },
            "Должно возникать исключение, если фамилия - пустая строка");
        }

    }
}
