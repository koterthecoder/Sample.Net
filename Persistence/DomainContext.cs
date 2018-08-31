using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Utilities;

namespace Persistence
{
    public class DomainContext : DbContext
    {

        public DomainContext() : base("DomainContext")
        { }

        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties()
                .Where(p => p.Name.Equals("Id"))
                .Configure(p => p.IsKey());

            // TodoItem
            //modelBuilder.Entity<TodoItem>().Property(x => x.AccountId).IsRequired().HasColumnAnnotation(
            //    IndexAnnotation.AnnotationName,
            //    new IndexAnnotation(
            //        new IndexAttribute("IX_AccountId", 1) { IsUnique = true }));


            Database.SetInitializer(new DomainInitializer());
        }

        public override int SaveChanges()
        {
            var entities = ChangeTracker.Entries<IEntity>()
                .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);
            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added || entity.Entity.Created.Equals(DateTime.MinValue))
                {
                    entity.Entity.Created = SystemTime.Current.Invoke();
                }
                entity.Entity.Modified = SystemTime.Current.Invoke();
            }

            var result = base.SaveChanges();
            return result;
        }


    }
}
