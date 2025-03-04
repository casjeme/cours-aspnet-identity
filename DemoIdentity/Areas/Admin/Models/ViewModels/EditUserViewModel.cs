using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DemoIdentity.Areas.Admin.Models.ViewModels
{
    public class EditUserViewModel
    {
        public string? Id { get; set; }
        [Required]
        public string UserName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string? Password { get; set; }

        public string? AdresseRue { get; set; }

        public string? AdresseCodePostal { get; set; }

        public string? AdresseVille { get; set; }

        public List<RoleSelectionViewModel> Roles { get; set; } = new();
    }

    public class RoleSelectionViewModel
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public bool Selected { get; set; }
    }

}
