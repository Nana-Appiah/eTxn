﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PETAS.Models.Domain
{
    public partial class Training
    {
        public Training()
        {
            TrainingAssessments = new HashSet<TrainingAssessment>();
            TrainingResources = new HashSet<TrainingResource>();
        }

        /// <summary>
        /// primary key
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// the name of the training
        /// </summary>
        [StringLength(50)]
        [Unicode(false)]
        public string TrainingName { get; set; }
        /// <summary>
        /// effective training date
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? DateFrom { get; set; }
        /// <summary>
        /// effective training end date
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? DateTo { get; set; }
        /// <summary>
        /// foreign key to dbo.TrainingType
        /// </summary>
        public int? TrainingType { get; set; }
        /// <summary>
        /// the status of the training programme. foreign key to dbo.TrainingStatusLookup
        /// </summary>
        [Column("TrainingStatusID")]
        public int? TrainingStatusId { get; set; }
        /// <summary>
        /// the group of staff/human resource for which the training was designed
        /// </summary>
        [Column("TrainingGroupID")]
        public int? TrainingGroupId { get; set; }
        /// <summary>
        /// certification to be rewarded after training. foreign key to dbo.TrainingCertification
        /// </summary>
        [Column("TrainingCertificationID")]
        public int? TrainingCertificationId { get; set; }
        /// <summary>
        /// Pass mark for the training. Training may consists of several assessments. In that case, it is the sum of all the marks gotten from each assessment
        /// </summary>
        public int? MarkToPass { get; set; }
        /// <summary>
        /// the date the training was created
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// the name of the inputter creating the training
        /// </summary>
        [Column("CreatedBy")]
        public string CreatedBy { get; set; }
        /// <summary>
        /// the name of the authorizer approving the training
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? AuthorizedDate { get; set; }
        [Column("AuthorizedBy")]
        public string AuthorizedBy { get; set; }
        [Column(TypeName = "date")]
        public DateTime? LastUpdatedDate { get; set; }
        [Column("LastUpdatedBy")]
        public string LastUpdatedBy { get; set; }

        [ForeignKey(nameof(TrainingCertificationId))]
        [InverseProperty("Training")]
        public virtual TrainingCertification TrainingCertification { get; set; }
        [ForeignKey(nameof(TrainingGroupId))]
        [InverseProperty(nameof(TrainingGrouping.Training))]
        public virtual TrainingGrouping TrainingGroup { get; set; }
        [ForeignKey(nameof(TrainingStatusId))]
        [InverseProperty(nameof(TrainingStatusType.Training))]
        public virtual TrainingStatusType TrainingStatus { get; set; }
        [ForeignKey(nameof(TrainingType))]
        [InverseProperty("Training")]
        public virtual TrainingType TrainingTypeNavigation { get; set; }
        [InverseProperty(nameof(TrainingAssessment.Training))]
        public virtual ICollection<TrainingAssessment> TrainingAssessments { get; set; }
        [InverseProperty(nameof(TrainingResource.Training))]
        public virtual ICollection<TrainingResource> TrainingResources { get; set; }


        [InverseProperty(nameof(AssignedTraining.TrainingId))]
        public virtual ICollection<AssignedTraining> AssignedTrainings { get; set; }
    }
}