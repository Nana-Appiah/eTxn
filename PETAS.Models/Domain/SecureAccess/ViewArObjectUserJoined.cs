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
    public partial class ViewArObjectUserJoined
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
        [StringLength(255)]
        public string Loginname { get; set; }
        [StringLength(255)]
        public string EmailAddress { get; set; }
        [StringLength(255)]
        public string Password { get; set; }
        [StringLength(10)]
        public string PasswordEncryption { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PasswordExpires { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string MiddleName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(100)]
        public string Office { get; set; }
        [StringLength(50)]
        public string PhoneOffice { get; set; }
        [StringLength(50)]
        public string PhoneHome { get; set; }
        [StringLength(50)]
        public string PhonePager { get; set; }
        [StringLength(50)]
        public string PhoneMobile { get; set; }
        [StringLength(50)]
        public string Fax { get; set; }
        [StringLength(100)]
        public string WebPage { get; set; }
        [StringLength(100)]
        public string Address1 { get; set; }
        [StringLength(100)]
        public string Address2 { get; set; }
        [StringLength(100)]
        public string Address3 { get; set; }
        [StringLength(100)]
        public string City { get; set; }
        [StringLength(100)]
        public string State { get; set; }
        [StringLength(50)]
        public string Zip { get; set; }
        [StringLength(100)]
        public string Country { get; set; }
        [StringLength(100)]
        public string ShippingAddress1 { get; set; }
        [StringLength(100)]
        public string ShippingAddress2 { get; set; }
        [StringLength(100)]
        public string ShippingAddress3 { get; set; }
        [StringLength(100)]
        public string ShippingCity { get; set; }
        [StringLength(100)]
        public string ShippingState { get; set; }
        [StringLength(50)]
        public string ShippingZip { get; set; }
        [StringLength(100)]
        public string ShippingCountry { get; set; }
        [StringLength(150)]
        public string OrgPosition { get; set; }
        [StringLength(150)]
        public string OrgDepartment { get; set; }
        [StringLength(150)]
        public string OrgCompanyName { get; set; }
        [Column(TypeName = "ntext")]
        public string OrgNotes { get; set; }
        [Column(TypeName = "ntext")]
        public string Notes { get; set; }
        public int? CustomField1 { get; set; }
        public double? CustomField2 { get; set; }
        [StringLength(10)]
        public string CustomField3 { get; set; }
        [StringLength(50)]
        public string CustomField4 { get; set; }
        [StringLength(100)]
        public string CustomField5 { get; set; }
        [StringLength(100)]
        public string CustomField6 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CustomField7 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CustomField8 { get; set; }
        public bool? CustomField9 { get; set; }
        public bool? CustomField10 { get; set; }
        [Column(TypeName = "ntext")]
        public string CustomField11 { get; set; }
        [Column(TypeName = "ntext")]
        public string CustomField12 { get; set; }
        [StringLength(50)]
        public string PhotoName { get; set; }
        [Column("OwnerID")]
        public int? OwnerId { get; set; }
    }
}