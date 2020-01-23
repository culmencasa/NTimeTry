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

                datum = context.Categories.AsNoTracking().ToList();
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

        public bool Update(CategoryInfo entity)
        {
            bool result = false;
            UsingUserDb((context) => {
                var dbEntity = context.Categories.Find(entity.Id);
                Helper.CopyPropertiesTo(entity, dbEntity, "Id"); 
                context.SaveChanges(); 
                result = true;
            });

            return result;
        }
    }
}
