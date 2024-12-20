using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using WEB_car_sale.Core.Errors;

namespace WEB_car_sale.Core.Models
{
    public class User
    {
        public const int MAX_FIRSTNAME_LENGTH = 250;
        public const int MAX_SECONDNAME_LENGTH = 250;

        private User (Guid id, string firsName, string secondName,string numberPhone, string email,string passwordHash, DateTime createdBy)
        {
            Id = id;
            FirsName = firsName;
            SecondName = secondName;
            NumberPhone = numberPhone;
            Email = email;
            PasswordHash = passwordHash;
            CreatedBy = createdBy;
        }

        public Guid Id { get; set; }
        public string FirsName { get; set; } = string.Empty;
        public string SecondName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash {  get; set; } = string.Empty;
        public string NumberPhone { get; set; } = string.Empty;
        public DateTime CreatedBy { get; set; } = DateTime.UtcNow;

        public static User CreateUser(Guid id, string firsName, string secondName,string numberPhone, string email,string passwordHash, DateTime createdBy)
        {
            if (string.IsNullOrEmpty(firsName))
            {

               throw new UsersErrors("Заповніть поле ім'я");
            }
            if (firsName.Length > MAX_FIRSTNAME_LENGTH)
            {
                throw new UsersErrors($"Ім'я не повине перевищувати {MAX_FIRSTNAME_LENGTH}");
            }
            if (string.IsNullOrEmpty(secondName))
            {

                throw new UsersErrors("Заповніть поле прізвище");
            }
            if (firsName.Length > MAX_SECONDNAME_LENGTH)
            {
                throw new UsersErrors($"Прізвище не повине перевищувати {MAX_SECONDNAME_LENGTH}");
            }
            if (string.IsNullOrEmpty(numberPhone))
            {

                throw new UsersErrors("Заповніть поле прізвище");
            }
            if (EmailValidation(email))
            {
                throw new UsersErrors("Неправильно введений Email");
            }

            var user = new User(id, firsName, secondName,numberPhone, email,passwordHash, createdBy);
            return user;
        }

        private static bool EmailValidation(string email)
        {
            
            try
            {
                var addres =new  MailAddress(email);
                return true;
            }
            catch { return false; }
        }
    }
}
