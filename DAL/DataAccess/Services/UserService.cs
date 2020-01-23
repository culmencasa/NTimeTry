using NTT.PO;
using NTT.PO.Global;
using NTT.DataAccess.ServiceBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT.DataAccess.Services
{
    
    public class UserService : DbServiceImpl
    {
        public UserInfo Insert(UserInfo entity)
        {
            UserInfo result = null;

            UsingGlobalDb((context) =>
            {
                result = context.Users.Add(entity);
            });
    
            return result;
        }
    }
}
