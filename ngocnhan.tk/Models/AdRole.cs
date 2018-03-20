using System;
using System.Collections.Generic;
//aaaa
namespace ngocnhan.tk.Models
{
    public partial class AdRole
    {
        public string AdRoleId { get; set; }
        public string RoleCode { get; set; }
        public string RoleName { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public bool? Active { get; set; }
    }
}
