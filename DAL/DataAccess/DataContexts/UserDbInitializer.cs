using SQLite.CodeFirst;
using System.Data.Entity;

namespace NTT.DataAccess.DataContexts
{
    internal class UserDbInitializer : SqliteCreateDatabaseIfNotExists<UserDbContext>
    {
        public UserDbInitializer(DbModelBuilder modelBuilder) : base(modelBuilder)
        {
        }

        public UserDbInitializer(DbModelBuilder modelBuilder, bool nullByteFileMeansNotExisting) : base(modelBuilder, nullByteFileMeansNotExisting)
        {
        }

        public override void InitializeDatabase(UserDbContext context)
        {
            base.InitializeDatabase(context);
        }

        protected override void Seed(UserDbContext context)
        {
            //context.Set<Customer>().Add(new Customer { UserName = "user" + DateTime.Now.Ticks.ToString(), Roles = new List<Role> { new Role { RoleName = "user" } } });
            //context.Set<Post>().Add(new Post { Category = new Category() });

            base.Seed(context);
        }
    }
}
