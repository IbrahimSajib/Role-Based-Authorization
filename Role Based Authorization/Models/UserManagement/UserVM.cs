using System.ComponentModel.DataAnnotations;

namespace Role_Based_Authorization.Models.UserManagement
{
    public class UserVM
    {
        //public UserVM()
        //{
        //    Roles = new List<string>();
        //}

        public string Id { get; set; }

        //[Required]
        //public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        //public IList<string> Roles { get; set; }
    }
}
