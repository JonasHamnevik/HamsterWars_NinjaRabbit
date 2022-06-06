using Data;
using HamsterWars.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services;

namespace HamsterWars.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HamsterController : ControllerBase
{
    private readonly HamsterWarsDbContext _context;
    private readonly HamsterService hamsterService;

    public HamsterController(
        HamsterWarsDbContext context,
        HamsterService hamsterService)
    {
        _context = context;
        this.hamsterService = hamsterService;
    }

    [HttpGet("GetAll")]
    public async Task<ActionResult<IEnumerable<Hamster>>> GetAll() =>
        await _context.Hamsters.ToListAsync();

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Hamster>> GetById(int id)
    {
        var hamster = await _context.Hamsters.FirstOrDefaultAsync((h) => h.Id == id);

        if (hamster is null)
            return NotFound();
        return Ok(hamster);
    }

    [HttpPost]
    public async Task<ActionResult<Hamster>> Create([FromBody] Hamster hamster)
    {
        _context.Hamsters.Add(hamster);
        await _context.SaveChangesAsync();

        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Hamster hamster)
    {
        if (id != hamster.Id)
            return BadRequest();

        _context.Entry(hamster).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (hamsterService.Exists(id))
                throw;
            return NotFound();
        }
        return Ok();
    }

    [HttpDelete("delete{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var hamster = await _context.Hamsters.FindAsync(id);

        if (hamster is null)
            return BadRequest();

        try
        {
            _context.Hamsters.Remove(hamster);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
        return Ok();
    }

}
