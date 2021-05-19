using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BicycleRental.Models
{
   public class RentalCenter
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string Address { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set;  }

        public Bicycle Bicycle { get; set; }
        public int BicycleId { get; set; }

        public IEnumerable<Bicycle> Bicycles { get; set; } //One rental center having many bicycles
    }
}
