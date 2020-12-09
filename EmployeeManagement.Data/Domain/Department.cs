using Extenso.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagement.Data.Domain
{
    public class Department : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        #region IEntity Members

        public object[] KeyValues => new object[] { Id };

        #endregion IEntity Members
    }

    public class DepartmentMap : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(128);
        }
    }
}