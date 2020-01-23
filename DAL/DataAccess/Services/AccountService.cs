using NTT.PO.Global;
using NTT.DataAccess.ServiceBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Utils;
using System.Data.Entity;
using NTT.DataAccess.DataContexts;

namespace NTT.DataAccess.Services
{
    public class AccountService : DbServiceImpl
    {

        private GlobalDbContext globalDbContext;

        private int status = 0;
        public void Init()
        {
            globalDbContext = new GlobalDbContext();

            // 预加载
            Task.Run(() =>
            {
                globalDbContext.Accounts.Load(); 
                status = 1; 
            });
        }

        public void Release()
        {
            globalDbContext?.Dispose();
        }

        public UserInfo GetUser(string userName, string password)
        {
            var t1 = Environment.TickCount;
            UserInfo entity = null;

            while (status == 0) {
                continue;
            }

            if (status == 1)
            {
                entity = globalDbContext.Accounts.Where(p => p.UserName == userName && p.Password == password)
                                .Include(p => p.User)
                                .AsNoTracking()
                                .FirstOrDefault()?.User;

            }
            var t2 = Environment.TickCount; 

            Console.WriteLine("t2 - t1: " + (t2 - t1).ToString());
            return entity;
        }

        public AccountInfo SelectById(int id)
        {
            AccountInfo entity = null;
            UsingGlobalDb((context) => {
                entity = context.Accounts.Find(id); 
            });

            return entity;
        }

    }
}
