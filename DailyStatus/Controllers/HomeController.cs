using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DailyStatus.ViewModels;
using DailyStatus.Models;
using DailyStatus.CustomSort;
using System.Data.Entity;

namespace DailyStatus.Controllers
{
    public class HomeController : Controller
    {
        private readonly ContextFile DbContext;

        public HomeController()
        {
            DbContext = new ContextFile();
        }

        [Route("")]
        public ActionResult Index(string StatusFlag)
        {
            if (Session["Email"] == null)
                return RedirectToAction("Index", "Login");

            ViewBag.Session = Session["Email"].ToString().Split('@')[0];

            string UserEmail = Session["Email"].ToString();
            Intern intern = DbContext.intern.Where(m => m.Email.CompareTo(UserEmail) == 0).ToList()[0];

            var TodaysDate = DateTime.Now.ToShortDateString();
            var DataList = DbContext.status.Where(m => m.InternEmail.CompareTo(UserEmail) == 0 && m.Date.CompareTo(TodaysDate) == 0).ToList();
            var status = new Status();
            if (DataList.Count != 0)
                status = DataList[0];

            Form obj = new Form
            {
                FormIntern = intern,
                FormStatus = status
            };

            ViewBag.Status = StatusFlag;

            return View(obj);
        }

        [Route("YourList")]
        public ActionResult YourList()
        {
            if (Session["Email"] == null)
                return RedirectToAction("Index", "Login");
            ViewBag.Session = Session["Email"].ToString().Split('@')[0];
            string UserEmail = Session["Email"].ToString();
            List<Status> DataList = DbContext.status.Where(m=>m.InternEmail.CompareTo(UserEmail) == 0).ToList();
            Intern intern = DbContext.intern.SingleOrDefault(m=>m.Email.CompareTo(UserEmail) == 0);
            var obj = new StatusList
            {
                Intern = intern,
                Statuses = DataList
            };
            obj.Statuses = obj.Statuses.Take(Convert.ToInt32(10)).ToList();
            ViewBag.From = obj.Intern.JoiningDate;
            ViewBag.To = DateTime.Now.ToShortDateString();
            ViewBag.length = obj.Statuses.Count;
            return View(obj);
        }

        [Route("YourList/{from}/{to}/{length}")]
        public ActionResult YourList(string from, string to, string length)
        {
            if (Session["Email"] == null)
                return RedirectToAction("Index", "Login");
            ViewBag.Session = Session["Email"].ToString().Split('@')[0];
            string UserEmail = Session["Email"].ToString();
            List<Status> DataList = DbContext.status.Where(m => m.InternEmail.CompareTo(UserEmail) == 0).ToList();
            Intern intern = DbContext.intern.SingleOrDefault(m => m.Email.CompareTo(UserEmail) == 0);
            var obj = new StatusList
            {
                Intern = intern,
                Statuses = DataList
            };
            obj = Data.YourList(obj, from, to);
            obj.Statuses = obj.Statuses.Take(Convert.ToInt32(length)).ToList();
            ViewBag.From = from;
            ViewBag.To = to;
            ViewBag.length = obj.Statuses.Count;
            return View(obj);
        }

        [Route("OtherInterns")]
        public ActionResult OtherInterns()
        {
            if (Session["Email"] == null)
                return RedirectToAction("Index", "Login");
            ViewBag.Session = Session["Email"].ToString().Split('@')[0];
            var interns = DbContext.intern.ToList();
            var obj = new OtherInterns
            {
                Interns = interns
            };
           
            Dictionary<string, int> mp = new Dictionary<string, int>();
            obj.Mentors = new List<string>();
            obj.Mentors.Add("All");
            foreach (var intern in obj.Interns)
            {
                if (!mp.ContainsKey(intern.Mentor))
                {
                    obj.Mentors.Add(intern.Mentor);
                    mp.Add(intern.Mentor, 1);
                }
            }
            mp = new Dictionary<string, int>();
            obj.Groups = new List<string>();
            obj.Groups.Add("All");
            foreach (var intern in obj.Interns)
            {
                if (!mp.ContainsKey(intern.Group))
                {
                    obj.Groups.Add(intern.Group);
                    mp.Add(intern.Group, 1);
                }
            }
            ViewBag.Mentor = "All";
            ViewBag.Group = "All";
            ViewBag.Sort = false;
            return View(obj);
        }

        [Route("OtherInterns/{mentor}/{group}/{sort}")]
        public ActionResult OtherInterns(string mentor, string group, bool sort)
        {
            if (Session["Email"] == null)
                return RedirectToAction("Index", "Login");
            ViewBag.Session = Session["Email"].ToString().Split('@')[0];
            var interns = DbContext.intern.ToList();
            var obj = new OtherInterns
            {
                Interns = interns
            };
           
            Dictionary<string, int> mp = new Dictionary<string, int>();
            obj.Mentors = new List<string>();
            obj.Mentors.Add("All");
            foreach (var intern in obj.Interns)
            {
                if (!mp.ContainsKey(intern.Mentor))
                {
                    obj.Mentors.Add(intern.Mentor);
                    mp.Add(intern.Mentor, 1);
                }
            }
            mp = new Dictionary<string, int>();
            obj.Groups = new List<string>();
            obj.Groups.Add("All");
            foreach (var intern in obj.Interns)
            {
                if (!mp.ContainsKey(intern.Group))
                {
                    obj.Groups.Add(intern.Group);
                    mp.Add(intern.Group, 1);
                }
            }
            obj = Data.OtherIntern(obj, mentor, group);
            obj = Data.OtherIntern(obj, sort);
            ViewBag.Mentor = mentor;
            ViewBag.Group = group;
            ViewBag.Sort = true;
            return View(obj);
        }

        public ActionResult ViewIntern(string Email)
        {
            if (Session["Email"] == null)
                return RedirectToAction("Index", "Login");
            ViewBag.Session = Session["Email"].ToString().Split('@')[0];
            List<Status> DataList = DbContext.status.Where(m => m.InternEmail.CompareTo(Email) == 0).ToList();
            Intern intern = DbContext.intern.Where(m => m.Email.CompareTo(Email) == 0).ToList()[0];
            var obj = new StatusList
            {
                Intern = intern,
                Statuses = DataList
            };
            obj.Statuses = obj.Statuses.Take(Convert.ToInt32(10)).ToList();
            ViewBag.From = obj.Intern.JoiningDate;
            ViewBag.To = DateTime.Now.ToShortDateString();
            ViewBag.length = obj.Statuses.Count;
            return View("YourList", obj);
        }

        [HttpPost]
        public ActionResult SaveStatus(Form form)
        {
            var UserEmail = Session["Email"].ToString();
            if (!ModelState.IsValid)
            {
                var ViewForm = new Form
                {
                    FormStatus = form.FormStatus,
                    FormIntern = form.FormIntern
                };
                return View("Index", ViewForm);
            }
            try
            {
                var TodaysDate = DateTime.Now.ToShortDateString();
                var DataList = DbContext.status.Where(m => m.InternEmail.CompareTo(UserEmail) == 0 && m.Date.CompareTo(TodaysDate) == 0).ToList();
                var status = new Status();
                int flag = 0;
                if (DataList.Count != 0)
                {
                    flag = 1;
                    status = DataList[0];
                }
                status.InternEmail = form.FormIntern.Email;
                status.Date = form.FormStatus.Date;
                status.TaskDone = form.FormStatus.TaskDone;
                status.TaskForTomorrow = form.FormStatus.TaskForTomorrow;
                status.DifficultyFaced = form.FormStatus.DifficultyFaced;

                if (flag == 0)
                    DbContext.status.Add(status);
                DbContext.SaveChanges();
                return RedirectToAction("Index", "Home", new { StatusFlag = 1});
            }
            catch (Exception)
            {
                ViewBag.Status = 2;
                var ViewForm = new Form
                {
                    FormStatus = form.FormStatus,
                    FormIntern = form.FormIntern
                };
                return View("Index", ViewForm);
            }
        }
    }
}