using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using TraversalCoreProject.Areas.Admin.Models;
namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HotelSearchController : Controller
    {
        

        public async Task<IActionResult> Index()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://hotels-com-provider.p.rapidapi.com/v2/hotels/search?region_id=2734&locale=en_GB&checkin_date=2024-09-26&sort_order=REVIEW&adults_number=1&domain=AE&checkout_date=2024-09-27&children_ages=4%2C0%2C15&lodging_type=HOTEL%2CHOSTEL%2CAPART_HOTEL&price_min=10&star_rating_ids=3%2C4%2C5&meal_plan=FREE_BREAKFAST&page_number=1&price_max=500&amenities=WIFI%2CPARKING&payment_type=PAY_LATER%2CFREE_CANCELLATION&guest_rating_min=8&available_filter=SHOW_AVAILABLE_ONLY"),
                Headers =
      {
         { "X-RapidAPI-Key", "bade654592msh5d812bdcd591838p1fb17cjsn133e4d33b08d" },
         { "X-RapidAPI-Host", "hotels-com-provider.p.rapidapi.com" },
      },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<HotelSearchViewModel>(body);
                return View(values.properties);

            }
        }

        [HttpGet]
        public IActionResult GetCity()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetCity(string city)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://hotels-com-provider.p.rapidapi.com/v2/regions?query={city}&domain=AE&locale=en_GB"),
                Headers =
    {
        { "X-RapidAPI-Key", "bade654592msh5d812bdcd591838p1fb17cjsn133e4d33b08d" },
        { "X-RapidAPI-Host", "hotels-com-provider.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                return View();
            }


        }
    }
}
