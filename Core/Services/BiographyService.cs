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
    public class BiographyService: IBiographyService
    {

        private readonly IRepositoryManager _repositoryManager;
        public BiographyService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public void Delete(int id)
        {
            _repositoryManager.repositoryBiography.Delete(id);
        }

        public IEnumerable<BiographyDto> GetAll()
        {
            var biography = _repositoryManager.repositoryBiography.GetAll();
            var biographyDto = biography.Adapt<IEnumerable<BiographyDto>>();
            return biographyDto;
        }

        public BiographyDto GetById(int id)
        {
            if (id == 0)
                return null;

            var biography = _repositoryManager.repositoryBiography.GetById(id);
            return biography.Adapt<BiographyDto>();
        }

        public void Insert(BiographyDto entity)
        {
            var biography = entity.Adapt<Biography>();
            _repositoryManager.repositoryBiography.Insert(biography);
            _repositoryManager.UnitOfWork.SaveChanges();

        }

        public void Update(int id)
        {
            _repositoryManager.repositoryBiography.Update(id);
            _repositoryManager.UnitOfWork.SaveChanges();
        }
    }
}
