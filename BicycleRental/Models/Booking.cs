using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BicycleRental.Models
{
  public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string RentalDate { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string ExtensionDate { get; set; } 

        public Customer Customer { get; set; }

        public int CustomerId { get; set; }

     
        public IEnumerable<Bicycle> Bicycles { get; set; }

        
    }
}
