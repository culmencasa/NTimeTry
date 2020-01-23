using NTT.PO.Global;
using NTT.Interfaces.Database;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace NTT.DataAccess.DataContexts
{
    /// <summary>
    /// 表示应用程序全局数据库上下文
    /// </summary>
    public class GlobalDbContext : DbContext, IDbContext
    {
        #region 数据集合

        public DbSet<AccountInfo> Accounts { get; set; }
        public DbSet<UserInfo> Users { get; set; }

        #endregion



        public GlobalDbContext() : base("globalDatabase")
        {
            //Accounts.Include(p => p.User);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<ActivityLog>();

            //modelBuilder.Entity<UserInfo>().HasKey(m => m.AccountId);
            //modelBuilder.Entity<UserInfo>().HasRequired(m => m.Account).WithOptional(n => n.User);

            //modelBuilder.Configurations.Add(new DAL.PO.Map.AccountInfoMap());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.AddFromAssembly(typeof(GlobalDbContext).Assembly);

            Database.SetInitializer(new GlobalDbInitializer(modelBuilder,true));




            //var init = new SqliteCreateDatabaseIfNotExists<GlobalDbContext>(modelBuilder);
            //Database.SetInitializer(init);
        }

    }


}
