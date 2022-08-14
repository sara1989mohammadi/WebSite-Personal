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
    public class CVService: ICVService
    {
        private readonly IRepositoryManager _repositoryManager;
        public CVService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public void Delete(int id)
        {
            _repositoryManager.repositoryCV.Delete(id);
        }

        public IEnumerable<CVDto> GetAll()
        {
            var cv = _repositoryManager.repositoryCV.GetAll();
            var cvDto = cv.Adapt<IEnumerable<CVDto>>();
            return cvDto;
        }

        public CVDto GetById(int id)
        {
            if (id == 0)
                return null;

            var cv = _repositoryManager.repositoryCV.GetById(id);
            return cv.Adapt<CVDto>();
        }

        public void Insert(CVDto entity)
        {
            var cv = entity.Adapt<CV>();
            _repositoryManager.repositoryCV.Insert(cv);
            _repositoryManager.UnitOfWork.SaveChanges();

        }

        public void Update(int id)
        {
            _repositoryManager.repositoryCV.Update(id);
            _repositoryManager.UnitOfWork.SaveChanges();
        }
    }
}

