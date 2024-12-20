using Microsoft.EntityFrameworkCore;
using WEB_car_sale.DataBaseAccess.Models;

namespace WEB_car_sale.DataBaseAccess
{
    public class WEB_car_sale_DBContext:DbContext
    {
        public WEB_car_sale_DBContext(DbContextOptions<WEB_car_sale_DBContext> options) : base(options) { }
        DbSet<UserEntity> Users = null!;

    }
}
