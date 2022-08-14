using Contracts;
using Domain.Repositories;
using Mapster;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ActivityService : IActivityService
    {
        private readonly IRepositoryManager _repositoryManager;
        public ActivityService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ActivityDto FindById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ActivityDto>> GetAll()
        {
            var activities = await _repositoryManager.repositoryActivity.GetAll();
            var activitiesDto = activities.Adapt<IEnumerable<ActivityDto>>();
            return activitiesDto;
        }

        public ActivityDto GetById(int id)
        {
            var activity =  _repositoryManager.repositoryActivity.GetById(id);
            var activityDto = activity.Adapt<ActivityDto>();
            return activityDto;
        }

        public ActivityDto Insert(ActivityDto item)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
