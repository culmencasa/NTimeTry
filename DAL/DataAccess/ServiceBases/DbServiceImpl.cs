using NTT.PO;
using NTT.DataAccess.DataContexts;
using NTT.Interfaces.Database; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NTT.DataAccess.ServiceBases
{

    /// <summary>
    /// 数据库Service基类
    /// </summary>
    public abstract class DbServiceImpl : IGlobalDbService
    {
        public bool PartsRequired { get; } = false;

        /// <summary>
        /// 执行全局数据相关操作
        /// </summary>
        /// <param name="action"></param>
        public void UsingDb(Action<IDbContext> action)
        {
            UsingGlobalDb(action);
        }

        protected virtual void UsingGlobalDb(Action<GlobalDbContext> action)
        {
            using (var context = new GlobalDbContext())
            {
                action(context);
            }
        }

        public virtual T Insert<T>(T entity) where T : BaseEntity
        {
            T result = null;
            UsingGlobalDb((dbContext) =>
            {
                result = dbContext.Set<T>().Add(entity);
            });

            return result;
        }


        public virtual bool SaveOrUpdate<T>(T entity, bool skipExist=false) where T : BaseEntity
        {
            bool result = false;

            UsingGlobalDb((dbContext) =>
            {
                T originalDbEntity = null;

                if (entity.Id <= 0)
                {
                    dbContext.Set<T>().Add(entity);
                }
                else
                {
                    if (!skipExist)
                    {
                        originalDbEntity = dbContext.Set<T>().FirstOrDefault(p => p.Id == entity.Id);
                        if (originalDbEntity != null)
                        {
                            Helper.CopyPropertiesTo(entity, originalDbEntity, ignoreProperties: "Id");
                        }
                    }

                }

                dbContext.SaveChanges();

                result = true;
            });

            return result;
        }



    }
}
