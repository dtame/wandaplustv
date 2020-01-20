using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleMembership.Model
{
    public class ApplicationUser : IdentityUser<Guid>
    {        
        public string RoleId { get; set; }
    }
}
