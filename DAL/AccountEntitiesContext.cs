using ActivityUpdate.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace ActivityUpdate.DAL
{
    public class AccountEntitiesContext: DbContext
    {
        public AccountEntitiesContext()
            : base("name=AccountEntities")
        {
        }

      

        public virtual DbSet<Litigation_Accounts> Litigation_Accounts { get; set; }
    }
}