using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindForceCorp.Models;
using WindForceCorp.ViewModels;
using Xamarin.Forms;

namespace WindForceCorp
{
    public partial class MainPage : ContentPage
    {
        EmployeeData employeeData = new EmployeeData();
        List<Employee> allEmployee=new List<Employee>();
        public MainPage()
        {
            InitializeComponent();
            GetEmployeeDataAsync();
            
        }

        private async void GetEmployeeDataAsync()
        {
            await employeeData.GetAllEmployeeDataAsync();
            ParseEmployeeData();
        }

        private void ParseEmployeeData()
        {
            foreach (var employee in employeeData.allEmployeeData)
            {
                allEmployee.Add(new Employee() { firstName = employee.firstName, lastName = employee.lastName, fullName=employee.fullName, address=employee.address, employmentDate=employee.employmentDate, salary=employee.salary, avatarUrl=employee.avatarUrl});
            }
        }

        private void EmployeeList_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.EmployeeListPage(allEmployee));
        }

        private void EmployeeGrid_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.EmployeeGridViewPage(allEmployee));
        }

        private void EmployeeRoles_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.EmployeeRolesPage(allEmployee));
        }

        private void EmployeeAuth_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.EmployeeAuthPage());
        }
    }
}
