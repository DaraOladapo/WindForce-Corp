using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WindForceCorp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeeDetailsPage : ContentPage
    {
        public EmployeeDetailsPage(Models.Employee employee)
        {
            InitializeComponent();
            AvatarURLBox.Source = employee.avatarUrl;
            FullNameBox.Text = employee.fullName;
            AddressBox.Text = employee.address;
            EmploymentDateBox.Text = $"{employee.employmentDate.Year.ToString()}/{employee.employmentDate.Month.ToString()}/{employee.employmentDate.Day.ToString()}";
            SalaryBox.Text = employee.salary.ToString();
        }
    }
}