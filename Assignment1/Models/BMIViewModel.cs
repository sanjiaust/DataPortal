using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class BMIViewModel
    {
        [Required]
        public int Feet { get; set; }

        [Required]
        public int Inches { get; set; }

        [Required]
        public double Weight { get; set; }
    }
}
