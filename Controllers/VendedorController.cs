using Microsoft.AspNetCore.Mvc;
using tech_test_payment_api.Context;
using tech_test_payment_api.Models;

namespace tech_test_payment_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendedorController : ControllerBase
    {
        private readonly EFContext? _context;

        public VendedorController(EFContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Criar(VendedorModel vendedor)
        {
            if (vendedor.IsValid())
            {
                _context?.Vendedores?.Add(vendedor);
                _context?.SaveChanges();

                return Ok(vendedor);
            }

            return BadRequest();
        }
    }
}