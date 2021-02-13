using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto:IDto
    {
        public string CarDescription { get; set; }
        public string CompanyName { get; set; }
        public decimal DailyPrice { get; set; }
        public DateTime RentalDate { get; set; }


    }
}
