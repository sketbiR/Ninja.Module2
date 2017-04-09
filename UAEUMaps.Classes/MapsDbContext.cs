using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations.History;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAEUMaps.Classes
{
    public class MapsDbContext : DbContext 
    {

        public DbSet<Category> Categories  { get; set; }
        public DbSet<AccessList> AccessLists  { get; set; }
        public DbSet<Marker> Markers  { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           // modelBuilder.HasDefaultSchema("ASPNET_CUSTOM");
           // modelBuilder.Types().Configure(c => c.ToTable(c.ClrType.Name.ToUpper(), "ASPNET_CUSTOM"));
           // modelBuilder.Properties().Configure(c => c.HasColumnName(c.ClrPropertyInfo.Name.ToUpper()));
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("ASPNET_CUSTOM");
         //   modelBuilder.Entity<HistoryRow>().ToTable(tableName: "MigrationHistory", schemaName: "admin");
           // modelBuilder.Entity<HistoryRow>().Property(p => p.MigrationId).HasColumnName("Migration_ID");
      //  }


    }

    }


}
