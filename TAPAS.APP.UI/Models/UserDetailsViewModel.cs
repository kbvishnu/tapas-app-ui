using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAPAS.APP.UI.Models
{
    public class UserDetailsViewModel
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TenantID { get; set; }
        public string TenantName { get; set; }
        public bool IsSavePermission { get; set; }
        public bool IsApprovePermission { get; set; }
        public bool IsReportPermission { get; set; }


    }
}
