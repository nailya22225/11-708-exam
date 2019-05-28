using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex2.Models
{
    public enum Roles {
        user,
        admin
    }

    public class User : IdentityUser
    {
        public virtual string Login { get; set; }
        public virtual string Password { get; set; }

        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual Roles Role { get; set; }
    }
}
