using System.ComponentModel;

namespace SimpleLogin.Models.Shared
{
    public class BaseProp
    {

        [DisplayName("Deleted")]
        public bool IsDeleted { get; set; }

        [DisplayName("Active")]
        public bool IsActive { get; set; }
    }
}
