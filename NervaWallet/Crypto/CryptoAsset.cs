using NervaWallet.Crypto.Methods;

namespace NervaWallet.Crypto
{
    public class CryptoAsset
    {
        // Basic asset info
        public string Ticker { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string WebsiteUrl { get; set; }

        // Lists
        public IList<Node> NodeList { get; set; }
        public IList<AddressEntry> AddressList { get; set; }
        public IList<Wallet> WalletList { get; set; }

        // Interface Methods based on asset
        public IMethods Methods { get; set; }
    }
}