using EW.Unisystems.Data.Repositories;

namespace EW.Unisystems.Services.Services
{
    public class CareerService
    {
        private CareerRepository _careerRepository;

        public CareerService()
        {
            _careerRepository = new CareerRepository();
        }
    }
}
