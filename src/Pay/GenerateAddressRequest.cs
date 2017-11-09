namespace Lykke.Contracts.Pay
{
    public class GenerateAddressRequest
    {
        public string MerchantId { get; set; }
        public string AssertId { get; set; }
    }
}
