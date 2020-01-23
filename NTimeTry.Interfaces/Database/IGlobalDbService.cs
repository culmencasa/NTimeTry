using System;

namespace NTT.Interfaces.Database
{

    public interface IGlobalDbService : IDbService
    {
        void UsingDb(Action<IDbContext> action);
    }
}
