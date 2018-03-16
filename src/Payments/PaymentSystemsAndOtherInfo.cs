using System;
using System.Collections.Generic;

namespace Lykke.Contracts.Payments
{
    public static class PaymentSystemsAndOtherInfo
    {
        public static readonly Dictionary<CashInPaymentSystem, Type> PsAndOtherInfoLinks = new Dictionary<CashInPaymentSystem, Type>
        {
            [CashInPaymentSystem.CreditVoucher] = typeof(OtherPaymentInfo),
            [CashInPaymentSystem.Fxpaygate] = typeof(OtherPaymentInfo),
        };
    }
}
