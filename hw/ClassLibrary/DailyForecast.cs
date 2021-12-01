using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{

    /*  U sustav za rad s informacijama o vremenskim prilikama trebate dodati klasu koja predstavlja vremensku prognozu za određeni dan. Vremenska prognoza
 sadržava informacije o datumu na koji se odnosi (struktura DateTime) te referencu na objekt tipa Weather iz Zadaće 1.
Također je potrebno dodati klasu koja predstavlja tjednu prognozu sa stanjem za čuvanje sedam dnevnih vremenskih prognoza u obliku polja. 
Implementirajte sve potrebne klase, njihove metode, kao i pomoćne statičke metode unutar klase "ForecastUtilities" kako bi se testni program 
u nastavku mogao ispravno izvesti (u klasu ForecastUtilities premjestite i metodu za pronalazak vremena s najvećim osjetom hladnoće vjetra
iz zadaće 1).   */

   public class DailyForecast
    {
        private DateTime time;
        private Weather day;

        public DailyForecast(DateTime t, Weather d)
        {
            this.time = t;
            this.day = d;
        }


        public DailyForecast( )
        {
            this.time = DateTime.Now;
            
        }

        public Weather GetDay()
        {
            return day;
        }

        public string GetAsString()
        {
            string s;
            s = this.time + " " + this.day;
            return s;
        }
    }
}
