using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week11.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET: /Store
        public String Index()
        {
            return "Hello from Store.Index()";
        }

        // GET: /Store/Browse
        public String Browse()
        {
            return "Hello from Store.Browse()";
        }

        // GET: /Store/Details
        public String Details(int id)
        {
            string message = "Store.Details, ID = " + id;
            return message;
        }
    }
}