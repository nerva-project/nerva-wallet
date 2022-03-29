namespace NervaWallet.Crypto.Methods
{
    public interface IMethods
    {
        // Each asset will need to implement their own way of connecting to daemon

        // TODO: Add params and more contracts
        public bool OpenWallet();
        public bool CloseWallet();
        public bool CreateWallet();
        public bool RestoreWalletFromKeys();
        public bool RestoreWalletFromSeed();
    }
}