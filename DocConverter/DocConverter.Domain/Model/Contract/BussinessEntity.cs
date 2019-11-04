using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DocConverter.Domain.Model.Contract
{    
    /// <summary>
    /// Bussiness entity, to load, update, save from client
    /// </summary>
    public abstract class BusinessEntity : Entity
    {
        protected BusinessEntity()
        {
            CreateAt = DateTime.Now;
            CreateBy = "User";
        }

        /// <summary>
        /// User login
        /// </summary>
        /// <value></value>
        [Column(name: "CreateBy")]
        [Required]
        public string CreateBy { get; set; }

        /// <summary>
        /// Create date
        /// </summary>
        /// <value></value>
        [Column(name: "CreateAt")]
        [Required]
        public DateTime CreateAt { get; set; }


        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="updateFrom">update from this element</param>
        public abstract void Update(BusinessEntity updateFrom);
    }
}
