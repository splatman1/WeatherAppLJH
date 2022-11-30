using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace WeatherAppLJH
{
    class WeatherAppAPI
    {
        public async Task<WeatherInfo> GetWeatherInformation(string location = "Perth", string unitOfMeasurement = "Metric", string dayOfWeather = "CurrentDay", string unitOfMeasurementWind = "meter/sec)")
        {
            //This is the client object that will send and recieve the messages (HTTP requests/responses) for us
            HttpClient client = new HttpClient();
            if (location == string.Empty)
            {
                return null;
            }
            
            //Create the string for the URL.
            string apiURL = $"https://api.openweathermap.org/data/2.5/weather?q={location}&appid=f178b149d4398c299d3bc3fc992c9e60&units={unitOfMeasurement}&{dayOfWeather}&speed={unitOfMeasurementWind}";

            //Create an HTTP request that includes the method and the url of the request.
            var request = new HttpRequestMessage(HttpMethod.Get, apiURL);

            //Finally we send the request and get the response from the client passing in all the data.
            HttpResponseMessage response = await client.SendAsync(request);

            //The response contains lots of useful information such as the status code and response headers. An HTTP response code of 200 (OK)is ideal.
            //if (response.StatusCode != HttpStatusCode.OK) throw new HttpRequestException($"The server responded with an status code of: {response.StatusCode}");

            //Read the body (content) of the response as a string
            string responseString = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<WeatherInfo>(responseString);

            


        }
        

    }
}
