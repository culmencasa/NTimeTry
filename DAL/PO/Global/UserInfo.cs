using NTT.Interfaces.PO;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT.PO.Global
{
    [Table("Users")]
    [Export(typeof(IUser)), PartCreationPolicy(CreationPolicy.Shared)]
    public class UserInfo : BaseEntity, IUser
    {
        public string Name { get; set; }
        public bool AutoSignIn { get; set; }
        public string BusinessId { get; set; }


        public virtual AccountInfo Account { get; set; }
    }
}
