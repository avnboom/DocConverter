using System;
using System.ComponentModel.DataAnnotations.Schema;
using DocConverter.Domain.Model.Contract;

namespace DocConverter.Domain.Model.Template
{
    /// <summary>
    /// Document template
    /// </summary>
    [Table(name: "t_Templates")]
    public class Template : BusinessEntity
    {
        /// <summary>
        /// Unique template code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Template name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Template version number
        /// </summary>
        public int VersionNumber { get; set; }

        /// <summary>
        /// Id of base element
        /// </summary>
        public int BaseElementId { get; set; }

        /// <summary>
        /// Base element of template
        /// </summary>
        public TemplateElement BaseElement { get; set; }

        public override void Update(BusinessEntity updateFrom)
        {
            //TODO Реализация функции
            throw new NotImplementedException();
        }
    }
}
