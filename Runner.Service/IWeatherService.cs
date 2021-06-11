using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Runner.Service
{
    [ServiceContract]
    public interface IWeatherService
    {
        [OperationContract]
        Weather GetWeather(DateTime date, string cityName);
    }
}
