using System.Web.Mvc;

namespace EW.Unisystems.UI.Controllers
{
    public class ActivityController : Controller
    {

        public JsonResult GetEventsList()
        {
            return Json(string.Empty, JsonRequestBehavior.AllowGet);
        }
    }
}