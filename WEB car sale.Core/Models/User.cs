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
        private const int MAX_FIRSTNAME_LENGTH = 250;
        private const int MAX_SECONDNAME_LENGTH = 250;

        private User (Guid id, string firsName, string secondName, string email, DateTime createdBy)
        {
            Id = id;
            FirsName = firsName;
            SecondName = secondName;
            Email = email;
            CreatedBy = createdBy;
        }

        public Guid Id { get; set; }
        public string FirsName { get; set; } = string.Empty;
        public string SecondName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime CreatedBy { get; set; } = DateTime.UtcNow;

        public static User CreateUser(Guid id, string firsName, string secondName, string email, DateTime createdBy)
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
            if (string.IsNullOrEmpty(email))
            {
                throw new UsersErrors("Заповніть поле Email");
            }
            if (EmailValidation(email))
            {
                throw new UsersErrors("Неправильно введений Email");
            }

            var user = new User(id, firsName, secondName, email, createdBy);
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
