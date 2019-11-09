using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pabeda.Projem.Entities.Concrete;
using Pabeda.Projem.MvcWebUI.Models;
using Pabeda.Projem.WebAPI;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pabeda.Projem.MvcWebUI.Controllers
{
    public class OgretmenController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var response = WebApiSettings.webApiClient.GetAsync("Ogretmen").Result;
            string apiResponse = await response.Content.ReadAsStringAsync();
            OgretmenListViewModel model = new OgretmenListViewModel
            {
                Ogretmens = JsonConvert.DeserializeObject<List<Ogretmen>>(apiResponse)
            };
            return View(model);
        }
    }
}
