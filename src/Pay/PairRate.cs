using System;
using System.Collections.Generic;
using System.Text;

namespace Lykke.Common.Entities.Pay
{
    public class PairRate : IPairRate
    {
        public string AssetPair { get; set; }
        public bool IsBuy { get; set; }
        public double Price { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
