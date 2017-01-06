using EW.Unisystems.Common.DTOS;
using EW.Unisystems.Services.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EW.Unisystems.UI.Controllers
{
    public class NewsController : Controller
    {
        private NewsService _newsService;
        public NewsController()
        {
            _newsService = new NewsService();
        }

        public JsonResult GetListNews()
        {
            var listNews = _newsService.GetListNews();
            return Json(listNews, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SaveNews(NewsDTO<string> news)
        {
            var isSuccess = _newsService.SaveNews(news);
            return Json(new { IsSuccess = isSuccess, Data = news }, JsonRequestBehavior.AllowGet);
        }
    }
}