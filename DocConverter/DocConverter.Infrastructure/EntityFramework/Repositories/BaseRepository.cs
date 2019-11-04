using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DocConverter.Domain.Model.Contract;
using DocConverter.Infrastructure.EntityFramework.Repositories.Contract;
using DocConverter.Infrastructure.EntityFramework.UnitOfWork.Contract;
using Microsoft.EntityFrameworkCore;

namespace DocConverter.Infrastructure.EntityFramework.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly IUnitOfWork _unitOfWork;

        private DbContext _context => _unitOfWork.Context;

        public BaseRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }

        public void Add(T entity)
        {
            _context.Set<T>().Attach(entity);;
        }

        public void Delete(T entity)
        {
            T existing = _context.Set<T>().Find(entity);
            if (existing != null) _context.Set<T>().Remove(existing);
        }

        public void Delete(int id)
        {
            T existing = _context.Set<T>().Find(id);
            if (existing != null) _context.Set<T>().Remove(existing);
        }

        public IEnumerable<T> Get()
        {
            return _context.Set<T>().AsEnumerable<T>();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate).AsEnumerable<T>();
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.Set<T>().Attach(entity);
        }
    }
}
