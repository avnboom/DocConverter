using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocConverter.Domain.Model.Contract
{
    /// <summary>
    /// Db entities
    /// </summary>
    public abstract class Entity : IEntity
    {
        /// <summary>
        /// Internal entity Id
        /// </summary>
        /// <value></value>
        [Column(name: "Id")]
        [Required]
        [Key]
        public int Id { get; set; }
    }
}
