using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities
{
    public class CarImagesGallery: BaseEntity
    {
        public string CarImagesGalleryAddress { get; set; }
        public int ModelId { get; set; }

        public virtual CarModel Model { get; set; } = null!;
    }
    public class CarImagesGalleryConfiguration : IEntityTypeConfiguration<CarImagesGallery>
    {
        public void Configure(EntityTypeBuilder<CarImagesGallery> builder)
        {
            builder.Property(p => p.CarImagesGalleryAddress).IsRequired();
            builder.HasOne(p => p.Model).WithMany(c => c.CarImagesGalleries).HasForeignKey(p => p.ModelId);
        }
    }
}
