namespace Lykke.Contracts.Security
{
    public enum SecurityErrorType
    {
        Ok,
        MerchantUnknown,
        SignEmpty,
        SignIncorrect,
        OutOfDate,
        AssertEmpty
    }
}
