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
            ContactNumber = phoneNumber;
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
                    else
                    {
                        throw new ArgumentException("Слишком много символов для имени, должно быть короче 50");
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
                    else
                    {
                        throw new ArgumentException("Слишком много символов для фамилии, должно быть короче 50");
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
                    if (value.Length < 50 && value.Contains("@"))
                    {
                        _email = value;
                    }
                    else if(value.Length >= 50)
                    {
                        throw new ArgumentException("Слишком много символов для email, должно быть короче 50");
                    }
                    else { throw new ArgumentException("Email должен содержать сивол @");  }
                }
                //дописать проверку на то что это имейл
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
                    else
                    {
                        throw new ArgumentException("Слишком много символов для id VK, должно быть короче 15");
                    }
                }
            }
        }
        /// <summary>
        /// Возвращает и задает дату рождения (не раньше 1900 года)
        /// </summary>
        public DateTime BirthDate { 
            get => _birthDate;
            set
            {
                if (value.Year < 1900)
                {
                    throw new ArgumentException("Ну не мог он родиться раньше 1900 года");
                }
                else if (_birthDate != value)
                {
                    _birthDate = value;
                }
            }
        }
        /// <summary>
        /// Возвращает и задает номер телефона
        /// </summary>
        public PhoneNumber ContactNumber { 
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
            return new Contact(Name, Surname, Email, IdVK, BirthDate, ContactNumber);
        }
    }
}
