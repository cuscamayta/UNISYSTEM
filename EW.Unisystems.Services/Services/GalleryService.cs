using EW.Unisystems.Data.Repositories;

namespace EW.Unisystems.Services.Services
{
    public class GalleryService
    {
        private GalleryRepository _galleryRepository;

        public GalleryService()
        {
            _galleryRepository= new GalleryRepository();
        }
    }
}