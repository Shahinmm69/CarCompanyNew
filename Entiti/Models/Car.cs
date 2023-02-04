using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities
{
    public class Car : BaseEntity
    {
        public string CarName{ get; set; }
        public int CompanyId{ get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ICollection<CarModel> CarModels{ get; set; }
    }
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.Property(p => p.CarName).IsRequired().HasMaxLength(100);
            builder.HasOne(p => p.Company).WithMany(c => c.Cars).HasForeignKey(p => p.CompanyId);
        }
    }
}
