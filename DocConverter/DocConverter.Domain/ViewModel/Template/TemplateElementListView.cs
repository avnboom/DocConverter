using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DocConverter.Domain.ViewModel.Template
{
    public class TemplateElementListView
    {
        [Required]
        public int Id { get; set; }

        [MaxLength(64)]
        public string Code { get; set; }

        public IEnumerable<TemplateElementListView> Childs { get; set; } = new List<TemplateElementListView>();
    }
}
