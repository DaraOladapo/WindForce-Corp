using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        public async Task<List<Employee>> GetAllEmployeeDataAsync()
        {
         
            Employee employee = new Employee();
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("http://windforce-corp.azurewebsites.net/api/employees");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var response = await client.GetAsync(client.BaseAddress);

                    response.EnsureSuccessStatusCode();

                    var stringResult = await response.Content.ReadAsStringAsync();
                    allEmployeeData= JsonConvert.DeserializeObject<List<Employee>>(stringResult);



                }
                catch (HttpRequestException httpRequestException)
                {
                    var error = $"Error getting employee data: {httpRequestException.Message}";
                }
                return allEmployeeData;

            }
        }
    }
}
