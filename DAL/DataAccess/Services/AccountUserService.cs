using NTT.PO.Global;
using NTT.DataAccess.ServiceBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT.DataAccess.Services
{
    public class AccountUserService : DbServiceImpl
    {
        public bool AddAccountAndUser(AccountInfo account, UserInfo user)        
        {
            bool result = false;
            UsingGlobalDb((context) =>
            {
                account.User = user;
                user.Account = account;

                var a2 = context.Users.Add(user);
                var a1 = context.Accounts.Add(account);


                context.SaveChanges();

                result = true;
            });

            return result;
        }
    }
}
