using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity.Migrations;

namespace Persistence.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DomainContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
        }

        //protected override void Seed(DomainContext context)
        //{
        //    ExtractAndInsertStandardEnums(context, typeof());
        //}

        //public static void ExtractAndInsertStandardEnums(DomainContext context, Type type)
        //{
        //}
    }
}
