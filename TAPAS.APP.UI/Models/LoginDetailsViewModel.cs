using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TAPAS.APP.UI.Models
{
    public class LoginDetailsViewModel
    {
        [Required]
        public string TenantId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string  Password { get; set; }
    }
}
