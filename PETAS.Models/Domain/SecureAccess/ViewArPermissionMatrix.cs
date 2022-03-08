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
    public partial class ViewArPermissionMatrix
    {
        [Column("childobjectid")]
        public int Childobjectid { get; set; }
        [Column("RelationshipTypeID")]
        public int RelationshipTypeId { get; set; }
        [Column("ParentObjectID")]
        public int ParentObjectId { get; set; }
        [StringLength(255)]
        public string ChildObjectName { get; set; }
        [Required]
        [StringLength(255)]
        public string RelationshipTypeName { get; set; }
        [Required]
        [StringLength(255)]
        public string RelationshipTypeAlias { get; set; }
        [StringLength(13)]
        [Unicode(false)]
        public string Status { get; set; }
    }
}