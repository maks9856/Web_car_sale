using Microsoft.EntityFrameworkCore;

namespace WEB_car_sale.DataBaseAccess
{
    public class WEB_car_sale_DBContext:DbContext
    {
        public WEB_car_sale_DBContext(DbContextOptions<WEB_car_sale_DBContext> options) : base(options) { }
    }
}
