using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.Api.Identity
{
    public class Role : Entity
    {
        public IEnumerable<UserRole> UserRoles { get; set; }
    }
}