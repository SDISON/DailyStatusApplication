using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DailyStatus.Models;

namespace DailyStatus.ViewModels
{
    public class StatusList
    {
        public Intern Intern { get; set; }
        public List<Status> Statuses { get; set; }
    }
}