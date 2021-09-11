using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAPAS.APP.UI.DataStore
{
    public class UserDetails
    {
        public string UserId
        {
            get { return Guid.NewGuid().ToString(); }
        }
        public string UserName { get; set; }
        public string Password { get; set; }

        public string TenantId { get; set; }
        public string ContactNumber { get; set; }

        public bool IsActive { get; set; }

        public bool IsSavePermission  { get; set; }

        public bool IsApprovePermission { get; set; }

        public bool IsReportPermission { get; set; }
    }
    public class UserServiceClient
    {
        public static List<UserDetails> RegisteredUsers
        {
            get
            {
                return new List<UserDetails>()
                {
                    new UserDetails(){UserName="Madhu",TenantId="100",ContactNumber="123", Password="Madhu",
                        IsActive=true,IsSavePermission=true,IsApprovePermission=true,IsReportPermission=true },

                    new UserDetails(){UserName="APU",TenantId="100",ContactNumber="123", Password="APU",
                        IsActive=true,IsSavePermission=true,IsApprovePermission=true,IsReportPermission=true },

                    new UserDetails(){UserName="SPU",TenantId="101",ContactNumber="123", Password="SPU",
                        IsActive=true,IsSavePermission=true,IsApprovePermission=false,IsReportPermission=false },

                    new UserDetails(){UserName="RPU",TenantId="101",ContactNumber="123", Password="RPU",
                        IsActive=true,IsSavePermission=false,IsApprovePermission=false,IsReportPermission=true },

                    new UserDetails(){UserName="IAU",TenantId="100",ContactNumber="123", Password="IAU",
                        IsActive=false,IsSavePermission=false,IsApprovePermission=false,IsReportPermission=false },
                };
            }
        }
    }
}
