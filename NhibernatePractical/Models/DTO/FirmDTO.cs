using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.Models.DTO
{
    public class FirmDTO
    {
       // [Key]
        public virtual int FirmId { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public virtual string FirmName { get; set; }

        [Required]
        public virtual int RegisterNo { get; set; }


        [Required]
        public virtual DateTime RegisterDate { get; set; }

        [Required]
        public virtual decimal DonationLimit { get; set; }
        [Required]
        public virtual string AddressLine1 { get; set; }

        public virtual string AddressLine2 { get; set; }

    
        public virtual UserDTO Users { get; set; }
        [Required]
        public virtual string FirmCityName { get; set; }
    
        public virtual string FirmStateName { get; set; }

        public virtual DonorDTO Donors { get; set; }
        [Required]
        public virtual DateTime CreationDate { get; set; }
        [Required]
        public virtual DateTime ModificationDate { get; set; }

        public virtual ICollection<DonorDTO> DonorList { get; set; }

        public FirmDTO()
        {
            DonorList = new List<DonorDTO>();
        }
        public List<SelectListItem> Cities = new List<SelectListItem>();
        public List<SelectListItem> States = new List<SelectListItem>();

    }
}
