using System;


namespace ClassLibrary
{
    public class Weather
    {
        private double currentTemp;
        private double humidity;
        private double windSpeed;


        public Weather(double aCurrentTemp, double aHumidity, double aWindSpeed)
        {
            this.currentTemp = aCurrentTemp;
            this.humidity = aHumidity;
            this.windSpeed = aWindSpeed;
        }

        public Weather()
        {
            this.currentTemp = 0;
            this.humidity = 0;
            this.windSpeed = 0;
        }

        public void SetTemperature(double aTemperature)
        {
            this.currentTemp = aTemperature;
        }

        public void SetHumidity(double aHumidity)
        {
            this.humidity = aHumidity;
        }

        public void SetWindSpeed(double aWindspeed)
        {
            this.windSpeed = aWindspeed;
        }

        public double GetHumidity()
        {
            return humidity;
        }

        public double GetTemperature()
        {
            return currentTemp;
        }

        public double GetWindSpeed()
        {
            return windSpeed;
        }

        public double CalculateFeelsLikeTemperature()
        {
            double HI;
            double fHI;

            double temp = (currentTemp * 1.8) + 32;
            double rh = humidity;
            fHI = -42.379 + (2.04901523 * temp) + (10.14333127 * rh) - (0.22475541 * temp * rh) - (0.00683783 * Math.Pow(temp, 2)) -
          (0.05481717 * Math.Pow(rh, 2)) + (0.00122874 * Math.Pow(temp, 2) * rh) + (0.00085282 * (temp * Math.Pow(rh, 2))) - (0.00000199 * Math.Pow(temp, 2) * Math.Pow(rh, 2));

            HI = (fHI - 32) / 1.8;
            return HI;
        }


        public double CalculateWindChill()
        {
            double WCI, fWCI;
            double temp = (currentTemp * 1.8) + 32;
            double ws = windSpeed / 1.609344;
            fWCI = 35.74 + 0.6215 * temp - 35.75 * Math.Pow(ws, 0.16) + 0.4275 * temp * Math.Pow(ws, 0.16);
            WCI = (fWCI - 32) / 1.8;

            if (currentTemp <= 10 && windSpeed > 4.8)
            {
                return WCI;
            }
            else { return 0; }
        }

        public static Weather operator >(Weather one, Weather two)
        {
            if (one.GetTemperature() > two.GetTemperature())
            {
                return one;
            }
            return two;
        }

        public static Weather operator <(Weather one, Weather two)
        {
            if (one.GetTemperature() < two.GetTemperature())
            {
                return two;
            }
            return one;
        }

        public string GetAsString()
        {
            string s;
            s = "T=" + this.currentTemp + "°C " + " w=" + this.windSpeed + "km/h " + " h=" + this.humidity + "%";
            return s;
        }


    }

}