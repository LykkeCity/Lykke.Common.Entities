using System;
using System.Collections.Generic;
using System.Text;

namespace Lykke.Common.Entities.Pay
{
    public class AssertPairRateRequest
    {
        public float Percent { get; set; }
        public int Pips { get; set; }
        public float FixedFee { get; set; }

    }
}
