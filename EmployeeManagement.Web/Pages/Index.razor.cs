using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Data.Domain;
using EmployeeManagement.Web.Services;
using Extenso.Collections;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages
{
    public partial class Index
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            if (Employees.IsNullOrEmpty())
            {
                Employees = (await EmployeeService.GetAll()).ToList();
            }
        }

        //private async Task LoadEmployees()
        //{
        //    Employees = new List<Employee>
        //    {
        //        new Employee
        //        {
        //            Id = 1,
        //            FamilyName = "Hastings",
        //            GivenNames = "John",
        //            Gender = Gender.Male,
        //            DateOfBirth = new DateTime(1980, 10, 5),
        //            Email = "David@pragimtech.com",
        //            DepartmentId = 1,
        //            PhotoUri = "images/john.png"
        //        },
        //        new Employee
        //        {
        //            Id = 2,
        //            FamilyName = "Galloway",
        //            GivenNames = "Sam",
        //            Gender = Gender.Male,
        //            DateOfBirth = new DateTime(1981, 12, 22),
        //            Email = "Sam@pragimtech.com",
        //            DepartmentId = 2,
        //            PhotoUri = "images/sam.jpg"
        //        },
        //        new Employee
        //        {
        //            Id = 3,
        //            FamilyName = "Smith",
        //            GivenNames = "Mary",
        //            Gender = Gender.Female,
        //            DateOfBirth = new DateTime(1979, 11, 11),
        //            Email = "mary@pragimtech.com",
        //            DepartmentId = 1,
        //            PhotoUri = "images/mary.png"
        //        },
        //        new Employee
        //        {
        //            Id = 3,
        //            FamilyName = "Longway",
        //            GivenNames = "Sara",
        //            Gender = Gender.Female,
        //            DateOfBirth = new DateTime(1982, 9, 23),
        //            Email = "sara@pragimtech.com",
        //            DepartmentId = 3,
        //            PhotoUri = "images/sara.png"
        //        }
        //    };
        //}
    }
}