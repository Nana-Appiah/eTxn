using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Diagnostics;
using PETAS.Classes;
using PETAS.Models.Domain;
using PETAS.Data.Data;

namespace PETAS.Services
{
    public interface IDragService
    {
        public Task<bool> AssignTrainingAsync(string source, Training t, object _Data);
    }

    public class DragService: IDragService
    {
        private readonly HttpClient http;
        public DragService(HttpClient _httpclient)
        {
            http = _httpclient;
        }

        public async Task<bool> AssignTrainingAsync(string source, Training t, object _Data)
        {
            HRMSContext _context = new HRMSContext();
            var obj = new DragHelper(_context) { 
                Source = source,
                Target = t,
                Data = _Data
            };

            var employeeData = await obj.GetTraineeList();

            //send the data to the api for mail sending
            return true;
        }
    }

}
