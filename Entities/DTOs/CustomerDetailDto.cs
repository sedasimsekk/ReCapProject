using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CustomerDetailDto:IDto
    {
        public int CustomerId { get; set; }
        public int CustomerUserId { get; set; }
        public string CustomerFirstName { get; set; }
        public string  CustomerLastName { get; set; }
        public string  CustomerCompanyName { get; set; }
        public string CustomerEmail { get; set; }

    }
}
