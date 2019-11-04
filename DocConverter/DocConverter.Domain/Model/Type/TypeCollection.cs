using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using DocConverter.Domain.Model.Contract;

namespace DocConverter.Domain.Model.Type
{
    /// <summary>
    /// Type collection
    /// </summary>
    [Table(name: "t_TypeCollections")]
    public class TypeCollection : Entity
    {
        /// <summary>
        /// Unique code of collection
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Description of collection
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Name of collection
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Collection of types
        /// </summary>
        public virtual ICollection<TypeValue> Types { get; set; }
    }
}
