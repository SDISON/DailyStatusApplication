using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DailyStatus.ViewModels;
using System.Globalization;
using DailyStatus.Models;

namespace DailyStatus.CustomSort
{
    public class Data
    {
        class ComparerObject : IComparer<Intern>
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            public int Compare(Intern x, Intern y)
            {
                DateTime date1 = DateTime.ParseExact(x.JoiningDate, "dd-MM-yyyy", provider);
                DateTime date2 = DateTime.ParseExact(y.JoiningDate, "dd-MM-yyyy", provider);

                return DateTime.Compare(date1, date2);
            }

        }
        public static StatusList YourList(StatusList obj, string from, string to)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            StatusList resultObj = new StatusList
            {
                Intern = obj.Intern,
                Statuses = new List<Status>()
            };
            foreach(var status in obj.Statuses)
            {
                DateTime date = DateTime.ParseExact(status.Date, "dd-MM-yyyy", provider);
                DateTime fromdate = DateTime.ParseExact(from, "dd-MM-yyyy", provider);
                DateTime todate = DateTime.ParseExact(to, "dd-MM-yyyy", provider);
                int result1 = DateTime.Compare(date, fromdate);
                int result2 = DateTime.Compare(todate, date);
                if (result1 >= 0 && result2 >= 0)
                    resultObj.Statuses.Add(status);
            }
            return resultObj;
        }

        public static OtherInterns OtherIntern(OtherInterns obj, string mentor, string group)
        {
            var resultObj = new OtherInterns
            {
                Interns = new List<Intern>(),
                Mentors = obj.Mentors,
                Groups = obj.Groups
            };
            foreach(var intern in obj.Interns)
            {
                if(string.Compare(mentor, "All") == 0 && string.Compare(group, intern.Group) == 0)
                    resultObj.Interns.Add(intern);
                else if (string.Compare(mentor, intern.Mentor) == 0 && string.Compare(group, "All") == 0)
                    resultObj.Interns.Add(intern);
                else if(string.Compare(mentor, "All") == 0 && string.Compare(group, "All") == 0)
                    resultObj.Interns.Add(intern);
                else if (string.Compare(mentor, intern.Mentor) == 0 && string.Compare(group, intern.Group) == 0)
                    resultObj.Interns.Add(intern);
            }
            return resultObj;
        }

        public static OtherInterns OtherIntern(OtherInterns obj, bool sort)
        {
            if (sort)
            {
                ComparerObject comp = new ComparerObject();
                obj.Interns.Sort(comp);
            }
            return obj;
        }
    }
}