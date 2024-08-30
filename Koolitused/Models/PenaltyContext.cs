using Koolitused.Controllers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Koolitused.Models
{
    public class PenaltyContext : DbContext
    {
        public DbSet<Penalty> Penalty { get; set; }
        public DbSet<AccountController> Users { get; set; }

        public System.Data.Entity.DbSet<Koolitused.Models.RegisterViewModel> RegisterViewModels { get; set; }
    }
}