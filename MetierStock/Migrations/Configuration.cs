namespace MetierStock.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MetierStock.Model.bdStockCodeFirstContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            //si jamais la migrations aurs des pertes de donnes au'il ne migre pas
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(MetierStock.Model.bdStockCodeFirstContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
