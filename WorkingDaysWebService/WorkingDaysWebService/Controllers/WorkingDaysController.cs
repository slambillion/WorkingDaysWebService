using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkingDaysWebService.Controllers
{
    public class WorkingDaysController : Controller
    {
        public JsonResult Index(int month, int year)
        {
            Models.WorkingDaysService wds = new Models.WorkingDaysService();
            return Json(wds.GetWorkingDays(month, year), JsonRequestBehavior.AllowGet);
        }

    }
    
    public int TestForAutomaticBuild()
    {
        return 7;
    }
}