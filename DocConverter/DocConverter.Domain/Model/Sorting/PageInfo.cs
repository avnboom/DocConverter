using DocConverter.Domain.Model.Contract;

namespace DocConverter.Domain.Model.Sorting
{
    public class PageInfo : IPageInfo
    {
        public int CurrentPage { get; set; }

        public int PageSize { get; set; }
    }
}
