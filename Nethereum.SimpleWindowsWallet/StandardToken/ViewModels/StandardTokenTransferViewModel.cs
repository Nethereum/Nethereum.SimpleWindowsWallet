using System;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Genesis.Ensure;
using Nethereum.Hex.HexTypes;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.SimpleWindowsWallet.StandardToken.ContractMessages;
using Nethereum.SimpleWindowsWallet.StandardToken.UIMessages;
using Nethereum.SimpleWindowsWallet.UIMessages;
using Nethereum.SimpleWindowsWallet.ViewModels;
using ReactiveUI;

namespace Nethereum.SimpleWindowsWallet.StandardToken.ViewModels
{
    public class StandardTokenTransferViewModel : SendTransactionBaseViewModel
    {
        private string _contractAddress;
        public string ContractAddress
        {
            get => _contractAddress;
            set => this.RaiseAndSetIfChanged(ref _contractAddress, value);
        }

        private decimal? _amount;
        public decimal? Amount
        {
            get => _amount;
            set => this.RaiseAndSetIfChanged(ref _amount, value);
        }

        public StandardTokenTransferViewModel()
        {
            GasPrice = (ulong)Signer.Transaction.DEFAULT_GAS_PRICE;

            MessageBus.Current.Listen<StandardTokenAddressChanged>().Subscribe(x =>
                {
                    ContractAddress = x.Address;
                }
            );

            var canExecuteTransaction = this.WhenAnyValue(
                x => x.AddressTo,
                x => x.Amount,
                x => x.Url,
                x => x.Account,
                (addressTo, amount, url, account) =>
                    Util.Utils.IsValidAddress(addressTo) &&
                    amount != null &&
                    Util.Utils.IsValidUrl(url) &&
                    account != null);

            this._executeTrasnactionCommand = ReactiveCommand.CreateFromTask(ExecuteAsync, canExecuteTransaction);
        }


        public async Task<string> ExecuteAsync()
        {
            Ensure.ArgumentNotNullOrEmpty(this.AddressTo, "Address To");
            Ensure.ArgumentNotNullOrEmpty(this.Url, "Url");
            Ensure.ArgumentNotNull(this.Account, "Account");
            Ensure.ArgumentNotNull(this.Amount, "Token Amount");

            var confirmed = await _confirmTransfer.Handle(GetConfirmationMessage());

            if (confirmed)
            {
                var web3 = new Web3.Web3(Account, Url);

                var transferfuction =
                    new TransferFunction
                    {
                        TokenAmount = Web3.Web3.Convert.ToWei(Amount.Value),
                        To = AddressTo,
                        FromAddress = web3.TransactionManager.Account.Address
                    };
                 
                if (Gas != null) transferfuction.Gas = new HexBigInteger(Gas.Value);
                if (GasPrice != null) transferfuction.GasPrice = new HexBigInteger(GasPrice.Value);

                var handler = web3.Eth.GetContractHandler(ContractAddress);
                var transactionHash = await handler.SendRequestAsync(transferfuction);
                MessageBus.Current.SendMessage<TransactionAdded>(new TransactionAdded(transactionHash));
                return transactionHash;
            }
            return null;
        }

        public string GetConfirmationMessage()
        {
            return
                $"Are you sure you want to make this transfer: \n\r To: {AddressTo} \n\r Token Amount: {Amount}";
        }
    }
}