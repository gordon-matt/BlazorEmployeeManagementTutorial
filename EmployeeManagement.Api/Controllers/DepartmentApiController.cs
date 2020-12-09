using EmployeeManagement.Data.Domain;
using Extenso.AspNetCore.OData;
using Extenso.Data.Entity;

namespace DepartmentManagement.Api.Controllers
{
    public class DepartmentApiController : GenericODataController<Department, int>
    {
        public DepartmentApiController(IRepository<Department> repository)
            : base(repository)
        {
        }

        protected override int GetId(Department entity)
        {
            return entity.Id;
        }

        protected override void SetNewId(Department entity)
        {
        }
    }
}