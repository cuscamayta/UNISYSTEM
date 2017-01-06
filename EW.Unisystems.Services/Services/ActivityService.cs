using System.Collections.Generic;
using System.Linq;
using EW.Unisystems.Data.Repositories;
using EW.Unisystems.Common.DTOS;

namespace EW.Unisystems.Services.Services
{
    public class ActivityService
    {
        private ActivityRepository _activityRepository;

        public ActivityService()
        {
            _activityRepository = new ActivityRepository();
        }

        public List<EventDTO> GetActivities()
        {
            var activities = _activityRepository.GetAll().Select(x => new EventDTO() {EventId=x.IdActivity,DateEvent=x.DateActivity,Location=x.Description,SubTitle=x.Title }).ToList();
            return activities;
        }
    }
}