using System.ComponentModel.DataAnnotations;

using System;
using System.Data;
using System.Data.SqlClient;

namespace PETAS.Classes
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = @"User name is required")]
        [StringLength(20)]
        public string userName { get; set; } = string.Empty;

        [Required(ErrorMessage = @"Password required")]
        [StringLength(50)]
        public string userPassword { get; set; } = string.Empty;

        public string? emailAddress { get; set; }
        public DateTime? passwordExpires { get; set; }

        public string AppName { get; set; }
        public List<string> AppPartList { get; set; }
        public List<string> PermissionTypes { get; set; }

        public bool BuildMenu { get; set; }

        public User()
        {
            BuildMenu = false;
        }
    }

    public class ApiResponse
    {
        public bool Status { get; set; }
        public Object Entity { get; set; }
        public string Message { get; set; }
        public string ResponseCode { get; set; }
    }
}
