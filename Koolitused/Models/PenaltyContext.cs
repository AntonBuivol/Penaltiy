using Koolitused.Controllers;
using Microsoft.AspNet.Identity.EntityFramework;
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
        public DbSet<IdentityUser> Users { get; set; }

    }
}