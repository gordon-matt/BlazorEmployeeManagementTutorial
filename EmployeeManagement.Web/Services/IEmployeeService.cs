using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using EmployeeManagement.Data.Domain;

namespace EmployeeManagement.Web.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAll();
    }

    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    FamilyName = "Hastings",
                    GivenNames = "John",
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(1980, 10, 5),
                    Email = "David@pragimtech.com",
                    DepartmentId = 1,
                    PhotoUri = "images/john.png"
                },
                new Employee
                {
                    Id = 2,
                    FamilyName = "Galloway",
                    GivenNames = "Sam",
                    Gender = Gender.Male,
                    DateOfBirth = new DateTime(1981, 12, 22),
                    Email = "Sam@pragimtech.com",
                    DepartmentId = 2,
                    PhotoUri = "images/sam.jpg"
                },
                new Employee
                {
                    Id = 3,
                    FamilyName = "Smith",
                    GivenNames = "Mary",
                    Gender = Gender.Female,
                    DateOfBirth = new DateTime(1979, 11, 11),
                    Email = "mary@pragimtech.com",
                    DepartmentId = 1,
                    PhotoUri = "images/mary.png"
                },
                new Employee
                {
                    Id = 3,
                    FamilyName = "Longway",
                    GivenNames = "Sara",
                    Gender = Gender.Female,
                    DateOfBirth = new DateTime(1982, 9, 23),
                    Email = "sara@pragimtech.com",
                    DepartmentId = 3,
                    PhotoUri = "images/sara.png"
                }
            };

            //return await httpClient.GetFromJsonAsync<Employee[]>("http://localhost:56024/odata/EmployeeApi", null);
        }
    }
}