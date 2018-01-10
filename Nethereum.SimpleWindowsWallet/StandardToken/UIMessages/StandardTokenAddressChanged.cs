namespace Nethereum.SimpleWindowsWallet.StandardToken.UIMessages
{
    public class StandardTokenAddressChanged
    {
        public StandardTokenAddressChanged(string address)
        {
            Address = address;
        }
        public string Address { get; }
    }
}