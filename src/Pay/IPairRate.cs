using System;
using System.Collections.Generic;
using System.Text;

namespace Lykke.Common.Entities.Pay
{
    public interface IPairRate
    {
       string AssetPair { get; set; }
       bool IsBuy { get; set; }
       double Price { get; set; }
        DateTime Timestamp { get; set; }
    }
}
