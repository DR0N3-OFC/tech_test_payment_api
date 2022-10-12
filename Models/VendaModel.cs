using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace tech_test_payment_api.Models
{
    public class VendaModel
    {
        public int Id { get; set; }
        public int VendedorId { get; set; }
        public DateTime Data { get; set; }
        public EnumStatus? Status { get; set; }
        [NotMapped]
        public ICollection<string>? Itens { get; set; }
        [JsonIgnore]
        public string ListString
        {
            get { return string.Join(",", Itens); }
            set { Itens = value.Split(',').ToList(); }
        }
        public bool IsValid()
        {
            if (Data == null || Status == null || Itens?.Count == 0 || Itens == null)
                return false;

            return true;
        }

        public void SetStatus(EnumStatus? status)
        {
            Status = status;
        }
    }
}