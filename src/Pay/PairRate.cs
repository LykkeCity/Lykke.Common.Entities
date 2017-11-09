using System;

namespace Lykke.Contracts.Pay
{
    public class PairRate : IPairRate
    {
        public string AssetPair { get; set; }
        public bool IsBuy { get; set; }
        public double Price { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
