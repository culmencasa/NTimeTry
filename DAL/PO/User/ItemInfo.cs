
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT.PO.User
{
    [Table("Items")]
    public class ItemInfo : BaseEntityWithNotify
    {
        public string Name { get; set; }        

        public decimal Rate { get; set; }

        public decimal Total { get; set; } = 100;

        public decimal Progress { get; set; } = 0;

        public DateTime ReviewTime { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime FinishTime { get; set; }

        public string Remarks { get; set; }


        public int CategoryId { get; set; }


        /// <summary>
        /// 产品类别
        /// </summary>
        public virtual CategoryInfo Category { get; set; }
    }
}
