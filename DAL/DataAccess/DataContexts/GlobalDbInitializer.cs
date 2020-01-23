
using SQLite.CodeFirst;
using System.Collections.Generic;
using System.Data.Entity;

namespace NTT.DataAccess.DataContexts
{
    internal class GlobalDbInitializer : SqliteCreateDatabaseIfNotExists<GlobalDbContext>
    {
        public GlobalDbInitializer(DbModelBuilder modelBuilder) : base(modelBuilder)
        {
        }

        public GlobalDbInitializer(DbModelBuilder modelBuilder, bool nullByteFileMeansNotExisting) : base(modelBuilder, nullByteFileMeansNotExisting)
        {
        }

        public override void InitializeDatabase(GlobalDbContext context)
        {
            base.InitializeDatabase(context);
        }

        protected override void Seed(GlobalDbContext context)
        {
            // 初始化数据
            //context.Set<Customer>().Add(new Customer { UserName = "user" + DateTime.Now.Ticks.ToString(), Roles = new List<Role> { new Role { RoleName = "user" } } });
            //context.Set<Post>().Add(new Post { Category = new Category() });


            /* 初始化系统设置 */
            //var settings = InitializeSettings();
            //context.Set<SettingItem>().AddRange(settings);


            base.Seed(context);
        }

    }
}
