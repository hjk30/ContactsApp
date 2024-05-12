using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ContactsApp;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace ContactApp.UnitTests
{
    /// <summary>
    /// Класс модельных тестов номера телефона
    /// </summary>
    /// 
    public class PhoneNumberTest
    {

        PhoneNumber _number;

        [SetUp]
        public void CreateContact()
        {
            _number = new PhoneNumber(77777777777);
        }
        [TestCase(91231231223, "Должно возникать исключение, если номер начинается не с 7",
            TestName = "Присвоение номера не начинающегося с 7")]
        [TestCase(777, "Должно возникать исключение, номер не 11 символов длинной",
            TestName = "Присвоение короткого номера телефона")]
        public void TestPhoneNumberSet_ArgumentException(long wrongNumber, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _number.Number = wrongNumber; },
            message);
        }
        [Test(Description = "Присвоение верного номера")]
        public void TestSurnameSet_CorrectString()
        {
            var expected = (77777777778);
            Assert.DoesNotThrow(
            () => { _number.Number = expected; },
            "Не должно вохникать исключения");
        }
        [Test(Description = "Получение верного номера")]
        public void TestPhoneNumberGet_CorrectString()
        {
            var expected = (77777777778);

            _number.Number = expected;
            var actual = _number.Number;
            ClassicAssert.AreEqual(expected, actual, "Геттер Number возвращает неправильный номер");
        }
    }
}
