using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities
{
    public class CarModel: BaseEntity
    {
        public string ModelName { get; set; }
        public int CarId { get; set; }

        public virtual Car Car { get; set; } = null!;
        public virtual ICollection<CarImagesGallery> CarImagesGalleries { get; set; }
        public virtual ICollection<CostHistory> CostHistories { get; set; }
    }
    public class CarModelConfiguration : IEntityTypeConfiguration<CarModel>
    {
        public void Configure(EntityTypeBuilder<CarModel> builder)
        {
            builder.Property(p => p.ModelName).IsRequired().HasMaxLength(100);
            builder.HasOne(p => p.Car).WithMany(c => c.CarModels).HasForeignKey(p => p.CarId);
        }
    }
}
