using System;
using System.Collections.Generic;
using Entities;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Common;
using System.Reflection.Metadata;
using Abp.Domain.Entities;
using IEntity = Entities.IEntity;

namespace Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var entitiesAssembly = typeof(IEntity).Assembly;

            modelBuilder.RegisterAllEntities<IEntity>(entitiesAssembly);
            modelBuilder.RegisterEntityTypeConfiguration(entitiesAssembly);
            modelBuilder.AddRestrictDeleteBehaviorConvention();
            modelBuilder.AddPluralizingTableNameConvention();
        }

        public override int SaveChanges() => base.SaveChanges();

        public override int SaveChanges(bool acceptAllChangesOnSuccess) => base.SaveChanges(acceptAllChangesOnSuccess);

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default) => base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default) => base.SaveChangesAsync(cancellationToken);
    }
}