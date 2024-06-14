using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBlazor.Archipelago.WebServices
{
    public class UserSecurityService
    {
        private readonly HttpClient _httpClient;

        public UserSecurityService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task GetLogin()
        {
            await Task.Delay(1000);
            Console.WriteLine("User logged in successfully");
        }
    }
}
