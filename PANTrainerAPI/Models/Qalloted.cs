﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using PETAS.Models.Domain;

namespace PANTrainerAPI.Models
{
    [Table("QAlloted")]
    public partial class Qalloted
    {
        /// <summary>
        /// primary key
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Id of the training programme
        /// </summary>
        [Column("TrainingID")]
        public int? TrainingId { get; set; }
        /// <summary>
        /// the particular assessment under the training programme
        /// </summary>
        [Column("TrainingAssessmentID")]
        public int? TrainingAssessmentId { get; set; }
        /// <summary>
        /// the type of questions. foreign key to the dbo.QuestionTypeLookup table entity
        /// </summary>
        [Column("QuestionTypeID")]
        public int? QuestionTypeId { get; set; }
        /// <summary>
        /// the number of questions alloted
        /// </summary>
        public int? Alloted { get; set; }

        [ForeignKey(nameof(QuestionTypeId))]
        [InverseProperty("Qalloteds")]
        public virtual QuestionType QuestionType { get; set; }
        [ForeignKey(nameof(TrainingAssessmentId))]
        [InverseProperty("Qalloteds")]
        public virtual TrainingAssessment TrainingAssessment { get; set; }
    }
}