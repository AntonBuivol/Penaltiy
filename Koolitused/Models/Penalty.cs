using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Koolitused.Models
{
    public class Penalty
    {
        public int Id { get; set; }
        public int CarNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public int Speed{ get; set; }
        public int Summa { get; set; }
    }
}