using NTT.PO.User;
using NTT.Interfaces.Database;
using System;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite.EF6;

namespace NTT.DataAccess.DataContexts
{
    /// <summary>
    /// 表示用户数据库的上下文
    /// </summary>
    public class UserDbContext : DbContext, IDbContext
    {
        #region 属性

        /// <summary>
        /// UserDbSetting包含UserDbContext所需的参数
        /// </summary>
        public static IUserDbSetting UserDbSetting { get; set; }

        #endregion

        #region 字段

        /// <summary>
        /// 保存连接字符串
        /// </summary>
        private string _connectionString = string.Empty;

        #endregion

        #region 数据集合

        public DbSet<CategoryInfo> Categories { get; set; }

        public DbSet<ItemInfo> Items { get; set; }

        #endregion

        #region 构造

        /// <summary>
        /// 构造DbContext(自定义连接字符串)
        /// </summary>
        /// <param name="teacherBusinessId"></param>
        public UserDbContext(IUserDbSetting dbSetting) : base(CreateDbConnection(dbSetting), false)
        {
            var dbConnection = CreateDbConnection(dbSetting);
            _connectionString = dbConnection.ConnectionString;
            //this.Configuration.LazyLoadingEnabled = false; 
        }


        #endregion

        #region 重写的实现

        /// <summary>
        /// 重写建模
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<DrawingBinder>();
            //modelBuilder.Entity<DrawingPage>();




            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.AddFromAssembly(typeof(UserDbContext).Assembly);

            // 如果没有数据库, 创建并建表
            Database.SetInitializer(new UserDbInitializer(modelBuilder));

            //modelBuilder.Entity<ItemInfo>()
            //   .HasRequired(s => s.Category)//Student有必需的导航属性Grade,这会创建一个not null的外键
            //   .WithMany(g => g.ChildItems)//Grade实体有集合导航属性Student
            //   .HasForeignKey(s => s.CategoryId);//设置外键（如果Student中属性不遵循约定我们自己指定外键，如HasForeignKey(s=>s.GradeKey)）


            //var init = new SqliteCreateDatabaseIfNotExists<GlobalDbContext>(modelBuilder);
            //Database.SetInitializer(init);
        }

        #endregion


        #region 静态方法

        /// <summary>
        /// 动态创建连接
        /// </summary>
        /// <param name="teacherBusinessId"></param>
        /// <returns></returns>
        public static DbConnection CreateDbConnection(IUserDbSetting dbSetting)
        {
            if (dbSetting == null)
                throw new NullReferenceException("未提供有效的数据库配置.");

            string teacherDbFilePath = dbSetting.GetFullDbPath();

            DbConnection connection = SQLiteProviderFactory.Instance.CreateConnection();
            connection.ConnectionString = $"Data Source={teacherDbFilePath}";

            return connection;
        }

        #endregion

    }
}
