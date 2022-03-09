using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Diagnostics;
using PETAS.Models.Domain;

namespace PETAS.Services
{
    public interface ITrainingService
    {
        public Task<List<Training>> GetTrainingsAsync();

        public Task<bool> SaveTrainingAsync(Training obj, TrainingType ttype, TrainingGrouping tgroup, TrainingCertification tcert);
    }

    public class TrainingService: ITrainingService
    {
        private readonly HttpClient http;

        public TrainingService(HttpClient _httpClient)
        {
            http = _httpClient;
        }

        public async Task<bool> SaveTrainingAsync(Training obj, TrainingType ttype, TrainingGrouping tgroup, TrainingCertification tcert)
        {
            var postBody = new { ttype, tgroup, tcert, obj };
            var status = await http.PostAsJsonAsync("api/Trainings/PostTrainingRecord", postBody);
            return await status.Content.ReadFromJsonAsync<bool>();
        }

        public async Task<List<Training>> GetTrainingsAsync()
        {
            return await http.GetFromJsonAsync<List<Training>>("api/Trainings");
        }
    }

}
