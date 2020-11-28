using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace crudpark.Models
{
    public class Tour
    {
        [Key]
        public int TourId { get; set; }
        
        [Required(ErrorMessage ="This field is required.")]
        [Column(TypeName ="nvarchar(100)")]
        [DisplayName("Tour Title")]
        public string TourTitle { get; set; }

        [Column(TypeName = "nvarchar(2000)")]
        public string Description { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Park Code")]
        public string ParkCode { get; set; }


    }
}
