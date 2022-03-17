using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using PETAS.Classes;

namespace PETAS.Services
{
    public interface ISecureAccessService
    {
        Task Login(User model);
    }

    public class SecureAccessService: ISecureAccessService
    {
        private readonly HttpClient http;
        private readonly SecureAccessClient secureAccessClient;
        public SecureAccessService(SecureAccessClient _secureAccessClient)
        {
            secureAccessClient = _secureAccessClient;
            http = secureAccessClient.http;
        }

        private const string APPLICATION_NAME = "ETAS";
        private List<string> applicationParts
        {
            get
            {
                return new List<string>
                {
                    "student",
                    "admin"
                };
            }
        }
        private List<string> appPermissions
        {
            get
            {
                return new List<string>
                {
                    "create",
                    "read",
                    "update",
                    "delete"
                };
            }
        }

        public async Task Login(User model)
        {
            try
            {
                model.AppPartList = applicationParts;
                model.PermissionTypes = appPermissions;
                model.AppName = APPLICATION_NAME;

                var posted = await http.PostAsJsonAsync("users/login", model);
                var result = await posted.Content.ReadFromJsonAsync<ApiResponse>();

                if (result.Status)
                {

                }
                //var result = await _httpHelper.Post<ApiResponse>($"users/login", model);
            }
            catch (Exception ex)
            {
                string error = $"error: {ex.Message}";
            }
            


        }

    }
}
