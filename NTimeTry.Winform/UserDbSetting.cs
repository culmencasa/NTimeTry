using NTT.Interfaces.Database;
using NTT.Interfaces.PO;
using System;
using System.ComponentModel.Composition;
using System.IO;

namespace NTT.Business
{
    [Export(typeof(IUserDbSetting)), PartCreationPolicy(CreationPolicy.Shared)]
    public class UserDbSetting : IUserDbSetting
    {
        public string UserBusinessId { get; set; }
        public string DbDir { get; set; }
        public string DbName { get; set; }

        [ImportingConstructor]
        public UserDbSetting([Import(typeof(IUser), AllowRecomposition = false, Source = ImportSource.Any, RequiredCreationPolicy = CreationPolicy.Shared)]IUser userEntity)
        {
            UserBusinessId = userEntity.BusinessId;
            DbDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Users", UserBusinessId);
            DbName = "user.db";
        }

        /// <summary>
        /// 根据指定的教师Id, 给出相应的数据文件夹路径
        /// </summary>
        /// <param name="teacherBusinessId"></param>
        /// <returns></returns>
        public string GetFullDbPath()
        {
            if (!Directory.Exists(DbDir))
            {
                Directory.CreateDirectory(DbDir);
            }

            return Path.Combine(DbDir, DbName);
        }
    }
}
