using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner.Service
{
    public class WeatherService : IWeatherService
    {
        private static List<Weather> weathers = new List<Weather>
        {
            new Weather{City="Cairo",Date=DateTime.Parse("11/6/2021"),Temperture=23},
            new Weather{City="Alex",Date=DateTime.Parse("11/6/2021"),Temperture=25},
            new Weather{City="Cairo",Date=DateTime.Parse("12/6/2021"),Temperture=23},
            new Weather{City="Alex",Date=DateTime.Parse("12/6/2021"),Temperture=25},
            new Weather{City="Cairo",Date=DateTime.Parse("13/6/2021"),Temperture=24},
            new Weather{City="Alex",Date=DateTime.Parse("13/6/2021"),Temperture=26},
            new Weather{City="Cairo",Date=DateTime.Parse("14/6/2021"),Temperture=20},
            new Weather{City="Alex",Date=DateTime.Parse("14/6/2021"),Temperture=21},
        };
        public Weather GetWeather(DateTime date, string cityName)
        {
            return weathers.Where(w => w.Date == date && w.City == cityName).FirstOrDefault();
        }
    }
}
