using System.Collections.Generic;
using DocConverter.Domain.Model.Contract;

namespace DocConverter.Domain.Model.Filtering
{
    public interface IServiceFilter
    {
        IPageInfo PageInfo { get; set; }

        IEnumerable<int> Ids { get; set; }
    }
}
