using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using SimpleLogin.Models.Shared;

namespace SimpleLogin.Models
{
    public class Role : BaseProp
    {
        public int RoleId { get; set; }


        [Required(ErrorMessage = " Enter your Role Name")]
        [DisplayName("Role Name")]
        public string RoleName { get; set; }

    }
}
