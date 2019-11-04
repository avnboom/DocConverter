namespace DocConverter.Domain.Model.Contract
{
    public interface IPageInfo
    {
        int CurrentPage { get; set; }

        int PageSize { get; set; }
    }
}
