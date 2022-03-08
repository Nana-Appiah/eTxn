﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PANTrainerAPI.Models
{
    [Table("CertificationAwarder")]
    public partial class CertificationAwarder
    {
        public CertificationAwarder()
        {
            TrainingCertifications = new HashSet<TrainingCertification>();
        }

        /// <summary>
        /// the Id of the awarder
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// the name of the awarder
        /// </summary>
        [Column("awarder")]
        [StringLength(200)]
        [Unicode(false)]
        public string Awarder { get; set; }

        [InverseProperty(nameof(TrainingCertification.CertificationAwarded))]
        public virtual ICollection<TrainingCertification> TrainingCertifications { get; set; }
    }
}