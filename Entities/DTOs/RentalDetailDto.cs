using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto:IDto
    {
        public int IdRental { get; set; }
        public int IdCar { get; set; }
        public int IdCustomer { get; set; }
        public string RenterLastName { get; set; }
        public string RenterFirstName { get; set; }
        public string  CarBrandName { get; set; }
        public string CarColorName { get; set; }
        public string  RenterCompanyName { get; set; }
        public decimal CarDailyPrice { get; set; }
        public DateTime RentalRentDate { get; set; }
        public DateTime? RentalReturnDate { get; set; }

    }
}
