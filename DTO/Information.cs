using System.ComponentModel.DataAnnotations;

namespace BMICalculator.DTO
{
    public class Information
    {
        [Display(Name = "Enter your weight in KGs")]
        public string? Weight { get; set; }
        [Display(Name = "Enter your height in Meters")]
        public string? Height { get; set; }
        [Display(Name = "Your BMI is")]
        public double Result { get; set; }
    }
}
