using System.Data.Entity;

namespace Example.Data.Initializers
{
    /// <summary>
    /// 数据库初始化策略
    /// Entity Framework本身支持以下几种数据库初始化策略：
    ///MigrateDatabaseToLatestVersion：使用Code First数据库迁移策略，将数据库更新到最新版本
    ///NullDatabaseInitializer：一个什么都不干的数据库初始化器
    ///CreateDatabaseIfNotExists：顾名思义，如果数据库不存在则新建数据库
    ///DropCreateDatabaseAlways：无论数据库是否存在，始终重建数据库
    ///DropCreateDatabaseIfModelChanges：仅当领域模型发生变化时才重建数据库
    /// </summary>
    public class ExampleInitializer : CreateDatabaseIfNotExists<ExampleContext>
    {
        //protected override void Seed(EddytBlogContext context)
        //{
        //    //初始化一些数据
        //    //var article = new Article
        //    //{
        //    //    Title="test",
        //    //    Content="test"
        //    //};

        //    base.Seed(context);
        //}
    }
}
