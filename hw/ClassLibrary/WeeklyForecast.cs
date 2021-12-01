using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    /* Također je potrebno dodati klasu koja predstavlja tjednu prognozu sa stanjem za čuvanje sedam dnevnih vremenskih prognoza u obliku polja. 
Implementirajte sve potrebne klase, njihove metode, kao i pomoćne statičke metode unutar klase "ForecastUtilities" kako bi se testni program 
u nastavku mogao ispravno izvesti (u klasu ForecastUtilities premjestite i metodu za pronalazak vremena s najvećim osjetom hladnoće vjetra
iz zadaće 1).   */

    public class WeeklyForecast
    {
        private static DailyForecast[] daysOfTheWeek;

        public WeeklyForecast(DailyForecast[] day)
        {
            daysOfTheWeek = day;
        }

        public string GetAsString()
        {
            string s;
            s = daysOfTheWeek[0].GetAsString();
            return s;
        }

        public double GetMaxTemperature()
        {
            Weather max = new Weather();
            max.SetTemperature(0);

            foreach(DailyForecast day in daysOfTheWeek)
            {
                if(day.GetDay().GetTemperature() > max.GetTemperature())
                {
                    max = day.GetDay();
                }
            }

            return max.GetTemperature();
           
        }


    }
}
