using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DocConverter.Domain.Model.Contract;
using DocConverter.Infrastructure.EntityFramework.Context;

namespace DocConverter.Infrastructure.EntityFramework.Repositories.Contract
{
    /// <summary>
    /// Interface of Entity repository
    /// </summary>
    public interface IRepository<T> where T : class, IEntity
    {
        IEnumerable<T> Get();

        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);

        T Get(int id);

        void Add(T entity);

        void Delete(T entity);

        void Delete(int id);

        void Update(T entity);
    }
}
