using System;
using System.Linq;
using System.Linq.Expressions;
using DocConverter.Domain.Model.Contract;
using DocConverter.Domain.Model.Filtering;
using DocConverter.Domain.Model.Sorting;
using DocConverter.Domain.ViewModel;
using DocConverter.Domain.ViewModel.Contract;
using DocConverter.Infrastructure.EntityFramework.Repositories.Contract;
using DocConverter.Infrastructure.EntityFramework.UnitOfWork.Contract;
using DocConverter.Services.Contract;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DocConverter.Services.Services
{
    public class BaseService<T> : IService<T> where T : class, IEntity
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IRepository<T> _repository;

        public BaseService(IUnitOfWork unitOfWork, IRepository<T> repository)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public ITableView Get(IServiceFilter filter)
        {
            Func<T, bool> func = entity => true;

            if (filter.Ids.Any())
            {
                func = entity => func(entity) && filter.Ids.Contains(entity.Id);
            }

            var entities = _repository.Get((T el) => func(el));

            if (filter.PageInfo != null)
            {
                entities = entities.Skip((filter.PageInfo.CurrentPage - 1) * filter.PageInfo.PageSize)
                    .Take(filter.PageInfo.PageSize);
            }

            // TODO
            return new TableView();
        }

        public IDetailView Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDetailView Update(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(IDetailView template)
        {
            throw new System.NotImplementedException();
        }
    }
}
