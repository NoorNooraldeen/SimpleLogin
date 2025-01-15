using SimpleLogin.Models.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleLogin.Models
{
    public class User : BaseProp
    {
        [Display(Name = "UserID ID")]
        public Guid UserId { get; set; }


        [Display(Name = "User Name")]
        [Required(ErrorMessage = "Enter Name")]
        [MinLength(3, ErrorMessage = "At least 3 Char")]

        public string Name { get; set; }

        public string  Email { get; set; }

       

        [DataType(DataType.Password)]

        public int Password { get; set; }


        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public Role ? Role { get; set; }

    }
}
