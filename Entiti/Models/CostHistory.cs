using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities
{
    public class CostHistory : BaseEntity
    {
        public DateTime HistoryDate { get; set; }
        public int Cost { get; set; }
        public int ModelId { get; set; }

        public virtual CarModel Model { get; set; } = null!;
    }
    public class CostHistoryConfiguration : IEntityTypeConfiguration<CostHistory>
    {
        public void Configure(EntityTypeBuilder<CostHistory> builder)
        {
            builder.Property(p => p.HistoryDate).IsRequired();
            builder.Property(p => p.Cost).IsRequired();
            builder.HasOne(p => p.Model).WithMany(c => c.CostHistories).HasForeignKey(p => p.ModelId);
        }
    }
}
