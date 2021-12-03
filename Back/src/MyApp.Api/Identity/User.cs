using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApp.Api.Enum;

namespace MyApp.Api.Identity
{
    public class User : Entity
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Titulo Titulo { get; set; }
        public string Descricao { get; set; }
        public Func Func { get; set; }
        public string ImagemPerfil { get; set; }
        public IEnumerable<UserRole> UserRoles { get; set; }
    }
}