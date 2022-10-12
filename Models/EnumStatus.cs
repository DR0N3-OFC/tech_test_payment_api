using System.ComponentModel;

namespace tech_test_payment_api.Models
{
    public enum EnumStatus
    {
        [Description("Pagamento aprovado")]
        Aprovado,
        [Description("Enviado para a transportadora")]
        Enviado,
        [Description("Entregue")]
        Entregue,
        [Description("Cancelada")]
        Cancelada
    }
}