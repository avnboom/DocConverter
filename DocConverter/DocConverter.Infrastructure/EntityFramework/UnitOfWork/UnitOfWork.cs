using DocConverter.Infrastructure.EntityFramework.UnitOfWork.Contract;
using Microsoft.EntityFrameworkCore;

namespace DocConverter.Infrastructure.EntityFramework.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        public DbContext Context { get; }
        
        public UnitOfWork(DbContext context)
        {
            Context = context;
        }

        public async void CommitAsync()
        {
            await Context.SaveChangesAsync();
        }

        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
        
        public async void DisposeAsync()
        {
            await Context.DisposeAsync();
        }
    }
}
