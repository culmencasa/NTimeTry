namespace NTT.Interfaces.Database
{
    /// <summary>
    /// 数据库服务接口
    /// </summary>
    public interface IDbService
    {
        /// <summary>
        /// 表示是否需要在运行时合成对象
        /// </summary>
        bool PartsRequired { get; }
    }
}
