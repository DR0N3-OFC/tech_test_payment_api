using Microsoft.AspNetCore.Mvc;
using tech_test_payment_api.Context;

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
    }
}