using System.Collections.Generic;
using DocConverter.Domain.Model.Contract;
using DocConverter.Domain.ViewModel.Contract;

namespace DocConverter.Domain.ViewModel
{
    public class TableView : ITableView
    {
        public IEnumerable<IListView> Items { get; set; }
        public IPageInfo PageInfo { get; set; }
    }
}
