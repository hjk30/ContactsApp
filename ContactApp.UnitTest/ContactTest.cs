﻿using ContactsApp;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.UnitTests
{
    internal class ContactTest
    {
        private Contact _contact = null;

        [SetUp]
        public void CreateContact()
        {
            _contact = new Contact("Шифман", "Демид", "уу@уу", "77777", DateTime.Now, new PhoneNumber(77777777777));
        }


        [Test(Description = "Присвоение строки длиннее 50 символов в качестве фамилии")]
        public void TestSurnameSet_LongString()
        {
            var wrongSurname = "11111111111111111111111111111111111111111111111111111111111111";
            Assert.Throws<ArgumentException>(
            () => { _contact.Surname = wrongSurname; },
            "Должно возникать исключение, если фамилия длиннее 50");
        }
        [Test(Description = "Присвоение верной фамилии")]
        public void TestSurnameSet_CorrectString()
        {
            var expected = "Иванов";
            Assert.DoesNotThrow(
            () => { _contact.Surname = expected; },
            "Не должно вохникать исключения");
        }
        [Test(Description = "Получение верной фамилии")]
        public void TestSurnameGet_CorrectString()
        {
            var expected = "Иванов";
            _contact.Surname = expected;
            var actual = _contact.Surname;
            ClassicAssert.AreEqual(expected, actual, "Геттер Surname возвращает неправильную фамилию");
        }
        [Test(Description = "Присвоение строки длиннее 50 символов в качестве фамилии")]
        public void TestNameSet_LongString()
        {
            var wrongName = "11111111111111111111111111111111111111111111111111111111111111";
            Assert.Throws<ArgumentException>(
            () => { _contact.Name = wrongName; },
            "Должно возникать исключение, если имя длиннее 50");
        }
        [Test(Description = "Присвоение верного имени")]
        public void TestNameSet_CorrectString()
        {
            var expected = "Иван";
            Assert.DoesNotThrow(
            () => { _contact.Name = expected; },
            "Не должно вохникать исключения");
        }
        [Test(Description = "Получение верного имени")]
        public void TestNameGet_CorrectString()
        {
            var expected = "Иван";
            _contact.Name = expected;
            var actual = _contact.Name;
            ClassicAssert.AreEqual(expected, actual, "Геттер Name возвращает неправильное имя");
        }
        [TestCase("aaaa", "Должно возникать исключение, если Email не содержит @",
            TestName = "Присвоение Email не начинающегося с 7")]
        [TestCase("11111111111111111111111111111111111111111111", "Должно возникать исключение, если Email более 50 символов длинной",
            TestName = "Присвоение длинного Email")]
        public void TestEmailSet_ArgumentException(string wrongEmail, string message)
        {
            Assert.Throws<ArgumentException>(
            () => { _contact.Email = wrongEmail; },
            message);
        }
        [Test(Description = "Присвоение верного Email")]
        public void TestEmailSet_CorrectString()
        {
            var expected = "aa@mail.ru";
            Assert.DoesNotThrow(
            () => { _contact.Name = expected; },
            "Не должно вохникать исключения");
        }
        [Test(Description = "Получение верного Email")]
        public void TestEmailGet_CorrectString()
        {
            var expected = "aa@mail.ru";
            _contact.Email = expected;
            var actual = _contact.Email;
            ClassicAssert.AreEqual(expected, actual, "Геттер Email возвращает неправильное имя");
        }
        [Test(Description = "Присвоение строки длиннее 15 символов в качестве VKID")]
        public void TestIdVKSet_LongString()
        {
            var wrongIdVK = "111111111111111111111111";
            Assert.Throws<ArgumentException>(
            () => { _contact.IdVK = wrongIdVK; },
            "Должно возникать исключение, если имя длиннее 15");
        }
        [Test(Description = "Присвоение верного VKID")]
        public void TestIdVKSet_CorrectString()
        {
            var expected = "123456";
            Assert.DoesNotThrow(
            () => { _contact.IdVK = expected; },
            "Не должно вохникать исключения");
        }
        [Test(Description = "Получение верного VKID")]
        public void TestIdVKGet_CorrectString()
        {
            var expected = "123456";
            _contact.IdVK = expected;
            var actual = _contact.IdVK;
            ClassicAssert.AreEqual(expected, actual, "Геттер IdVK возвращает неправильное имя");
        }
        [Test(Description = "Присвоение даты рождения раньше 1900 года")]
        public void TestBirthDateSet_LongString()
        {
            var wrongBirthDate = DateTime.Parse("1600.01.01");
            Assert.Throws<ArgumentException>(
            () => { _contact.BirthDate = wrongBirthDate; },
            "Должно возникать исключение, если дата раньше 1900 года");
        }
        [Test(Description = "Присвоение верной даты рождения")]
        public void TestBirthDateSet_CorrectString()
        {
            var expected = DateTime.Now;
            Assert.DoesNotThrow(
            () => { _contact.BirthDate = expected; },
            "Не должно вохникать исключения");
        }
        [Test(Description = "Получение верной даты рождения")]
        public void TestBirthDateGet_CorrectString()
        {
            var expected = DateTime.Now;
            _contact.BirthDate = expected;
            var actual = _contact.BirthDate;
            ClassicAssert.AreEqual(expected, actual, "Геттер BirthDate возвращает неправильную дату");
        }
        [Test(Description = "Присвоение верного номера телефона")]
        public void TestContactNumberSet_CorrectString()
        {
            var expected = new PhoneNumber(77777777777);
            Assert.DoesNotThrow(
            () => { _contact.ContactNumber = expected; },
            "Не должно вохникать исключения");
        }
        [Test(Description = "Получение верного номера телефона")]
        public void TestContactNumberGet_CorrectString()
        {
            var expected = new PhoneNumber(77777777777);
            _contact.ContactNumber = expected;
            var actual = _contact.ContactNumber;
            ClassicAssert.AreEqual(expected, actual, "Геттер ContactNumber возвращает неправильный номер");
        }

    }
}
