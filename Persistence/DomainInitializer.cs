using Persistence.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Persistence
{
    internal class DomainInitializer : MigrateDatabaseToLatestVersion<DomainContext, Configuration>
    {
        public override void InitializeDatabase(DomainContext context)
        {
            base.InitializeDatabase(context);

        }

    }
}
