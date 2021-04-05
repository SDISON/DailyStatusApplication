using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DailyStatus.Models;

namespace DailyStatus.ViewModels
{
    public class OtherInterns
    {
        public List<string> Mentors { get; set; }

        public List<string> Groups { get; set; }
        public List<Intern> Interns { get; set; }
    }
}