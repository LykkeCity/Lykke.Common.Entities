using System;
using System.Collections.Generic;
using System.Text;
using Lykke.Common.Entities.Security;

namespace Lykke.Common.Entities.Pay
{
    public class AssertPairRateResponse : AssertPairRate
    {
        public SecurityErrorType Result { get; }

        public AssertPairRateResponse(AssertPairRate assertRates, SecurityErrorType result) : base(assertRates)
        {
            Result = result;
        }
    }
}
