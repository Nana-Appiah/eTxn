﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PETAS.Models.Domain
{
    [Table("AssignedTraining")]
    public partial class AssignedTraining
    {
        /// <summary>
        /// the Id for the table entity
        /// </summary>
        [Key]
        [Column("AssignedTrainingID")]
        public int AssignedTrainingId { get; set; }
        [Column("EmployeeID")]
        public int? EmployeeId { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string FirstName { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string LastName { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string EmailAddress { get; set; }
        /// <summary>
        /// the ID of the scheduled training
        /// </summary>
        [Column("TrainingID")]
        public int? TrainingId { get; set; }
        /// <summary>
        /// the one doing the assignment
        /// </summary>
        [StringLength(50)]
        [Unicode(false)]
        public string AssignedBy { get; set; }
        /// <summary>
        /// the assigned date
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? AssignedDate { get; set; }
        /// <summary>
        /// the one doing the approval of the training
        /// </summary>
        [StringLength(50)]
        [Unicode(false)]
        public string ApprovedBy { get; set; }
        /// <summary>
        /// the date of approval
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? ApprovedDate { get; set; }
    }
}