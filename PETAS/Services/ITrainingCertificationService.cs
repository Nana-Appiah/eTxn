using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Diagnostics;
using PETAS.Models.Domain;

namespace PETAS.Services
{
    public interface ITrainingCertificationService
    {
        public Task<IEnumerable<TrainingCertification>> GetTrainingCertificatiosAsync();
    }

    public class TrainingCertificationService: ITrainingCertificationService
    {
        private readonly HttpClient http;
        public TrainingCertificationService(HttpClient _httpclient)
        {
            http = _httpclient;
        }

        public async Task<IEnumerable<TrainingCertification>> GetTrainingCertificatiosAsync()
        {
            return await http.GetFromJsonAsync<IEnumerable<TrainingCertification>>("api/TrainingCertifications");
        }

    }
}
