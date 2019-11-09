using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pabeda.Projem.Entities.Concrete;
using Pabeda.Projem.MvcWebUI.Models;
using Pabeda.Projem.WebAPI;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pabeda.Projem.MvcWebUI.Controllers
{
    public class OgrenciController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var response = WebApiSettings.webApiClient.GetAsync("Ogrenci").Result;
            string apiResponse = await response.Content.ReadAsStringAsync();
            OgrenciListViewModel model = new OgrenciListViewModel
            {
                Ogrencis = JsonConvert.DeserializeObject<List<Ogrenci>>(apiResponse)
            };
            return View(model);
        }

        public async Task<IActionResult> OgrenciEkle()
        {
            return View();
        }
    }
}
