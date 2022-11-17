namespace AirlineManagerBlazor.Data
{
    public class WeatherForecastService
    {

        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        private readonly HttpClient httpClient;

        public WeatherForecastService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            return httpClient.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
            //return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = startDate.AddDays(index),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //}).ToArray());
        }
    }
}