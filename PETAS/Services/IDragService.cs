using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Diagnostics;

namespace PETAS.Services
{
    public interface IDragService
    {
        public Task<bool> AssignTrainingAsync();
    }

    public class DragService: IDragService
    {
        private readonly HttpClient http;
        public DragService(HttpClient _httpclient)
        {
            http = _httpclient;
        }

        public async Task<bool> AssignTrainingAsync()
        {
            return true;
        }
    }

}
