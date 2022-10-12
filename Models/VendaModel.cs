namespace tech_test_payment_api.Models
{
    public class VendaModel
    {
        public int Id { get; set; }
        public int VendedorId { get; set; }
        public DateTime Data { get; set; }
        public EnumStatus Status { get; set; }
        public List<string>? Itens { get; set; }
    }
}