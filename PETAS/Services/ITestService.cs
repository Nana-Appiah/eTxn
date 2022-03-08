using PETAS.Models.Domain.SecureAccess;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using PETAS.Classes;

namespace PETAS.Services
{
    public interface ITestService
    {
        Task<ArUser> getSecureAccessUserObject(User o, string enc);
    }

    public class TestService: ITestService
    {
        private readonly HttpClient http;

        public TestService(HttpClient _httpClient)
        {
            http = _httpClient;
        }
        public async Task<ArUser> getSecureAccessUserObject(User o, string enc)
        {
            var apiformulator = string.Format("api/secureaccess/getuserRecord?usrname={0}&pwd={1}", o.userName, enc);
            //var apiformulator = string.Format("api/secureaccess/userExist?usrname={0}&pwd={1}", o.userName, enc);

            //gets the secure access user details from the API
            return await http.GetFromJsonAsync<ArUser>(apiformulator);
            //return await http.GetFromJsonAsync<bool>(apiformulator);
        }
    }
}
