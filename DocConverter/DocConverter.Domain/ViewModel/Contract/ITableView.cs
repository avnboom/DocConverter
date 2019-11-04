using System.Collections.Generic;
using DocConverter.Domain.Model.Contract;

namespace DocConverter.Domain.ViewModel.Contract
{
    public interface ITableView
    {
        IEnumerable<IListView> Items { get; set; }

        IPageInfo PageInfo { get; set; }
    }
}
