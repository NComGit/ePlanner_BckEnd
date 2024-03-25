using EPlannerDB.Interface;
using EPlannerDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EPLanner.Controllers
{
    public class HomeController : Controller
    {
        IRepository _Repo;

        ModelMapping _ModelMapping;

        public HomeController (IRepository Repo, ModelMapping ModelMapping)
        {
            _Repo = Repo;
            _ModelMapping = ModelMapping;
        }

        public ActionResult Index()
        {
            SelectLists ddlFilter = new SelectLists();
            ddlFilter.TodoItemsList = new SelectList((from a in _Repo.GetTodoItem()
                                                      select new
                                                      {
                                                          Value = a.id,
                                                          Text = a.title,
                                                      }).Distinct(), "Value", "Text");
  
            return View(ddlFilter);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}