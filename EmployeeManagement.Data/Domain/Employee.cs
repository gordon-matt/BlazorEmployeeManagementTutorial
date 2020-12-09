using System;
using Extenso.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagement.Data.Domain
{
    public class Employee : IEntity
    {
        public int Id { get; set; }

        public int DepartmentId { get; set; }

        public string FamilyName { get; set; }

        public string GivenNames { get; set; }

        public Gender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }

        public string PhotoUri { get; set; }

        #region IEntity Members

        public object[] KeyValues => new object[] { Id };

        #endregion IEntity Members

        public virtual Department Department { get; set; }
    }

    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DepartmentId).IsRequired();
            builder.Property(x => x.FamilyName).IsRequired().HasMaxLength(128);
            builder.Property(x => x.GivenNames).IsRequired().HasMaxLength(128);
            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.DateOfBirth).IsRequired().HasColumnType("date");
            builder.Property(x => x.Email).IsRequired().HasMaxLength(128);
            builder.Property(x => x.PhotoUri).IsRequired().HasMaxLength(255);
        }
    }
}