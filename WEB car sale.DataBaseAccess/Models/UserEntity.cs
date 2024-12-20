using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_car_sale.DataBaseAccess.Models
{
    public class UserEntity
    {
        public Guid Id { get; set; }
        public string FirsName { get; set; } = string.Empty;
        public string SecondName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string NumberPhone { get; set; } = string.Empty;
        public DateTime CreatedBy { get; set; } = DateTime.UtcNow;
    }
}
