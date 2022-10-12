using Microsoft.AspNetCore.Mvc;
using tech_test_payment_api.Context;
using tech_test_payment_api.Models;

namespace tech_test_payment_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        private readonly EFContext? _context;

        public VendaController(EFContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Registrar(VendaModel venda)
        {
            if (venda.IsValid()){
                _context?.Vendas?.Add(venda);
                _context?.SaveChanges();

                return Ok(venda);
            }

            return BadRequest();
        }
    }
}