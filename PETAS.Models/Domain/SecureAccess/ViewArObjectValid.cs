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
    public partial class ViewArObjectValid
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
        [Column("OwnerID")]
        public int? OwnerId { get; set; }
    }
}