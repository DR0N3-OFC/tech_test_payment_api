using Microsoft.EntityFrameworkCore;
using tech_test_payment_api.Models;

namespace tech_test_payment_api.Context
{
    public class VendaContext : DbContext
    {
        public VendaContext(DbContextOptions<VendaContext> options) : base(options) { }

        public DbSet<VendaModel>? Vendas { get; set; }
        public DbSet<VendedorModel>? Vendedores { get; set; }
    }
}