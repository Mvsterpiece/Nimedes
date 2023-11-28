using Microsoft.AspNetCore.Mvc;
using Nimedes.Data;
using Nimedes.Models;

namespace Nimedes.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NimedController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public NimedController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Nimed> GetArticles()
        {
            var nimed = _context.Nimed.ToList();
            return nimed;
        }

        [HttpPost]
        public List<Nimed> PostArtikkel([FromBody] Nimed nimed)
        {
            _context.Nimed.Add(nimed);
            _context.SaveChanges();
            return _context.Nimed.ToList();
        }


        [HttpDelete("{id}")]
        public List<Nimed> DeleteArtikkel(int id)
        {
            var nimed = _context.Nimed.Find(id);

            if (nimed == null)
            {
                return _context.Nimed.ToList();
            }

            _context.Nimed.Remove(nimed);
            _context.SaveChanges();
            return _context.Nimed.ToList();
        }
    }
}
