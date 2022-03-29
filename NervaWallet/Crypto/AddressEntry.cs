namespace NervaWallet.Crypto
{
    public class AddressEntry
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string PaymentId { get; set; }
        public IList<SubAddress> SubAddressList {get; set; }
    }
}