﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PETAS.Models.Domain.SecureAccess
{
    public partial class Proc_AR_LiveSession_SelectResult
    {
        public string HostName { get; set; }
        public string MachineName { get; set; }
        public string ApplicationName { get; set; }
        public string SessionID { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public string IsLocked { get; set; }
        public int? ObjectID { get; set; }
        public string ObjectName { get; set; }
        public string ObjectAlias { get; set; }
        public string UniqueName { get; set; }
        public int? ConcurrentUsers { get; set; }
        public int? ConcurrentHosts { get; set; }
    }
}
