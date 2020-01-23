using NTT.PO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT.DataAccess.Services
{
    public class CategoryService : UserDbServiceImpl
    {
        public List<CategoryInfo> FindAll()
        {
            List<CategoryInfo> datum = null;
            UsingUserDb((context) => {

                //var context

                datum = context.Categories.ToList();
            });

            return datum;
        }


        public CategoryInfo Insert(CategoryInfo info)
        {
            CategoryInfo result = null;

            UsingUserDb((context) =>
            {
                result = context.Categories.Add(info);

                context.SaveChanges();
            });

            return result;
        }
    }
}
