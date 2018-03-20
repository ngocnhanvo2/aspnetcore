using System;
using System.Collections.Generic;

namespace ngocnhan.tk.Models
{
    public partial class AdUser
    {
        public string AdUserId { get; set; }
        public string AdRoleId { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public DateTime? Birthday { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public string Marital { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public bool? Active { get; set; }
    }
}
