using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.DataSeed
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(c => c.Id);
            var employeeList = new List<Employee>();

            for (int i = 0; i < 100; i++)
            {
                employeeList.Add(new Employee() { AddedDate = DateTime.Now, Experience = FakeData.NumberData.GetNumber(1,30), Name = FakeData.NameData.GetFirstName(), Id = Guid.NewGuid(), Email = FakeData.NetworkData.GetEmail(), Surname = FakeData.NameData.GetSurname(), Title = FakeData.NetworkData.GetDomain(), UpdatedDate = null });
            }

            builder.HasData(employeeList.ToArray());
        }
    }
}