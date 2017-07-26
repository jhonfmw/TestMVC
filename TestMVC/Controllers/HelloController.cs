using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public string Index()
        {
            return "Este es el Index";
        }

        //public string Welcome(string name, int numTimes = 0)
        //{
        //    return HttpUtility.HtmlEncode("nombre "+name+" numtimes "+numTimes);
        //}

        public string Welcome(string name, int ID=1)
        {
            return HttpUtility.HtmlEncode("nombre " + name + " numtimes " + ID);
        }
    }
}