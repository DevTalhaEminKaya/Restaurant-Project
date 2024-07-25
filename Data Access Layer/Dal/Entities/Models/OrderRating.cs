using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Entities.Models
{
    public class OrderRating
    {
        public int Id { get; set; }
        public int OrderId { get; set; }

        [Range(1, 5, ErrorMessage = "Value must be between 1 and 5.")]
        public int ServiceRating { get; set; }

        [Range(1, 5, ErrorMessage = "Value must be between 1 and 5.")]
        public int FoodRating { get; set; }

        [Range(1, 5, ErrorMessage = "Value must be between 1 and 5.")]
        public int AmbianceRating { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
