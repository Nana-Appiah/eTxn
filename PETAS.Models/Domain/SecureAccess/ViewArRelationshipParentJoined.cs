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
    public partial class ViewArRelationshipParentJoined
    {
        [Column("RelationshipID")]
        public int RelationshipId { get; set; }
        [Column("RelationshipTypeID")]
        public int RelationshipTypeId { get; set; }
        [Column("ParentObjectID")]
        public int ParentObjectId { get; set; }
        [Column("ChildObjectID")]
        public int ChildObjectId { get; set; }
        public bool DenyAccess { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RelationshipValidFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RelationshipValidTo { get; set; }
        [StringLength(255)]
        public string RelationshipTypeName { get; set; }
        [StringLength(255)]
        public string RelationshipTypeNamespace { get; set; }
        [StringLength(255)]
        public string RelationshiptypeAlias { get; set; }
        [StringLength(255)]
        public string RelationshipTypeDescription { get; set; }
        public bool? Inherit { get; set; }
        [StringLength(255)]
        public string ChildObjectName { get; set; }
        [StringLength(255)]
        public string ParentObjectName { get; set; }
        [StringLength(255)]
        public string ChildObjectAlias { get; set; }
        [StringLength(255)]
        public string ParentObjectAlias { get; set; }
        [StringLength(255)]
        public string ChildObjectDescription { get; set; }
        [StringLength(255)]
        public string ParentObjectDescription { get; set; }
        [StringLength(255)]
        public string ChildObjectTypeNamespace { get; set; }
        [StringLength(255)]
        public string ChildObjectTypeAlias { get; set; }
        [StringLength(255)]
        public string ParentObjectTypeNamespace { get; set; }
        [StringLength(255)]
        public string ParentObjectTypeAlias { get; set; }
        [Column("ChildObjectTypeID")]
        public int? ChildObjectTypeId { get; set; }
        [Column("ParentObjectTypeID")]
        public int? ParentObjectTypeId { get; set; }
        [Required]
        [StringLength(1)]
        [Unicode(false)]
        public string IsChildLocked { get; set; }
        [Required]
        [StringLength(1)]
        [Unicode(false)]
        public string IsParentLocked { get; set; }
        [Column("ObjectID")]
        public int? ObjectId { get; set; }
        [StringLength(255)]
        public string ObjectName { get; set; }
        [StringLength(255)]
        public string ObjectAlias { get; set; }
        [StringLength(255)]
        public string ObjectDescription { get; set; }
        [Column("ObjectTypeID")]
        public int? ObjectTypeId { get; set; }
        [StringLength(255)]
        public string ObjectCustomField1 { get; set; }
        public Guid? ObjectCustomField2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ObjectValidFrom { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ObjectValidTo { get; set; }
        [StringLength(255)]
        public string ObjectTypeNamespace { get; set; }
        [StringLength(255)]
        public string ObjectTypeAlias { get; set; }
        [Column("OwnerID")]
        public int? OwnerId { get; set; }
    }
}