using System.ComponentModel.DataAnnotations.Schema;

namespace tech_test_payment_api.Models
{
    public class VendaModel
    {
        public int Id { get; set; }
        public VendedorModel? Vendedor { get; set; }
        public DateTime Data { get; set; }
        public EnumStatus? Status { get; set; }
        [NotMapped]
        public ICollection<string>? Itens { get; set; }
        public string ListString
        {
            get { return string.Join(",", Itens); }
            set { Itens = value.Split(',').ToList(); }
        }
        public bool IsValid()
        {
            if (Vendedor == null || Data == null || Status == null || Itens?.Count == 0 || Itens == null)
                return false;

            return true;
        }
    }
}