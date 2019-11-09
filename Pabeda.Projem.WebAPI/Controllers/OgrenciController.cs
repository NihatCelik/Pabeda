using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pabeda.Projem.Business.Abstract;
using Pabeda.Projem.Entities.Concrete;

namespace Pabeda.Projem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OgrenciController : ControllerBase
    {
        private readonly IOgrenciService _ogrenciService;

        public OgrenciController(IOgrenciService OgrenciService)
        {
            _ogrenciService = OgrenciService;
        }

        // GET: api/Ogrenci
        [HttpGet]
        public IEnumerable<Ogrenci> GetOgrenci()
        {
            return _ogrenciService.GetAll();
        }

        // GET: api/Ogrenci/5
        [HttpGet("{id}")]
        public ActionResult<Ogrenci> GetOgrenci(int id)
        {
            var ogrenci = _ogrenciService.GetByOgrenci(id);

            if (ogrenci == null)
            {
                return NotFound();
            }

            return ogrenci;
        }

        // PUT: api/Ogrencis/
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public void PutOgrenci([FromBody] Ogrenci ogrenci)
        {
            _ogrenciService.Update(ogrenci);
        }

        // POST: api/Ogrencis
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public void PostOgrenci([FromBody] Ogrenci ogrenci)
        {
            _ogrenciService.Add(ogrenci);
        }

        // DELETE: api/Ogrencis/5
        [HttpDelete("{id}")]
        public void DeleteOgrenci(int id)
        {
            _ogrenciService.Delete(id);
        }
    }
}
