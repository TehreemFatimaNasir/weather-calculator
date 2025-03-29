using Microsoft.AspNetCore.Mvc;

namespace weather.Controllers
{
    public class WeatherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



           public IActionResult Calculate(double temperature, string scale)
             {
            double convertedTemperature = 0;
            string convertedScale = "";

            if (scale == "Celsius")
            {
                convertedTemperature = (temperature * 9 / 5) + 32;
                convertedScale = "Fahrenheit";
            }
            else if (scale == "Fahrenheit")
            {
                convertedTemperature = (temperature - 32) * 5 / 9;
                convertedScale = "Celsius";
            }

            ViewBag.ConvertedTemperature = convertedTemperature;
            ViewBag.ConvertedScale = convertedScale;

            return View("Calculate");
        }
    }
}
