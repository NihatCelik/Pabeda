using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pabeda.Projem.Business.Abstract;
using Pabeda.Projem.Entities.Concrete;

namespace Pabeda.Projem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OgretmenContoller : ControllerBase
    {
        private readonly IOgretmenService _ogretmenService;

        public OgretmenContoller(IOgretmenService OgretmenService)
        {
            _ogretmenService = OgretmenService;
        }

        // GET: api/Ogretmens
        [HttpGet]
        public IEnumerable<Ogretmen> GetOgretmens()
        {
            return _ogretmenService.GetAll();
        }

        // GET: api/Ogretmens/5
        [HttpGet("{id}")]
        public ActionResult<Ogretmen> GetOgretmen(int id)
        {
            var ogretmen = _ogretmenService.GetByOgretmen(id);

            if (ogretmen == null)
            {
                return NotFound();
            }

            return ogretmen;
        }

        // PUT: api/Ogretmens/
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public void PutOgretmen([FromBody] Ogretmen ogretmen)
        {
            _ogretmenService.Update(ogretmen);
        }

        // POST: api/Ogretmens
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public void PostOgretmen([FromBody] Ogretmen ogretmen)
        {
            _ogretmenService.Add(ogretmen);
        }

        // DELETE: api/Ogretmens/5
        [HttpDelete("{id}")]
        public void DeleteOgretmen(int id)
        {
            _ogretmenService.Delete(id);
        } 
    }
}
