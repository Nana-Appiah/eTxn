﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PETAS.Models.Domain.SecureAccess
{
    [Keyless]
    public partial class ViewArRelationshipType
    {
        [Column("RelationshipTypeID")]
        public int RelationshipTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string RelationshipTypeName { get; set; }
        [Required]
        [StringLength(255)]
        public string RelationshipTypeAlias { get; set; }
        [Required]
        [StringLength(255)]
        public string RelationshipTypeNamespace { get; set; }
        [StringLength(255)]
        public string RelationshipTypeDescription { get; set; }
        public bool? Inherit { get; set; }
    }
}