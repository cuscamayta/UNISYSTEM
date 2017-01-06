using EW.Unisystems.Common.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using EW.Unisystems.Services.Services;

namespace EW.Unisystems.UI.Controllers
{
    public class FileController : Controller
    {

        private ResourceService _resourceService;
        public FileController()
        {
            _resourceService = new ResourceService();
        }

        private string GetImageFilename(string path)
        {
            var index = path.LastIndexOf('\\');
            return index == -1 ? path : path.Substring(index + 1, path.Length - (index + 1));
        }
        
        private byte[] GetImageFromSession(string imageId)
        {
            var images = Session["images"] as List<ImageDTO>;
            var currentImage = images.Where(x => x.IdImage == imageId).FirstOrDefault();
            byte[] documentBytes = new byte[currentImage.Image.Length];
            currentImage.Image.Read(documentBytes, 0, documentBytes.Length);
            return documentBytes;
        }

        [HttpPost]
        public ContentResult UploadFile()
        {
            var file = Request.Files[0];
            if (file == null) return null;
            string fileName = GetImageFilename(file.FileName);
            var imageId = SaveImageInSession(file);
            return new ContentResult
            {
                ContentType = "text/plain",
                Content = imageId,
                ContentEncoding = Encoding.UTF8
            };
        }

        private string SaveImageInSession(HttpPostedFileBase file)
        {

            if (Session["images"] == null)
                Session["images"] = new List<ImageDTO>();
            var images = Session["images"] as List<ImageDTO>;
            var newImage = new ImageDTO() { IdImage = Guid.NewGuid().ToString(), Name = file.FileName, Image = file.InputStream };
            images.Add(newImage);
            Session["images"] = images;
            return newImage.IdImage;
        }

        //private bool SaveUploadFile(Stream fileStream, string name, string description)
        //{
        //    bool handled = false;

        //    try
        //    {
        //        byte[] documentBytes = new byte[fileStream.Length];
        //        fileStream.Read(documentBytes, 0, documentBytes.Length);

        //        var document = new ImageGalleryDTO<byte[]>
        //        {
        //            Image = documentBytes,

        //            DateUpload = DateTime.Now,
        //            Description = description,
        //            ActivityId = 1
        //        };

        //        ImageGalleryService.SaveImage(document);
        //    }
        //    catch (Exception ex)
        //    {
        //        // Oops, something went wrong, handle the exception
        //    }

        //    return handled;
        //}
    }
}