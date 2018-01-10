using Nethereum.Web3.Accounts;

namespace Nethereum.SimpleWindowsWallet.UIMessages
{
    public class AccountLoaded
    {
        public AccountLoaded(Account account)
        {
            Account = account;
        }

        public Account Account { get; }
    }
}