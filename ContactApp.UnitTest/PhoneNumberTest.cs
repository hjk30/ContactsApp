using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ContactsApp;
using NUnit.Framework;

namespace ContactsAppTest
{
    /// <summary>
    /// Класс модельных тестов номера телефона
    /// </summary>
    public class PhoneNumberTest
    {
        [TestCase(91231231223, "Должно возникать исключение, если номер начинается не с 7",
            TestName = "Присвоение номера не начинающегося с 7")]
        [TestCase(777, "Должно возникать исключение, номер не 11 символов длинной",
            TestName = "Присвоение короткого номера телефона")]

        public void TestPhoneNumberSet_ArgumentException(long wrongNumber, string message)
        {
            var number = new PhoneNumber(77777777777);
            Assert.Throws<ArgumentException>(
            () => { number.Number = wrongNumber; },
            message);
        }


    }
}
