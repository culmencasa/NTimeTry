using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTT.PO
{

    /// <summary>
    /// PersistentObject
    /// </summary>
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }


        public DateTime CreateTime { get; set; } = DateTime.Now;
    }
}
