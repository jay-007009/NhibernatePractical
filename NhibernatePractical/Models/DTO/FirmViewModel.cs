using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.Models.DTO
{
    public class FirmViewModel
    {
        public virtual int FirmId { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public virtual string FirmName { get; set; }
        [Required]
        public virtual int RegistrationNumber { get; set; }
        [Required]
        public virtual DateTime RegistrationDate { get; set; }
        [Required]
        public virtual int DonationLimit { get; set; }
        [Required]
        public virtual string AddressLine1 { get; set; }

        [Required]
        public virtual string AddressLine2 { get; set; }
        [Required]
        public virtual string FirmCity { get; set; }
        [Required]
        public virtual string FirmState { get; set; }
        [Required]
        public virtual DateTime FirmCreationDate { get; set; }
        [Required]
        public virtual DateTime FirmModificationDate { get; set; }
        public virtual UserDTO User { get; set; }
      

        public List<SelectListItem> Cities = new List<SelectListItem>();
        public List<SelectListItem> States = new List<SelectListItem>();
    }
}
