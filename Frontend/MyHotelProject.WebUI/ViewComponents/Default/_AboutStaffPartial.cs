using Microsoft.AspNetCore.Mvc;
using MyHotelProject.WebUI.Models;
using Newtonsoft.Json;

namespace MyHotelProject.WebUI.ViewComponents.Default
{
    public class _AboutStaffPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AboutStaffPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5103/api/Staff/staffCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<int>(jsonData);
                ViewBag.StaffCount = values;
                return View(values);
            }
            return View();
        }
    }
}
