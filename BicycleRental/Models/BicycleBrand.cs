using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace BicycleRental.Models
{
   public class BicycleBrand
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(150), Required]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Location { get; set; }

        [MaxLength(150)]
        public string Address { get; set; }

        public IEnumerable<Bicycle> Bicycles { get; set; } //One brand having many bicycles
    }
}
