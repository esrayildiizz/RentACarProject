using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Rental
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public string RentDate { get; set; }
        public string ReturnDate { get; set; }
    }
}
