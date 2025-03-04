using Microsoft.AspNetCore.Identity;

namespace DemoIdentity.Models
{
    public class AppUser : IdentityUser
    {
        [PersonalData]
        public string? AdresseRue { get; set; }
        [PersonalData]
        public string? AdresseCodePostal { get; set; }
        [PersonalData]
        public string? AdresseVille { get; set; }
    }
}
