using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.Models.DTO
{
    public class FirmDTO
    {
       // [Key]
        public virtual int FirmId { get; set; }

     //   [StringLength(30), Required(ErrorMessage = "FirmName is Required")]
        public virtual string FirmName { get; set; }

      //  [RegularExpression(@"[0-9]{2}", ErrorMessage = "Only Alphabets are allowed")]
        public virtual int RegisterNo { get; set; }


       // [RegularExpression(@"[0-9]{4}-[0-9]{2}-[0-9]{2}", ErrorMessage = "Date in proper format")]
        public virtual string RegisterDate { get; set; }


        public virtual decimal DonationLimit { get; set; }

        public virtual string AddressLine1 { get; set; }

        public virtual string AddressLine2 { get; set; }

        public virtual int UserId { get; set; }
        public virtual UserDTO UserList { get; set; } 
        public virtual string FirmCityName { get; set; }
    
        public virtual string FirmStateName { get; set; }
     

        public virtual DateTime CreationDate { get; set; }
        public virtual DateTime ModificationDate { get; set; }

        public virtual ICollection<DonorDTO> DonorList { get; set; }

        public FirmDTO()
        {
            DonorList = new List<DonorDTO>();
        }
       
    }
}
