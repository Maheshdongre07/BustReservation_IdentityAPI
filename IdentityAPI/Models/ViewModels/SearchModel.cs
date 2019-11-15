using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdentityAPI.Models.ViewModels
{
    public class SearchModel
    {
        [Required(ErrorMessage = "FromLocation cannot be empty.")]
        public string FromLocation { get; set; }


        [Required(ErrorMessage = "ToLocation cannot be empty.")]
        public string ToLocation { get; set; }

        [Required(ErrorMessage = "TravelDate cannot be empty.")]
        public DateTime TravelDate { get; set; }

    }
}
