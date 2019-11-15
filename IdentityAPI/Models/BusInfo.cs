using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdentityAPI.Models
{
    public class BusInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BusInfoId { get; set; }

        [Required(ErrorMessage = "FromLocation cannot be empty.")]
        public string FromLocation { get; set; }


        [Required(ErrorMessage = "ToLocation cannot be empty.")]
        public string ToLocation { get; set; }

        [Required(ErrorMessage = "TravelDate cannot be empty.")]
        public DateTime TravelDate { get; set; }

        [Required(ErrorMessage = "BusType cannot be empty.")]
        [MinLength(2, ErrorMessage = "Minimum 2 characters required.")]
        public string BusType { get; set; }
       
        [Required(ErrorMessage = "CompanyName cannot be empty.")]
        [MinLength(4, ErrorMessage = "Minimum 4 characters required.")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "BusFare cannot be empty.")]
        [Range(1,4000,ErrorMessage ="Bus fare can not be zero")]
        public double BusFare { get; set; }

        [Required(ErrorMessage = "TicketsCount cannot be empty.")]
        public int TicketsCount { get; set; }
        public string BusArrivalTime { get; set; }
        public string BusDepartureTime { get; set; }
    }
}
