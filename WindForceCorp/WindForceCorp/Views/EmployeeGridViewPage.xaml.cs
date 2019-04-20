using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindForceCorp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WindForceCorp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeeGridViewPage : ContentPage
    {
        public EmployeeGridViewPage(List<Models.Employee> allEmployee)
        {
            InitializeComponent();
            //EmployeeCollection.ItemsSource = allEmployee;
        }

        private void EmployeeList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Employee employee = new Employee();
            employee = (Employee)e.Item;
            Navigation.PushAsync(new Views.EmployeeDetailsPage(employee));

        }
    }
}