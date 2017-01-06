using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EW.Unisystems.Common;
using EW.Unisystems.Common.DTOS;
using EW.Unisystems.Services.Services;

namespace EW.Unisystems.UI.Controllers
{
    public class ResourcesController : Controller
    {
        private ResourceService _resourceService;

        public ResourcesController()
        {
            _resourceService = new ResourceService();
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult SaveResource(ResourceDTO<string> resource)
        {
            var resourceForSave = new ResourceDTO<string>()
            {
                Author = resource.Author,
                Description = resource.Description,
                Image = null,
                ResourceLink = resource.ResourceLink,
                Title = resource.Title,
                NameCareer = resource.NameCareer,
                NameTypeResource = resource.NameTypeResource
            };

            var isSuccess = _resourceService.SaveResource(resourceForSave);
            return Json(new { IsSuccess = isSuccess, Data = resourceForSave }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetBooksByTypeAndCareer(string nameType, string nameCareer)
        {
            var list = _resourceService.GetReroucesByType(nameType, nameCareer);
            return Json(list, JsonRequestBehavior.AllowGet);

            //var booksList = new List<BookDTO<string>>()
            //{
            //    new BookDTO<string>() {BookId = 1,Image = "../../../Content/img/1.jpg",PathDownload = "",Resume = "Este libro nos induce a la lectura del antiguo testamento y sus significados escritos entre lineas",Title = "La sagrada escritura"},
            //    new BookDTO<string>() {BookId = 1,Image = "../../../Content/img/1.jpg",PathDownload = "",Resume = "Este libro nos induce a la lectura del antiguo testamento y sus significados escritos entre lineas",Title = "La sagrada escritura"},
            //    new BookDTO<string>() {BookId = 1,Image = "../../../Content/img/1.jpg",PathDownload = "",Resume = "Este libro nos induce a la lectura del antiguo testamento y sus significados escritos entre lineas",Title = "La sagrada escritura"},
            //    new BookDTO<string>() {BookId = 1,Image = "../../../Content/img/1.jpg",PathDownload = "",Resume = "Este libro nos induce a la lectura del antiguo testamento y sus significados escritos entre lineas",Title = "La sagrada escritura"},
            //    new BookDTO<string>() {BookId = 1,Image = "../../../Content/img/1.jpg",PathDownload = "",Resume = "Este libro nos induce a la lectura del antiguo testamento y sus significados escritos entre lineas",Title = "La sagrada escritura"}
            //};

            //return Json(booksList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetVideosByCareer(Career career)
        {
            var videosList = new List<VideoDTO<string>>()
            {
                new VideoDTO<string>(){Image = "../../../Content/bethlehem/demo/video.jpg",Author = "Jose Perez Misael",Resume = "Video explicativo de la renovacion espiritual en el siglo XXI , exhortando a la reflexion personal",Title = "Un mensaje de salvacion ",VideoId = 1},
                new VideoDTO<string>(){Image = "../../../Content/bethlehem/demo/video.jpg",Author = "Jose Perez Misael",Resume = "Video explicativo de la renovacion espiritual en el siglo XXI , exhortando a la reflexion personal",Title = "Un mensaje de salvacion ",VideoId = 1},
                new VideoDTO<string>(){Image = "../../../Content/bethlehem/demo/video.jpg",Author = "Jose Perez Misael",Resume = "Video explicativo de la renovacion espiritual en el siglo XXI , exhortando a la reflexion personal",Title = "Un mensaje de salvacion ",VideoId = 1},
                new VideoDTO<string>(){Image = "../../../Content/bethlehem/demo/video.jpg",Author = "Jose Perez Misael",Resume = "Video explicativo de la renovacion espiritual en el siglo XXI , exhortando a la reflexion personal",Title = "Un mensaje de salvacion ",VideoId = 1},
                new VideoDTO<string>(){Image = "../../../Content/bethlehem/demo/video.jpg",Author = "Jose Perez Misael",Resume = "Video explicativo de la renovacion espiritual en el siglo XXI , exhortando a la reflexion personal",Title = "Un mensaje de salvacion ",VideoId = 1},
                new VideoDTO<string>(){Image = "../../../Content/bethlehem/demo/video.jpg",Author = "Jose Perez Misael",Resume = "Video explicativo de la renovacion espiritual en el siglo XXI , exhortando a la reflexion personal",Title = "Un mensaje de salvacion ",VideoId = 1},
                new VideoDTO<string>(){Image = "../../../Content/bethlehem/demo/video.jpg",Author = "Jose Perez Misael",Resume = "Video explicativo de la renovacion espiritual en el siglo XXI , exhortando a la reflexion personal",Title = "Un mensaje de salvacion ",VideoId = 1},
                new VideoDTO<string>(){Image = "../../../Content/bethlehem/demo/video.jpg",Author = "Jose Perez Misael",Resume = "Video explicativo de la renovacion espiritual en el siglo XXI , exhortando a la reflexion personal",Title = "Un mensaje de salvacion ",VideoId = 1},
                new VideoDTO<string>(){Image = "../../../Content/bethlehem/demo/video.jpg",Author = "Jose Perez Misael",Resume = "Video explicativo de la renovacion espiritual en el siglo XXI , exhortando a la reflexion personal",Title = "Un mensaje de salvacion ",VideoId = 1}
            };

            return Json(videosList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetResources()
        {
            var listResources = new List<ResourceDTO<string>>()
            {
                new ResourceDTO<string>(){ResourceId = 1,Author = "Jose Landa ",Description = "Esta es un libro que trata la problematica de la tecnologia abocada en la educacion , influenciando todas las corrientes educativas dando un panorama mas abstracto de la sociedad",Title = "La tecnologia en el Siglo XXI",Image = "../../../Content/bethlehem/demo/shop/list/1.jpg"},
                new ResourceDTO<string>(){ResourceId = 1,Author = "Jose Landa ",Description = "Esta es un libro que trata la problematica de la tecnologia abocada en la educacion , influenciando todas las corrientes educativas dando un panorama mas abstracto de la sociedad",Title = "La tecnologia en el Siglo XXI",Image = "../../../Content/bethlehem/demo/shop/list/1.jpg"},
                new ResourceDTO<string>(){ResourceId = 1,Author = "Jose Landa ",Description = "Esta es un libro que trata la problematica de la tecnologia abocada en la educacion , influenciando todas las corrientes educativas dando un panorama mas abstracto de la sociedad",Title = "La tecnologia en el Siglo XXI",Image = "../../../Content/bethlehem/demo/shop/list/1.jpg"},
                new ResourceDTO<string>(){ResourceId = 1,Author = "Jose Landa ",Description = "Esta es un libro que trata la problematica de la tecnologia abocada en la educacion , influenciando todas las corrientes educativas dando un panorama mas abstracto de la sociedad",Title = "La tecnologia en el Siglo XXI",Image = "../../../Content/bethlehem/demo/shop/list/1.jpg"},
                new ResourceDTO<string>(){ResourceId = 1,Author = "Jose Landa ",Description = "Esta es un libro que trata la problematica de la tecnologia abocada en la educacion , influenciando todas las corrientes educativas dando un panorama mas abstracto de la sociedad",Title = "La tecnologia en el Siglo XXI",Image = "../../../Content/bethlehem/demo/shop/list/1.jpg"},
                new ResourceDTO<string>(){ResourceId = 1,Author = "Jose Landa ",Description = "Esta es un libro que trata la problematica de la tecnologia abocada en la educacion , influenciando todas las corrientes educativas dando un panorama mas abstracto de la sociedad",Title = "La tecnologia en el Siglo XXI",Image = "../../../Content/bethlehem/demo/shop/list/1.jpg"},
                new ResourceDTO<string>(){ResourceId = 1,Author = "Jose Landa ",Description = "Esta es un libro que trata la problematica de la tecnologia abocada en la educacion , influenciando todas las corrientes educativas dando un panorama mas abstracto de la sociedad",Title = "La tecnologia en el Siglo XXI",Image = "../../../Content/bethlehem/demo/shop/list/1.jpg"},
                new ResourceDTO<string>(){ResourceId = 1,Author = "Jose Landa ",Description = "Esta es un libro que trata la problematica de la tecnologia abocada en la educacion , influenciando todas las corrientes educativas dando un panorama mas abstracto de la sociedad",Title = "La tecnologia en el Siglo XXI",Image = "../../../Content/bethlehem/demo/shop/list/1.jpg"}
            };

            return Json(listResources, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetNews()
        {
            var listNews = new List<NewsDTO<string>>()
            {
                new NewsDTO<string>(){NewsId = 1,Title = "Conferencia Episcopal",Image = "",Author = "Padre Mateo",Resume = "Conferencia Episcopal para la novena de san cayetano",Content = "El dia sabado se reunieron los diferentes obispos para la gran celebracion de nuestro patrono san calixo.",DateRegister = DateTime.Now.Date},
                new NewsDTO<string>(){NewsId = 1,Title = "Conferencia Episcopal",Image = "",Author = "Padre Mateo",Resume = "Conferencia Episcopal para la novena de san cayetano",Content = "El dia sabado se reunieron los diferentes obispos para la gran celebracion de nuestro patrono san calixo.",DateRegister = DateTime.Now.Date},
                new NewsDTO<string>(){NewsId = 1,Title = "Conferencia Episcopal",Image = "",Author = "Padre Mateo",Resume = "Conferencia Episcopal para la novena de san cayetano",Content = "El dia sabado se reunieron los diferentes obispos para la gran celebracion de nuestro patrono san calixo.",DateRegister = DateTime.Now.Date},
                new NewsDTO<string>(){NewsId = 1,Title = "Conferencia Episcopal",Image = "",Author = "Padre Mateo",Resume = "Conferencia Episcopal para la novena de san cayetano",Content = "El dia sabado se reunieron los diferentes obispos para la gran celebracion de nuestro patrono san calixo.",DateRegister = DateTime.Now.Date},
                new NewsDTO<string>(){NewsId = 1,Title = "Conferencia Episcopal",Image = "",Author = "Padre Mateo",Resume = "Conferencia Episcopal para la novena de san cayetano",Content = "El dia sabado se reunieron los diferentes obispos para la gran celebracion de nuestro patrono san calixo.",DateRegister = DateTime.Now.Date},
                new NewsDTO<string>(){NewsId = 1,Title = "Conferencia Episcopal",Image = "",Author = "Padre Mateo",Resume = "Conferencia Episcopal para la novena de san cayetano",Content = "El dia sabado se reunieron los diferentes obispos para la gran celebracion de nuestro patrono san calixo.",DateRegister = DateTime.Now.Date},
                new NewsDTO<string>(){NewsId = 1,Title = "Conferencia Episcopal",Image = "",Author = "Padre Mateo",Resume = "Conferencia Episcopal para la novena de san cayetano",Content = "El dia sabado se reunieron los diferentes obispos para la gran celebracion de nuestro patrono san calixo.",DateRegister = DateTime.Now.Date},
                new NewsDTO<string>(){NewsId = 1,Title = "Conferencia Episcopal",Image = "",Author = "Padre Mateo",Resume = "Conferencia Episcopal para la novena de san cayetano",Content = "El dia sabado se reunieron los diferentes obispos para la gran celebracion de nuestro patrono san calixo.",DateRegister = DateTime.Now.Date}
            };

            return Json(listNews, JsonRequestBehavior.AllowGet);
        }
    }
}