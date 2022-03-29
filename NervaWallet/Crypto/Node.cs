namespace NervaWallet.Crypto
{
    public class Node
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Port { get; set; }
        public bool IsDefault { get; set; } = false;
    }
}