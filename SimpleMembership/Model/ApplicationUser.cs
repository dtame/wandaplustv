using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleMembership.Model
{
    public class ApplicationUser : IdentityUser<string>
    {        
        public string RoleId { get; set; }
    }
}
