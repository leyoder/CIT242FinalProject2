using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment12.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using Newtonsoft.Json;
using Packt.Shared;

namespace Assignment12.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory clientFactory;

        private readonly Northwind db;

        public HomeController(
            ILogger<HomeController> logger, 
            Northwind injectedContext,
            IHttpClientFactory httpClientFactory)
            {
                _logger = logger;
                db = injectedContext;
                clientFactory = httpClientFactory;
            }
        
        public async Task<IActionResult> Weather(int days)
        {
            string uri = $"http://localhost:5001/weatherforecast/{days}";

            var client = clientFactory.CreateClient(
                name: "WeatherService");

            var request = new HttpRequestMessage(
                method: HttpMethod.Get, requestUri: uri);

            HttpResponseMessage response = await client.SendAsync(request);

            string jsonString = await response.Content.ReadAsStringAsync();

            IEnumerable<Weather> model = JsonConvert
            .DeserializeObject<IEnumerable<Weather>>(jsonString);

            return View(model);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult OrderPage()
        {
            var model = new OrderViewModel
            {
                Orders = db.Orders.ToList() 
            };

            return View(model);
        }    

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
