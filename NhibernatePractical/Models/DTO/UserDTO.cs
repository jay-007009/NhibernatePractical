using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.Models.DTO
{
    public class UserDTO
    {
        //  [Key]
        public virtual int UserId { get; set; }

        //  [StringLength(30), Required(ErrorMessage = "UserName is Required")]
        public virtual string UserName { get; set; }


        public virtual string Password { get; set; }

        public virtual bool IsActive { get; set; }
        public virtual ICollection<FirmDTO> FirmList { get; set; }

        public UserDTO()
        {
            FirmList = new List<FirmDTO>();
        }

    }
}
