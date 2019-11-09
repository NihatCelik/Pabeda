using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pabeda.Projem.Entities.Concrete;
using Pabeda.Projem.MvcWebUI.Models;
using Pabeda.Projem.WebAPI;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pabeda.Projem.MvcWebUI.Controllers
{
    public class OkulController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var response = WebApiSettings.webApiClient.GetAsync("Okul").Result;
            string apiResponse = await response.Content.ReadAsStringAsync();
            OkulListViewModel model = new OkulListViewModel
            {
                Okuls = JsonConvert.DeserializeObject<List<Okul>>(apiResponse)
            };
            return View(model);
        }
    }
}
