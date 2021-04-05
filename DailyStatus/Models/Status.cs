using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DailyStatus.Models
{
    public class Status
    {
        public int StatusId { get; set; }
        [Display(Name = "Intern Email")]
        public string InternEmail { get; set; }
        public string Date { get; set; }
        [Display(Name = "Task Done")]
        [Required]
        public string TaskDone { get; set; }
        [Display(Name = "Task For Tomorrow")]
        [Required]
        public string TaskForTomorrow { get; set; }
        [Display(Name = "Difficulty Faced")]
        public string DifficultyFaced { get; set; }

    }
}