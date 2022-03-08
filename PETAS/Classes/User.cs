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

        
    }
}
