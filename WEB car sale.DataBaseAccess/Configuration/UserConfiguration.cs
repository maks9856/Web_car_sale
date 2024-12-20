using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEB_car_sale.DataBaseAccess.Models;
using WEB_car_sale.Core;
using WEB_car_sale.Core.Models;

namespace WEB_car_sale.DataBaseAccess.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.FirsName).HasMaxLength(User.MAX_FIRSTNAME_LENGTH).IsRequired();
            builder.Property(u=>u.SecondName).HasMaxLength(User.MAX_SECONDNAME_LENGTH).IsRequired();
            builder.Property(u => u.NumberPhone).IsRequired();
            builder.Property(u=>u.Email).IsRequired();
            builder.Property(u=>u.CreatedBy).IsRequired();
        }
    }
}
