using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
 
    static class Helper
    {

        /// <summary>
        /// 复制源对象的属性到另一个对象
        /// </summary>
        /// <param name="source">源对象</param>
        /// <param name="destination">目标对象</param>
        public static void CopyPropertiesTo(this object source, object destination, params string[] ignoreProperties)
        {
            if (source == null || destination == null)
                throw new Exception("Source or/and Destination Objects are null");

            Type typeDest = destination.GetType();
            Type typeSrc = source.GetType();


            PropertyInfo[] srcProps = typeSrc.GetProperties();
            foreach (PropertyInfo srcProp in srcProps)
            {
                if (!srcProp.CanRead)
                {
                    continue;
                }

                if (ignoreProperties != null && ignoreProperties.Contains(srcProp.Name))
                {
                    continue;
                }

                PropertyInfo targetProperty = typeDest.GetProperty(srcProp.Name);
                if (targetProperty == null)
                {
                    continue;
                }
                if (!targetProperty.CanWrite)
                {
                    continue;
                }
                if (targetProperty.GetSetMethod(true) != null && targetProperty.GetSetMethod(true).IsPrivate)
                {
                    continue;
                }
                if ((targetProperty.GetSetMethod().Attributes & MethodAttributes.Static) != 0)
                {
                    continue;
                }
                if (!targetProperty.PropertyType.IsAssignableFrom(srcProp.PropertyType))
                {
                    continue;
                }

                targetProperty.SetValue(destination, srcProp.GetValue(source, null), null);
            }
        }
    }
 
