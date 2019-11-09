using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pabeda.Projem.Business.Abstract;
using Pabeda.Projem.Entities.Concrete;

namespace Pabeda.Projem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OkulController : ControllerBase
    {
        private readonly IOkulService _okulService;

        public OkulController(IOkulService okulService)
        {
            _okulService = okulService;
        }

        // GET: api/Okul
        [HttpGet]
        public IEnumerable<Okul> GetOkul()
        {
            return _okulService.GetAll();
        }

        // GET: api/Okul/5
        [HttpGet("{id}")]
        public ActionResult<Okul> GetOkul(int id)
        {
            var okul = _okulService.GetByOkul(id);

            if (okul == null)
            {
                return NotFound();
            }

            return okul;
        }

        // PUT: api/Okuls/
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public void PutOkul([FromBody] Okul okul)
        {
            _okulService.Update(okul);
        }

        // POST: api/Okuls
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public void PostOkul([FromBody] Okul okul)
        {
            _okulService.Add(okul);
        }

        // DELETE: api/Okul/5
        [HttpDelete("{id}")]
        public void DeleteOkul(int id)
        {
            _okulService.Delete(id);
        } 
    }
}
