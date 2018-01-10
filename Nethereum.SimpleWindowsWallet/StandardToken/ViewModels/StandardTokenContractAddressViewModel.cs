using System;
using System.Reactive.Linq;
using Nethereum.SimpleWindowsWallet.StandardToken.UIMessages;
using ReactiveUI;

namespace Nethereum.SimpleWindowsWallet.StandardToken.ViewModels
{
    public class StandardTokenContractAddressViewModel : ReactiveObject
    {
        private string _contractAddress;

        public string ContractAddress
        {
            get => _contractAddress;
            set => this.RaiseAndSetIfChanged(ref _contractAddress, value);
        }

        public StandardTokenContractAddressViewModel()
        {
            var isValidContractAddresss = this.WhenAnyValue(x => x.ContractAddress,
                (contractAddress) => Util.Utils.IsValidAddress(contractAddress));

            isValidContractAddresss.Where(x => x == true)
                .Subscribe(_ => MessageBus.Current.SendMessage(new StandardTokenAddressChanged(ContractAddress)));
        }

    }
}