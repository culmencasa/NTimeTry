using NTT.Interfaces.PO;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT
{

    public class Session
    {
        Session()
        {
        }


        static Session _current;
        public static Session Current
        {
            get
            {
                return _current;
            }
        }

        static Session()
        {
            _current = new Session();
            Factory.Satisfy(_current);
        }

        /// <summary>
        /// 当前登录的用户
        /// </summary>
        [Import(typeof(IUser))]
        public IUser User { get; set; }

    }
}
