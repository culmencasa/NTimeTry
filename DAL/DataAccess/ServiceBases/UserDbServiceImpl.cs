using NTT.DataAccess.DataContexts;
using NTT.Interfaces.Database;
using System;
using System.ComponentModel.Composition;

namespace NTT.DataAccess.Services
{
    public class UserDbServiceImpl : IUserDbService
    {
        public bool PartsRequired { get; } = true;


        [Import(typeof(IUserDbSetting))]
        public IUserDbSetting UserDbSetting { get; set; }

        /// <summary>
        /// 执行会话数据相关操作
        /// </summary>
        /// <param name="action"></param>
        public void UsingDb(Action<IDbContext> action)
        {
            using (var context = new UserDbContext(UserDbSetting))
            {
                action(context);
            }
        }


        public void UsingUserDb(Action<UserDbContext> action)
        {
            using (var context = new UserDbContext(UserDbSetting))
            {
                action(context);
            }
        }
    }
}
