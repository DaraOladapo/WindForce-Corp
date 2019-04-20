using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public static List<Employee> allEmployeeData = new List<Employee>();

        public MainPage()
        {
            InitializeComponent();
            GetEmployeeData();

        }

        private async void GetEmployeeData()
        {
            allEmployeeData = (await EmployeeData.GetAllEmployeeDataAsync()).ToList();
        }

        private void EmployeeList_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.EmployeeListPage(allEmployeeData));
        }

        private void EmployeeGrid_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.EmployeeGridViewPage(allEmployeeData));
        }

        private void EmployeeRoles_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.EmployeeRolesPage(allEmployeeData));
        }

        private void EmployeeAuth_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.EmployeeAuthPage());
        }
    }
}
