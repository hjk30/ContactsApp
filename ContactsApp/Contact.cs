using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ContactsApp
{
    /// <summary>
    /// Класс контакта. Содержит информацию о контакте: Фамилию, Имя, почту, ID ВКонтакте, дату рождения и номер телефона
    /// </summary>
    public class Contact : ICloneable
    {
        string _name;
        string _surname;
        string _email;
        string _idVK;
        DateTime _birthDate;
        PhoneNumber _phoneNumber;

        public Contact(string name, string surname, string email, string idVK, DateTime birthDate, PhoneNumber phoneNumber)
        {
            Name = name;
            Surname = surname;
            Email = email;
            IdVK = idVK;
            BirthDate = birthDate;
            PhoneNumber = phoneNumber;
        }
        /// <summary>
        /// Возвращает и задает имя (не длиннее 50 символов)
        /// </summary>
        public string Name { 
            get => _name;
            set {
                if (_name != value)
                {
                    if (value.Length < 50)
                    {
                        _name = value;
                    }
                }
            }
        }
        /// <summary>
        /// Возвращает и задает фамилию (не длиннее 50 символов)
        /// </summary>
        public string Surname { 
            get => _surname;
            set
            {
                if (_surname != value)
                {
                    if (value.Length < 50)
                    {
                        _surname = value;
                    }
                }
            }
        }
        /// <summary>
        /// Возвращает и задает почту (не длиннее 50 символов)
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                if (_email != value)
                {
                    if (value.Length < 50)
                    {
                        _email = value;
                    }
                }
            }
        }
        /// <summary>
        /// Возвращает и задает ID ВКонтакте (не длиннее 15 символов)
        /// </summary>
        public string IdVK { 
            get => _idVK;
            set {
                if(_idVK != value)
                {
                    if (value.Length < 15)
                    {
                        _idVK = value;
                    }
                }
            }
        }
        /// <summary>
        /// Возвращает и задает дату рождения (не раньше 1900 года)
        /// </summary>
        public DateTime BirthDate { 
            get => _birthDate;
            set {
                if(_birthDate != value)
                {
                    if (value.Year > 1900)
                    {
                        _birthDate = value;
                    }
                    else
                    {
                        throw new ArgumentException("Ну не мог он родиться раньше 1900 года");
                    }
                }
            }
        }
        /// <summary>
        /// Возвращает и задает номер телефона
        /// </summary>
        public PhoneNumber PhoneNumber { 
            get => _phoneNumber;
            set {
                if(_phoneNumber != value)
                {
                    _phoneNumber = value;
                }
            }
        }

        public object Clone()
        {
            return new Contact(Name, Surname, Email, IdVK, BirthDate, PhoneNumber);
        }
    }
}
