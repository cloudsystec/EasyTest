using System.Data.Entity.Migrations;
using EASY.Crud.Entity.Migrations.Seed;

namespace EASY.Crud.Entity.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Context context)
        {
            SeedInit.InitiateKnowledge();
        }
    }
}
