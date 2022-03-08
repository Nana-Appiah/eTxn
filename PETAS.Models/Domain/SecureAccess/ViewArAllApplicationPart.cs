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
    public partial class ViewArAllApplicationPart
    {
        [Column("ObjectID")]
        public int ObjectId { get; set; }
        [Required]
        [StringLength(255)]
        public string ObjectName { get; set; }
        [Required]
        [StringLength(255)]
        public string ObjectAlias { get; set; }
        [Column("ObjectTypeID")]
        public int ObjectTypeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ObjectValidFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ObjectValidTo { get; set; }
        [StringLength(255)]
        public string ObjectDescription { get; set; }
        [StringLength(255)]
        public string ObjectCustomField1 { get; set; }
        public Guid? ObjectCustomField2 { get; set; }
        [Required]
        [StringLength(1)]
        [Unicode(false)]
        public string IsLocked { get; set; }
        [StringLength(255)]
        public string ObjectTypeName { get; set; }
        [StringLength(255)]
        public string ObjectTypeAlias { get; set; }
        [StringLength(255)]
        public string ObjectTypeNamespace { get; set; }
        [Column("ApplicationID")]
        public int? ApplicationId { get; set; }
        [StringLength(255)]
        public string ApplicationAlias { get; set; }
        [StringLength(255)]
        public string ApplicationName { get; set; }
        [Column("OwnerID")]
        public int? OwnerId { get; set; }
        [Column("ParentObjectID")]
        public int? ParentObjectId { get; set; }
        [StringLength(255)]
        public string ParentObjectAlias { get; set; }
        [StringLength(255)]
        public string ParentObjectName { get; set; }
        [Column("ParentObjectTypeID")]
        public int? ParentObjectTypeId { get; set; }
    }
}