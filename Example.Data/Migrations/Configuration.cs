using System.Data.Entity.Migrations;

namespace Example.Data.Migrations
{
    public class Configuration : DbMigrationsConfiguration<ExampleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            //AutomaticMigrationDataLossAllowed = true;
        }
        protected override void Seed(ExampleContext context)
        {
            //初始化一些数据
            //var article = new Article
            //{
            //    Title="test",
            //    Content="test"
            //};

            base.Seed(context);
        }
    }
}
