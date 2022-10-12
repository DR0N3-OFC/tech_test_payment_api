namespace tech_test_payment_api.Models
{
    public class VendedorModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }

        public bool IsValid()
        {
            if (Nome == null || Cpf == null || Email == null || Telefone == null)
                return false;

            return true;
        }
    }
}