﻿using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Nethereum.SimpleWindowsWallet.StandardToken.ViewModels;
using Nethereum.SimpleWindowsWallet.ViewModels;
using ReactiveUI;

namespace Nethereum.SimpleWindowsWallet
{
    public partial class MainForm : Form, IViewFor<AccountViewModel>
    {
        private KeyStoreLoaderViewModel _keyStoreLoaderViewModel;
        private AccountViewModel _accountViewModel;
        private SendTransactionViewModel _sendTransactionViewModel;
        private PrivateKeyLoaderViewModel _privateKeyLoaderViewModel;
        private HdWalletAccountLoaderViewModel _hdWalletAccountLoaderViewModel;
        private StandardTokenBalanceOfViewModel _standardTokenBalanceOfViewModel;
        private TransactionsViewModel _transactionsViewModel;
        private StandardTokenContractAddressViewModel _standardTokenContractAddressViewModel;
        private StandardTokenTransferViewModel _standardTokenTransferViewModel;

        public MainForm()
        {
            InitializeComponent();
            _accountViewModel = new AccountViewModel();
            ViewModel = _accountViewModel;

            _sendTransactionViewModel = new SendTransactionViewModel();
            transferUserControl1.ViewModel = _sendTransactionViewModel;
            _keyStoreLoaderViewModel = new KeyStoreLoaderViewModel();
            keystoreAccountLoaderUserControl3.ViewModel = _keyStoreLoaderViewModel;
            _privateKeyLoaderViewModel = new PrivateKeyLoaderViewModel();
            privateKeyAccountLoaderUserControl1.ViewModel = _privateKeyLoaderViewModel;
            _hdWalletAccountLoaderViewModel = new HdWalletAccountLoaderViewModel();
            hdWalletAccountLoaderUserControl1.ViewModel = _hdWalletAccountLoaderViewModel;

            _standardTokenBalanceOfViewModel = new StandardTokenBalanceOfViewModel();
            standardTokenBalanceOfUserControl1.ViewModel = _standardTokenBalanceOfViewModel;

            _standardTokenContractAddressViewModel = new StandardTokenContractAddressViewModel();
            standardTokenContractAddressUserControl1.ViewModel = _standardTokenContractAddressViewModel;

            _standardTokenTransferViewModel = new StandardTokenTransferViewModel();
            standardTokenTransferUserControl1.ViewModel = _standardTokenTransferViewModel;

            _transactionsViewModel = new TransactionsViewModel();
            transactionsUserControl1.ViewModel = _transactionsViewModel;

            this.Bind(ViewModel, x => x.Address, x => x.txtCurrentAccount.Text);
            this.Bind(ViewModel, x => x.PrivateKey, x => x.txtPrivateKey.Text);
            this.Bind(ViewModel, x => x.Balance, x => x.lblAccountBalance.Text);
            this.Bind(ViewModel, x => x.Url, x => x.cmbUrl.Text);
            this.BindCommand(ViewModel, x => x.RefreshBalanceCommand, x => x.btnRefreshBalance);

            ViewModel.Url = "https://mainnet.infura.io";
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (AccountViewModel)value; }
        }

        public AccountViewModel ViewModel { get; set; }
    }
}