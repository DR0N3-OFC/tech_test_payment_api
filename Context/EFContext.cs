using Microsoft.EntityFrameworkCore;
using tech_test_payment_api.Models;

namespace tech_test_payment_api.Context
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options) { }

        public DbSet<VendaModel>? Vendas { get; set; }
        public DbSet<VendedorModel>? Vendedores { get; set; }
    }
}