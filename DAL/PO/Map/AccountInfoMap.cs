using NTT.PO.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT.PO.Map
{
    public class AccountInfoMap : EntityTypeConfiguration<AccountInfo>
    {
        public AccountInfoMap()
        {
            //ToTable("tb_Person");
            //HasKey(x => x.Id);
            HasOptional(x => x.User)
                .WithOptionalPrincipal(x => x.Account).Map(x => x.MapKey("AccountId"));
            //ToTable("Account");
            //HasKey(p => p.Id);
            //Property(p => p.Id)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //HasOptional(p => p.Order).WithRequired(p => p.Member);

        }

    }
}
