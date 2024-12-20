using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_car_sale.Core.Errors
{
     class UsersErrors:Exception
    {
        public UsersErrors(string message):base(message) { }
    }
}
