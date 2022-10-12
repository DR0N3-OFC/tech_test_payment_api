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
            if (venda.IsValid())
            {
                _context?.Vendas?.Add(venda);
                _context?.SaveChanges();

                return Ok(venda);
            }

            return BadRequest(new {Error = "Confira os dados inseridos e tente novamente."});
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var venda = _context?.Vendas?.Find(id);
            var vendedor = _context?.Vendedores?.Where(v => venda.VendedorId == v.Id);
            var vendaCompleta = new { venda, vendedor };

            if (venda != null)
                return Ok(vendaCompleta);

            return NotFound();
        }

        [HttpPut]
        public IActionResult AtualizarVenda(int id, EnumStatus? status)
        {
            bool trocaValida = false;
            var vendaBanco = _context?.Vendas?.Find(id);

            if (vendaBanco == null)
                return NotFound();

            switch ((int?) vendaBanco.Status)
            {
                case 0:
                        if ((int?) status == 1 || (int?) status == 2)
                            trocaValida = true;
                    break;
                case 1:
                        if ((int?) status == 2 || (int?) status == 2)
                            trocaValida = true;
                    break;
                case 2:
                        if ((int?) status == 3)
                            trocaValida = true;
                    break;
            }
            if (trocaValida == true)
            {
                _context?.Vendas?.Update(vendaBanco);
                _context?.SaveChanges();

                return Ok(vendaBanco);
            }

            return BadRequest(new {Error = "Alteração de status inválida."});
        }
    }
}