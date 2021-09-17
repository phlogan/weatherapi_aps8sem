using OpenWeatherClient.Clients;
using System;

namespace Testes_Apagar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var la = new ApiClient(new AirQualityIndexClient());
            la.AirQualityIndexClient.GetCurrentAirPollutionData("50", "16");
            Console.ReadKey();
        }
    }
}
