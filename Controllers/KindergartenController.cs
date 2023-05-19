using Microsoft.AspNetCore.Mvc;
using KindergartenAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace KindergartenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KindergartenController : Controller
    {
        private readonly ApplicationDBContext _dbContext;

        public KindergartenController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChildModel>>> GetKid()
        {
            if (_dbContext == null)
            {
                return NotFound();
            }

            return await _dbContext.Children.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ChildModel>> GeKid(int id)
        {
            if (_dbContext == null)
            {
                return NotFound();
            }
            var kid = await _dbContext.Children.FindAsync(id);
            if (kid == null)
            {
                return NotFound();
            }
            return kid;
        }

        [HttpPost]
        public async Task<ActionResult<ChildModel>> PostKid(ChildModel kid)
        {
            _dbContext.Children.Add(kid);
            await _dbContext.SaveChangesAsync();
            return CreatedAtAction(nameof(kid), new { id = kid.ChildId }, kid);
        }

    }
}
