namespace Nethereum.SimpleWindowsWallet.UIMessages
{
    public class UrlChanged
    {
        public UrlChanged(string url)
        {
            Url = url;
        }
        public string Url { get; }
    }
}
