namespace tech_test_payment_api.Models
{
    public class VendaModel
    {
        public int Id { get; set; }
        public VendedorModel? Vendedor { get; set; }
        public DateTime Data { get; set; }
        public EnumStatus? Status { get; set; }
        public List<string>? Itens { get; set; }

        public bool IsValid()
        {
            if (Vendedor == null || Data == null || Status == null || Itens?.Count == 0 || Itens == null)
                return false;

            return true;
        }
    }
}