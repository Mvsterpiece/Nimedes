using Microsoft.AspNetCore.Mvc;
using Nimedes.Data;
using Nimedes.Models;

namespace Nimedes.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Users> GetArticles()
        {
            var user = _context.Users.ToList();
            return user;
        }

        [HttpPost]
        public List<Users> PostArtikkel([FromBody] Users user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return _context.Users.ToList();
        }


        [HttpDelete("{id}")]
        public List<Users> DeleteArtikkel(int id)
        {
            var user = _context.Users.Find(id);

            if (user == null)
            {
                return _context.Users.ToList();
            }

            _context.Users.Remove(user);
            _context.SaveChanges();
            return _context.Users.ToList();
        }
    }
}
