using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Koolitused.Models
{
    public class Penalty
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "Must be 6 symbols")]
        [StringLength(6, ErrorMessage = "Must be 6 symbols", MinimumLength = 6)]
        public string CarNumber { get; set; }

        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public DateTime Date { get; set; }
        public int Speed{ get; set; }
        public int Summa { get; set; }
    }
}