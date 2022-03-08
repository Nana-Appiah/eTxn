using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PANTrainerAPI.Data;
using PETAS.Models.Domain.SecureAccess;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PANTrainerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecureAccessController : ControllerBase
    {
        private SecureaccessContext config = new SecureaccessContext();

        // GET: api/<SecureAccessController>
        [HttpGet("getuserRecord")]
        public async Task<ActionResult<ArUser>> getUserInformation(string usrname, string pwd)
        {
            //pass in user name and password and get the ARUser object
            if (usrname == null || usrname == string.Empty)
            {
                return BadRequest();
            }

            if (pwd == null || pwd == string.Empty)
            {
                return BadRequest();
            }
            
            //return await config.ArUsers.SingleOrDefaultAsync(x => x.Loginname == usrname);
            return await config.ArUsers.Where(x => x.Loginname == usrname && x.Password == pwd).FirstOrDefaultAsync();
        }

        [HttpGet("userExist")]
        public async Task<bool> userExist(string usrname, string pwd)
        {
            return config.ArUsers.Any(e => e.Loginname == usrname && e.Password == pwd);
        }

        [HttpGet("validateLogin")]
        public async Task<int> ValidateLogin(string _encryptedPassword, string usr)
        {
            int value = 0;
            await config.GetProcedures().Proc_AR_AuthenticateAsync(usr, _encryptedPassword, value);

            return value;
        }

    }
}
