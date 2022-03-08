﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PETAS.Models.Domain.SecureAccess
{
    public partial class Proc_AR_User_SelectResult
    {
        public int ObjectID { get; set; }
        public string ObjectName { get; set; }
        public string ObjectAlias { get; set; }
        public int ObjectTypeID { get; set; }
        public DateTime ObjectValidFrom { get; set; }
        public DateTime? ObjectValidTo { get; set; }
        public string ObjectDescription { get; set; }
        public string ObjectCustomField1 { get; set; }
        public Guid? ObjectCustomField2 { get; set; }
        public string IsLocked { get; set; }
        public string ObjectTypeName { get; set; }
        public string ObjectTypeAlias { get; set; }
        public string ObjectTypeNamespace { get; set; }
        public string Loginname { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string PasswordEncryption { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Office { get; set; }
        public string PhoneOffice { get; set; }
        public string PhoneHome { get; set; }
        public string PhonePager { get; set; }
        public string PhoneMobile { get; set; }
        public string Fax { get; set; }
        public string WebPage { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string ShippingAddress1 { get; set; }
        public string ShippingAddress2 { get; set; }
        public string ShippingAddress3 { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
        public string ShippingZip { get; set; }
        public string ShippingCountry { get; set; }
        public string OrgPosition { get; set; }
        public string OrgDepartment { get; set; }
        public string OrgCompanyName { get; set; }
        public string OrgNotes { get; set; }
        public string Notes { get; set; }
        public int? CustomField1 { get; set; }
        public double? CustomField2 { get; set; }
        public string CustomField3 { get; set; }
        public string CustomField4 { get; set; }
        public string CustomField5 { get; set; }
        public string CustomField6 { get; set; }
        public DateTime? CustomField7 { get; set; }
        public DateTime? CustomField8 { get; set; }
        public bool? CustomField9 { get; set; }
        public bool? CustomField10 { get; set; }
        public string CustomField11 { get; set; }
        public string CustomField12 { get; set; }
        public DateTime? PasswordExpires { get; set; }
        public string PhotoName { get; set; }
        public string UniqueName { get; set; }
        public int? OwnerID { get; set; }
    }
}
