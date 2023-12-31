#nullable disable
namespace Role_Based_Authorization.Models.UserManagement
{
    public class RolesOfUserVM
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public bool IsSelected { get; set; }
    }
}
