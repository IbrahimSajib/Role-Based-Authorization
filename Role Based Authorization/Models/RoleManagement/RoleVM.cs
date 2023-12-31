#nullable disable
using System.ComponentModel.DataAnnotations;

namespace Role_Based_Authorization.Models.RoleManagement
{
    public class RoleVM
    {
        //public RoleVM()
        //{
        //    Users = new List<string>();
        //}
        public string Id { get; set; }

        [Required(ErrorMessage = "Role Name is required")]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
        //public List<string> Users { get; set; }
    }
}
