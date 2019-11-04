namespace DocConverter.Domain.Model.Contract
{
    /// <summary>
    /// Db entities
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Internal id
        /// </summary>
        int Id { get; set; }
    }
}
