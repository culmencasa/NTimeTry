using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT.PO.User
{
    [Table("Categories")]
    public class CategoryInfo : BaseEntityWithNotify
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;

                OnPropertyChanged(nameof(Name));
            }
        }

        public string ColorHex { get; set; }


        //public virtual ICollection<ItemInfo> ChildItems { get; set; }
    }
}
