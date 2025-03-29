namespace weather.Models
{
    public class WeatherModel
    {
        public double Temperature { get; set; }
        public string Scale { get; set; }  
        public double ConvertedTemperature { get; set; }
        public string ConvertedScale { get; set; }
    }
}
