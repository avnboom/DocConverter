using DocConverter.Domain.Model.Contract;
using DocConverter.Domain.Model.Filtering;
using DocConverter.Domain.Model.Template;
using DocConverter.Domain.ViewModel.Contract;
using DocConverter.Infrastructure.EntityFramework.UnitOfWork.Contract;
using DocConverter.Services.Contract;

namespace DocConverter.Services.Services
{
    public class TemplateService : IService<Template>
    {
        protected IUnitOfWork UnitOfWork { get; set; }

        public ITableView Get(IPageInfo pageInfo)
        {
            throw new System.NotImplementedException();
        }

        public ITableView Get(IServiceFilter filter)
        {
            throw new System.NotImplementedException();
        }

        public IDetailView Get(int id)
        {
            throw new System.NotImplementedException();
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
