using System.ComponentModel.DataAnnotations.Schema;
using DocConverter.Domain.Model.Contract;

namespace DocConverter.Domain.Model.Type
{
    /// <summary>
    /// Consts in db
    /// </summary>
    [Table(name: "t_TypeValues")]
    public class TypeValue : Entity
    {
        /// <summary>
        /// unique code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Collection Id
        /// </summary>
        public int CollectionId { get; set; }

        /// <summary>
        /// Collection
        /// </summary>
        public TypeCollection Collection { get; set; }

        /// <summary>
        /// description type
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }

    }
}
