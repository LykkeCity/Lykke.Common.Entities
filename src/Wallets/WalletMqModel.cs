using System.Collections.Generic;

namespace Lykke.Contracts.Wallets
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
