using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly WarehouseContext _context;
        public ProductsController(WarehouseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return await _context.Products
            .Include(g => g.Grade)
            .Include(l => l.LotNumber)
            .Include(p => p.Packaging)
            .Include(s => s.Status)
            .Include(w => w.Warehouse)
            .ToListAsync();
        }

        [HttpGet("{id}")] // api/products/3
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await _context.Products
            .Include(g => g.Grade)
            .Include(l => l.LotNumber)
            .Include(p => p.Packaging)
            .Include(s => s.Status)
            .Include(w => w.Warehouse)
            .FirstOrDefaultAsync(p => p.Id == id);
        }

        [HttpGet("grades")]
        public async Task<ActionResult<List<Grade>>> GetGrades()
        {
            return await _context.Grades.ToListAsync();
        }

        [HttpGet("lotnumbers")]
        public async Task<ActionResult<List<LotNumber>>> GetLotNumbers()
        {
            return await _context.LotNumbers.ToListAsync();
        }


        [HttpGet("packaging")]
        public async Task<ActionResult<List<Packaging>>> GetPackaging()
        {
            return await _context.Packaging.ToListAsync();
        }

        [HttpGet("statuses")]
        public async Task<ActionResult<List<Status>>> GetStatuses()
        {
            return await _context.Statuses.ToListAsync();
        }

        [HttpGet("warehouses")]
        public async Task<ActionResult<List<Warehouse>>> GetWarehouses()
        {
            return await _context.Warehouses.ToListAsync();
        }

    }
}