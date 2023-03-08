using BMICalculator.DTO;
using BMICalculator.Operations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BMICalculator.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {

        public BMIoperations? calc { get; set; }
        public Information information { get; set; }


        public void OnPostAsync()
        {
            double Weightd = Convert.ToDouble(information.Weight);
            double Heightd = Convert.ToDouble(information.Height);

            information.Result = calc.Calculation(Weightd, Heightd);

        }
    }
}