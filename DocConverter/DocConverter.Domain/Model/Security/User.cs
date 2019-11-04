using System;
using System.ComponentModel.DataAnnotations.Schema;
using DocConverter.Domain.Model.Contract;

namespace DocConverter.Domain.Model.Security
{
    /// <summary>
    /// User of system
    /// </summary>
    [Table(name: "t_Users")]
    public class User : BusinessEntity
    {
        public string Login { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public override void Update(BusinessEntity updateFrom)
        {
            throw new NotImplementedException();
        }
    }
}
