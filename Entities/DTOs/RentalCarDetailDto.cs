using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalCarDetailDto:IDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime RentDay { get; set; }
        public string BrandName { get; set; }
        public string ImagePath { get; set; }

    }
}
