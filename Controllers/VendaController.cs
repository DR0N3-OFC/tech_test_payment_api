using Microsoft.AspNetCore.Mvc;
using tech_test_payment_api.Context;

namespace tech_test_payment_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        private readonly VendaContext? _context;

        public VendaController(VendaContext context)
        {
            _context = context;
        }
    }
}