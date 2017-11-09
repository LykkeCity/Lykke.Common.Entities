namespace Lykke.Contracts.Pay
{
    public class AssertPrivKeyPair
    {
        public string AssertId { get; set; }
        public string PrivateKey { get; set; }
        public string PublicKey { get; set; }
        public string Address { get; set; }
        public double Amount { get; set; }
    }
}
