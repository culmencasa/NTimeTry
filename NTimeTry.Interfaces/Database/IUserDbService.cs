using System;

namespace NTT.Interfaces.Database
{

    public interface IUserDbService : IDbService
    {
        IUserDbSetting UserDbSetting { get; set; }


        void UsingDb(Action<IDbContext> action);
    }
}
