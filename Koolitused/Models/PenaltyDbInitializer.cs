using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Koolitused.Models
{
    public class PenaltyDbInitializer : DropCreateDatabaseAlways<PenaltyContext>
    {
        protected override void Seed(PenaltyContext db)
        {
            base.Seed(db);
        }
    }
}