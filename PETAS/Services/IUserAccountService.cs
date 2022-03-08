using Microsoft.AspNetCore.Components;
using PETAS.Classes;
using System.Net;
using System.Net.Http.Json;

using PETAS.Models.Domain.SecureAccess;
using Blazored.LocalStorage;

namespace PETAS.Services
{
    public interface IUserAccountService
    {
        Task<bool> Login(User LoginInformation, string connString);
        Task<bool> Logout();
        Task Initialize();
        Task<ArUser> getSecureAccessUserObject(User o, string enc);
    }

    public class UserAccountService
        : IUserAccountService
    {
        private readonly HttpClient http;
        private ILocalStorageService localStore;

        public UserAccountService(HttpClient _httpclient, ILocalStorageService _localS)
        {
            http = _httpclient;
            localStore = _localS;
        }

        public async Task<bool> Login(User LoginInformation, string connString)
        {
            //encrypt provided password
            if (LoginInformation == null)
            {
                return false;
            }

            if (connString == null)
            {
                return false;
            }

            try
            {
                var res = await http.GetAsync("api/security/gethashedpassword?password=" + LoginInformation.userPassword);
                var str = await res.Content.ReadAsStringAsync();

                if(str.Length > 0)
                {
                    var p = await getSecureAccessUserObject(LoginInformation, str);
                    if (p != null)
                    {
                        LoginInformation.emailAddress = p.EmailAddress;
                        LoginInformation.passwordExpires = p.PasswordExpires;
                    
                        return true;
                    }
                    else { return false; }
                }
                else { return false; }
            }
            catch (Exception)
            {
                return false;
            }  
        }

        public async Task<bool> Logout()
        {
            //task handling the logging out of a user. remove all local storage
            await localStore.ClearAsync();
            return true;
        }
        public async Task<ArUser> getSecureAccessUserObject(User o, string enc)
        {
            var apiformulator = string.Format("api/secureaccess/getuserRecord?usrname={0}&pwd={1}", o.userName, enc);
            //var apiformulator = string.Format("api/secureaccess/userExist?usrname={0}&pwd={1}", o.userName, enc);

            //gets the secure access user details from the API
            return await http.GetFromJsonAsync<ArUser>(apiformulator);
            //return await http.GetFromJsonAsync<bool>(apiformulator);
        }
        
        public Task Initialize()
        {
            return Task.CompletedTask;
        }
    }
}
