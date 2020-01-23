using NTT.PO.Global;
using NTT.DataAccess.ServiceBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Utils;
using System.Data.Entity;

namespace NTT.DataAccess.Services
{
    public class AccountService : DbServiceImpl
    {
        public AccountInfo IsValid(string userName, string password)
        {
            AccountInfo entity = null;
            UsingGlobalDb((context) => {
                
                entity = context.Accounts.Where(p => p.UserName == userName && p.Password == password)
                .Include(p=>p.User)
                .FirstOrDefault();
            });

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
