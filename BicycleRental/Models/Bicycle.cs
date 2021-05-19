using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BicycleRental.Models
{
    public class Bicycle
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50), Required]
        public string Model { get; set; }

        [MaxLength(18), Required]
        public int Price { get; set; }

        [MaxLength(50), Required]
        public string Condition { get; set; }

        [MaxLength(50), Required]
        public string Availability { get; set; }

        public int MakeYear {get; set;}

        public BicycleBrand BicycleBrand { get; set; } //Association 
       
        public int BicycleBrandId { get; set; } //Foreign Key

        public IEnumerable<Booking> Bookings { get; set; }

    }
}

 
