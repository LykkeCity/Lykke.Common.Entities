namespace Lykke.Contracts.Payments
{
    public enum CashInPaymentSystem
    {
        Unknown,
        CreditVoucher,
        Bitcoin,
        Ethereum,
        Swift,
        SolarCoin,
        ChronoBank,
        Fxpaygate,
        Quanta,
        EasyPaymentGateway
    }

    public enum PaymentStatus
    {
        Created,
        NotifyProcessed,
        NotifyDeclined,
        NotifyCancelled,
        Processing
    }

    public enum CardPaymentSystem
    {
        Unknown, CreditVoucher, Fxpaygate, EasyPaymentGateway
    }
}