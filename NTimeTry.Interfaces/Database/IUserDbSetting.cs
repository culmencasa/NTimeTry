namespace NTT.Interfaces.Database
{
    public interface IUserDbSetting
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        string UserBusinessId { get; set; }

        /// <summary>
        /// 数据库位置
        /// </summary>
        string DbDir { get; set; }

        /// <summary>
        /// 数据库文件名
        /// </summary>
        string DbName { get; set; }

        /// <summary>
        /// 获取完整数据库路径(包含文件名)
        /// </summary>
        /// <returns></returns>
        string GetFullDbPath();
    }
}
