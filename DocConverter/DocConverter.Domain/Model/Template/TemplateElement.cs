using System;
using System.ComponentModel.DataAnnotations.Schema;
using DocConverter.Domain.Model.Contract;

namespace DocConverter.Domain.Model.Template
{
    /// <summary>
    /// Element of template
    /// </summary>
    [Table(name: "t_TemplateElements")]
    public class TemplateElement : BusinessEntity
    {
        /// <summary>
        /// Element Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Id of type
        /// </summary>
        public string TypeId { get; set; }

        /// <summary>
        /// Element type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="updateFrom"></param>
        public override void Update(BusinessEntity updateFrom)
        {
            throw new NotImplementedException();
        }
    }
}
