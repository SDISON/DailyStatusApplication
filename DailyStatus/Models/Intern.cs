using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DailyStatus.Models
{
    public class Intern
    {
        [Key]
        public string Email { get; set; }

        public string Name { get; set; }

        public string Mentor { get; set; }

        [Display(Name="Joining Date")]
        public string JoiningDate { get; set; }

        public string Group { get; set; }
        

    }
}