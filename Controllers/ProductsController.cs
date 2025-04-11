using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductListApp.Data;
using ProductListApp.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ProductListApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(AppDbContext context, ILogger<ProductsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: /Products
        public IActionResult Index()
        {
            return View();
        }

        // GET: /api/products
        [Route("api/products")]
        public async Task<IActionResult> GetProducts(int page = 1, int pageSize = 9, string search = null, string sort = null)
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 6;
            if (pageSize > 50) pageSize = 50;  // Limit page size

            var query = _context.Products.AsQueryable();

            // Search by product name if provided
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(p => p.Name.Contains(search));
            }

            // Apply sorting
            query = ApplySorting(query, sort);

            // Count total products
            var totalItems = await query.CountAsync();

            // Get paginated data
            var items = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            // Calculate total pages
            var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            // Create paged result
            var result = new PagedResult<Product>
            {
                Items = items,
                TotalItems = totalItems,
                Page = page,
                PageSize = pageSize,
                TotalPages = totalPages
            };

            return Json(result);
        }

        // Helper method to apply sorting
        private IQueryable<Product> ApplySorting(IQueryable<Product> query, string sort)
        {
            return sort switch
            {
                "price-asc" => query.OrderBy(p => p.Price),
                "price-desc" => query.OrderByDescending(p => p.Price),
                "name-asc" => query.OrderBy(p => p.Name),
                "name-desc" => query.OrderByDescending(p => p.Name),
                "rating-desc" => query.OrderByDescending(p => p.Rating),
                _ => query.OrderByDescending(p => p.Rating)  // Default: Most Popular (by rating)
            };
        }
    }
}