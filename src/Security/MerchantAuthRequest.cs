namespace Lykke.Common.Entities.Security
{
    public class MerchantAuthRequest
    {
        public string MerchantId { get; set; }
        public string StringToSign { get; set; }
        public string Sign { get; set; }
    }
}
