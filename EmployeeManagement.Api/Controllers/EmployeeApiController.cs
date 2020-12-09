using EmployeeManagement.Data.Domain;
using Extenso.AspNetCore.OData;
using Extenso.Data.Entity;

namespace EmployeeManagement.Api.Controllers
{
    public class EmployeeApiController : GenericODataController<Employee, int>
    {
        public EmployeeApiController(IRepository<Employee> repository)
            : base(repository)
        {
        }

        protected override int GetId(Employee entity)
        {
            return entity.Id;
        }

        protected override void SetNewId(Employee entity)
        {
        }
    }
}