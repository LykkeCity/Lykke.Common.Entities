using System;
using System.Collections.Generic;
using System.Text;

namespace Lykke.Common.Entities.Wallets
{
    public class WalletModel
    {
        public string Address { get; set; }

        public double AmountChange { get; set; }

        public string TransactionId { get; set; }
    }
}
