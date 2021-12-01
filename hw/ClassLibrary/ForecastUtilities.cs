using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    /* Implementirajte sve potrebne klase, njihove metode, kao i pomoćne statičke metode unutar klase "ForecastUtilities" kako bi se testni program 
u nastavku mogao ispravno izvesti (u klasu ForecastUtilities premjestite i metodu za pronalazak vremena s najvećim osjetom hladnoće vjetra
iz zadaće 1).   */

    public class ForecastUtilities
    {
     
        public static DailyForecast Parse(string input)
        {
            DailyForecast init = new DailyForecast();
            return init;
        }

        public static Weather FindWeatherWithLargestWindchill(Weather[] w)
        {

            double max = w[0].CalculateWindChill();
            int index = 0;

            for (int i = 0; i < w.Length; i++)
            {
                if (w[i].CalculateWindChill() >= max)
                {
                    max = w[i].CalculateWindChill();
                    index = i;
                }
            }

            return new Weather(w[index].GetTemperature(), w[index].GetHumidity(), w[index].GetWindSpeed());

        }
    }
}
