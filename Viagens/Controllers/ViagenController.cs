using Viagens.Data;
using Viagens.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Viagens.Controllers
{

  [ApiController]
  [Route("api/[controller]")]
  public class ViagenController : ControllerBase
  {

    private readonly DataContext _dataContext;


    public ViagenController(DataContext dataContext)
    {
      _dataContext = dataContext;
    }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<Viagen>>> GetViagens()
    {
      return await _dataContext.Viagens.ToListAsync();
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<Viagen>> GetViagenById(int id)
    {
      var viagen = await _dataContext.Viagens.FindAsync(id);
      if (viagen == null)
      {
        return NotFound();
      }

      return Ok(viagen);
    }





  }

}