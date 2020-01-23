using NTT.PO.User;
using NTT.DataAccess.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT.DataAccess.Services
{
    public class ItemService : UserDbServiceImpl
    {
        public ItemInfo Insert(ItemInfo entity)
        {
            ItemInfo result = null;
            UsingUserDb((context) =>
            {
                result = context.Items.Add(entity);

                context.SaveChanges();
            });

            return result;
        }

        public IList<ItemInfo> SelectByCategoryId(int id)
        {
            IList<ItemInfo> list = null;
            UsingUserDb((context) =>
            {
                list = context.Items.Where(p => p.CategoryId == id).ToList();
            });

            return list;
        }
    }
}
