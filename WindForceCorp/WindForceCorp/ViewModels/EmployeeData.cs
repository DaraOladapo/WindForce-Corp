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
    public static class EmployeeData
    {
        
        public static async Task<IEnumerable<Employee>> GetAllEmployeeDataAsync()
        {

            Employee employee = new Employee();
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://my.api.mockaroo.com/windforceemployees.json?key=9a55a0e0");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var response = await client.GetAsync(client.BaseAddress);

                    response.EnsureSuccessStatusCode();

                    var stringResult = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<ObservableCollection<Employee>>(stringResult);



                }
                catch (HttpRequestException httpRequestException)
                {
                    var error = $"Error getting employee data: {httpRequestException.Message}";
                    return null;
                }

            }
        }
    }
}
