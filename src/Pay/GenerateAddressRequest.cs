using System;
using System.Collections.Generic;
using System.Text;

namespace Lykke.Common.Entities.Pay
{
    public class GenerateAddressRequest
    {
        public string MerchantId { get; set; }
        public string AssertId { get; set; }
    }
}
