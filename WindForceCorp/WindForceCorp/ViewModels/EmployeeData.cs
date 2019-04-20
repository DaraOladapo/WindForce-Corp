using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WindForceCorp.Models;

namespace WindForceCorp.ViewModels
{
    public class EmployeeData
    {
        public List<Employee> allEmployeeData = new List<Employee>();
        public async Task<ObservableCollection<Employee>> GetAllEmployeeDataAsync()
        {
            return new ObservableCollection<Employee>
            {

            };
        }
    }
}
