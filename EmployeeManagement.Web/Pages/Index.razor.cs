using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.JSInterop.Implementation;

namespace EmployeeManagement.Web.Pages
{
    public partial class Index
    {
        //[Inject]
        //public IEmployeeService EmployeeService { get; set; }

        //public IEnumerable<Employee> Employees { get; set; }

        private IJSObjectReference module;

        protected override async Task OnInitializedAsync()
        {
            //if (Employees.IsNullOrEmpty())
            //{
            //    Employees = (await EmployeeService.GetAll()).ToList();
            //}
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                module = await jsRuntime.InvokeAsync<IJSObjectReference>("import", new[] { "/js/app/employees.js" });
                await module.InvokeVoidAsync("init");
            }
        }
    }
}