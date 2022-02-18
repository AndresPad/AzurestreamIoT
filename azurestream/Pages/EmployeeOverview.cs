using apa.BOL;
using azurestream.Services;
using Microsoft.AspNetCore.Components;

namespace azurestream.Pages
{
    public partial class EmployeeOverview
    {
        public IEnumerable<Employee> Employees { get; set; }

        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        //protected AddEmployeeDialog AddEmployeeDialog { get; set; }

        protected async Task OnInitializedAsync()
        {

            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();

           
        }

        protected void QuickAddEmployee()
        {
            //AddEmployeeDialog.Show();
        }

        public async void AddEmployeeDialog_OnDialogClose()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
            StateHasChanged();
        }
    }
}
