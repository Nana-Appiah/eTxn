// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PETAS.Models.Domain.HRMS
{
    [Table("Department")]
    public partial class Department
    {
        [Key]
        [Column("DepartmentID")]
        public int DepartmentId { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        public int? Head { get; set; }
    }
}