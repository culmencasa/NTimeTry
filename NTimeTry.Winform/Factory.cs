using NTT.DataAccess.ServiceBases;
using NTT.Interfaces.Database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT
{
    public static class Factory
    {
        /// <summary>
        /// 用于缓存Service类
        /// </summary>
        static Hashtable controllerPool = new Hashtable();
        static CompositionContainer container;

        /// <summary>
        /// 获取业务类的单例
        /// </summary>
        /// <typeparam name="Service"></typeparam>
        /// <returns></returns>
        public static Service Entry<Service>() where Service : IDbService, new()
        {
            Service instance = default(Service);

            string key = typeof(Service).FullName;
            lock (controllerPool)
            {
                if (controllerPool.ContainsKey(key))
                {
                    instance = (Service)controllerPool[key];
                }
                else
                {
                    instance = new Service();
                    if ((instance as IDbService).PartsRequired)
                    {
                        Satisfy(instance);
                    }

                    controllerPool.Add(key, instance);
                }
            }

            return instance;
        }
        
        /// <summary>
        /// 统一导入点
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static CompositionContainer Satisfy(object target = null)
        {
            if (container == null)
            {
                DirectoryCatalog dirCatalog = new DirectoryCatalog(".");
                AssemblyCatalog assemblyCat = new AssemblyCatalog(System.Reflection.Assembly.GetExecutingAssembly());
                AggregateCatalog catalog = new AggregateCatalog(assemblyCat, dirCatalog);
                container = new CompositionContainer(catalog);
            }

            if (target != null)
            {
                container.SatisfyImportsOnce(target);
            }
            else
            {
                container.ComposeParts();
            }

            return container;
        }
    }
}
