using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PETAS.Data.Data;
using PETAS.Models.Domain.HRMS;

namespace HRMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly HRMSContext config;

        public EmployeesController(HRMSContext _context)
        {
            config = _context;
        }

        //GET api/Employees
        [HttpGet]
        public async Task<ActionResult<List<Employee>>> GetEmployees()
        {
            return await config.Employees.Where(x => x.StatusId == 1).ToListAsync();
        }


    }
}
