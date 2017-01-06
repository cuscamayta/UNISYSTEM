using System;
using System.Collections.Generic;
using System.Linq;
using EW.Unisystems.Common;
using EW.Unisystems.Common.DTOS;
using EW.Unisystems.Data;
using EW.Unisystems.Data.Repositories;

namespace EW.Unisystems.Services.Services
{
    public class ResourceService
    {
        private ResourceRepository _resourceRepository;
        private CareerRepository _careerRepository;
        private TypeResourceRepository _typeResourceRepository;

        public ResourceService()
        {
            _resourceRepository = new ResourceRepository();
            _careerRepository = new CareerRepository();
            _typeResourceRepository = new TypeResourceRepository();
        }

        public bool SaveResource(ResourceDTO<string> resourceToSave)
        {
            try
            {
                var career = _careerRepository.GetMany(x => x.Name == resourceToSave.NameCareer);
                var typeresource = _typeResourceRepository.GetMany(x => x.TypeName == resourceToSave.NameTypeResource);

                if (career.FirstOrDefault() == null || !career.Any()) return false;
                if (typeresource.FirstOrDefault() == null || !typeresource.Any()) return false;
                var newResource = new Resource()
                {
                    Author = resourceToSave.Author,
                    IdCareer = career.FirstOrDefault().IdCareer,
                    Description = resourceToSave.Description,
                    Link = resourceToSave.ResourceLink,
                    Title = resourceToSave.Title,
                    TypeResource = typeresource.FirstOrDefault().IdResource,
                    ResourceImage = null
                };

                _resourceRepository.Add(newResource);
                _resourceRepository.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ResourceDTO<string>> GetReroucesByType(string nameType, string nameCareer)
        {
            try
            {
                var career = _careerRepository.GetMany(x => x.Name == nameCareer).ToList();
                var typeresource = _typeResourceRepository.GetMany(x => x.TypeName == nameType).ToList();

                if (typeresource.FirstOrDefault() == null || !typeresource.Any()) return new List<ResourceDTO<string>>();
                if (career.FirstOrDefault() == null || !career.Any()) return new List<ResourceDTO<string>>();

                var resources =
                    career.SelectMany(x => x.Resource.Where(z => z.TypeResource == typeresource.FirstOrDefault().IdResource)).ToList();

                return resources.Select(x => new ResourceDTO<string>()
                {
                    Author = x.Author,
                    Description = x.Description,
                    ResourceLink = x.Link,
                    ResourceId = x.IdResource,
                    Title = x.Title,
                    TypeResource = x.TypeResource

                }).ToList();
            }
            catch (Exception)
            {
                return new List<ResourceDTO<string>>();
            }
        }
    }
}