using DocConverter.Domain.Model.Security;
using DocConverter.Domain.Model.Template;
using DocConverter.Domain.Model.Type;
using Microsoft.EntityFrameworkCore;

namespace DocConverter.Infrastructure.EntityFramework.Context
{
    /// <summary>
    /// Db context of template app
    /// </summary>
    public class DocConverterContext : DbContext
    {
        public DocConverterContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>
        /// Templates
        /// </summary>
        public DbSet<Template> Templates { get; set; }

        /// <summary>
        /// TemplateElements
        /// </summary>
        public DbSet<TemplateElement> TemplateElements { get; set; }

        /// <summary>
        /// TypeCollections
        /// </summary>
        public DbSet<TypeCollection> TypeCollections { get; set; }

        /// <summary>
        /// TypeValues
        /// </summary>
        public DbSet<TypeValue> TypeValues { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
