using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Diagnostics;
using System.Collections;
using PETAS.Models.Domain;

namespace PETAS.Services
{
    public interface ITrainingResourceService
    {
        public Task<List<TrainingResource>> GetTrainingResourcesAsync();
    }

    public class TrainingResourceService: ITrainingResourceService
    {
        private readonly HttpClient http;

        public TrainingResourceService(HttpClient _httpClient)
        {
            http = _httpClient;
        }

        public async Task<List<TrainingResource>> GetTrainingResourcesAsync()
        {
            return await http.GetFromJsonAsync<List<TrainingResource>>("api/TrainingResources");
        }

    }
}
