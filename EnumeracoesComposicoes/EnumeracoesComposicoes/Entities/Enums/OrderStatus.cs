using System;


namespace EnumeracoesComposicoes.Entities.Enums
{
    enum OrderStatus : int 
    {
        PendingPayment, // por padrão, o valor é 0
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
