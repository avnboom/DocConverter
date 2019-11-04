using DocConverter.Domain.Model.Contract;
using DocConverter.Domain.Model.Filtering;
using DocConverter.Domain.ViewModel.Contract;

namespace DocConverter.Services.Contract
{
    public interface IService<T> where T : IEntity
    {
        ITableView Get(IServiceFilter filter);

        IDetailView Get(int id);

        IDetailView Update(int id);

        void Delete(int id);

        void Update(IDetailView template);
    }
}
