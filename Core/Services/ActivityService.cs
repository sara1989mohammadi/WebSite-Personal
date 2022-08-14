using Contracts;
using Domain.Entities;
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
            _repositoryManager.repositoryActivity.Delete(id);
        }       

        public IEnumerable<ActivityDto> GetAll()
        {
            var activity = _repositoryManager.repositoryActivity.GetAll();
            var activityDto = activity.Adapt<IEnumerable<ActivityDto>>();
            return activityDto;
        }

        public ActivityDto GetById(int id)
        {
            if (id == 0)
                return null;

            var activity= _repositoryManager.repositoryActivity.GetById(id);
           return activity.Adapt<ActivityDto>();
        }

        public void Insert(ActivityDto entity)
        {
            var activity = entity.Adapt<Activity>();
            _repositoryManager.repositoryActivity.Insert(activity);
            _repositoryManager.UnitOfWork.SaveChanges();
           
        }

        public void Update(int id)
        {
          
            _repositoryManager.repositoryActivity.Update(id);
            _repositoryManager.UnitOfWork.SaveChanges();
        }
    }
}
