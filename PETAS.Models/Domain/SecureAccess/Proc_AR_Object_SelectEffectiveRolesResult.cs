﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PETAS.Models.Domain.SecureAccess
{
    public partial class Proc_AR_Object_SelectEffectiveRolesResult
    {
        public int ParentObjectID { get; set; }
        public int ChildObjectID { get; set; }
        public DateTime? RelationshipValidFrom { get; set; }
        public DateTime? RelationshipValidTo { get; set; }
        public string ParentObjectAlias { get; set; }
        public int? ParentObjectTypeID { get; set; }
        public DateTime? ParentObjectValidFrom { get; set; }
        public DateTime? ParentObjectValidTo { get; set; }
        public string IsLocked { get; set; }
        public string ChildObjectAlias { get; set; }
        public int? ChildObjectTypeID { get; set; }
        public DateTime? ChildObjectValidFrom { get; set; }
        public DateTime? ChildObjectValidTo { get; set; }
    }
}
