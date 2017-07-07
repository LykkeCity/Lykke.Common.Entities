using System;
using System.Collections.Generic;
using System.Text;

namespace Lykke.Common.Entities.Wallets
{
    public class WalletMqModel
    {
        public List<WalletModel> Wallets { get; set; }

        public WalletMqModel()
        {
            Wallets = new List<WalletModel>();
        }
    }
}
