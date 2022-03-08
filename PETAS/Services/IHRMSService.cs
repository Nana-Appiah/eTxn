using Microsoft.Extensions.Http;
namespace PETAS.Services
{
    public interface IHRMSService
    {
        public Task<string> GetBaseURL();
    }

    public class HRMSService: IHRMSService
    {
        private readonly HttpClient http;

        public HRMSService(HttpClient _httpClient)
        {
            http = _httpClient;
        }

        public async Task<string> GetBaseURL()
        {
            return http.BaseAddress.ToString();
        }
    }

}
