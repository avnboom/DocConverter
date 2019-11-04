using System;
using Microsoft.EntityFrameworkCore;

namespace DocConverter.Infrastructure.EntityFramework.UnitOfWork.Contract
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext Context { get; }

        void Commit();
    }
}
