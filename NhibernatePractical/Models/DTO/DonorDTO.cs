﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhibernatePractical.Models.DTO
{
    public class DonorDTO
    {
     //   [Key]
        public virtual int DonorId { get; set; }

     //   [StringLength(30), Required(ErrorMessage = "DonorName is Requires")]
        public virtual string DonorName { get; set; }


        public virtual decimal DonationAmount { get; set; }


        public virtual string AddressLine1 { get; set; }

        public virtual string AddressLine2 { get; set; }


        public virtual string DonorCityName { get; set; }
     
        public virtual string DonorStateName { get; set; }
       

        public virtual DateTime CreationDate { get; set; }
        public virtual DateTime ModificationDate { get; set; }

       

        public virtual int FirmId { get; set; }

        public virtual FirmDTO Firms { get; set; }
        public virtual string MobileNo { get; set; }
    }
}
