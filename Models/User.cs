using Microsoft.AspNetCore.Identity;

namespace Bilet3.Models
{
    public class User:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
