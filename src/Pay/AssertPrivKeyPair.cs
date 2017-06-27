using System;
using System.Collections.Generic;
using System.Text;

namespace Lykke.Common.Entities.Pay
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
