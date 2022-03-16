﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PANTrainerAPI.Models
{
    [Table("TrainingCertification")]
    public partial class TrainingCertification
    {
        public TrainingCertification()
        {
            Training = new HashSet<Training>();
        }

        [Key]
        public int Id { get; set; }
        /// <summary>
        /// the name of the certification
        /// </summary>
        [StringLength(100)]
        [Unicode(false)]
        public string CertificationName { get; set; }
        /// <summary>
        /// the Id of the institution AWARDING the certificate
        /// </summary>
        [Column("CertificationAwardedID")]
        public int? CertificationAwardedId { get; set; }
        /// <summary>
        /// year of certification
        /// </summary>
        public int? CertifiedYear { get; set; }
        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string CreatedBy { get; set; }

        [ForeignKey(nameof(CertificationAwardedId))]
        [InverseProperty(nameof(CertificationAwarder.TrainingCertifications))]
        public virtual CertificationAwarder CertificationAwarded { get; set; }
        [InverseProperty("TrainingCertification")]
        public virtual ICollection<Training> Training { get; set; }
    }
}