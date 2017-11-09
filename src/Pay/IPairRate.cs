using System;

namespace Lykke.Contracts.Pay
{
    public interface IPairRate
    {
       string AssetPair { get; set; }
       bool IsBuy { get; set; }
       double Price { get; set; }
        DateTime Timestamp { get; set; }
    }
}
