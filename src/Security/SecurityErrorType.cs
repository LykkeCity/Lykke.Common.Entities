namespace Lykke.Common.Entities.Security
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
