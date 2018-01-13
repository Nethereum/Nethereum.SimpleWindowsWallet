using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nethereum.UI.ViewModels;
using ReactiveUI;
using ReactiveUI.Winforms;

namespace Nethereum.SimpleWindowsWallet.Controls
{
    public partial class TransactionsUserControl : UserControl, IViewFor<TransactionsViewModel>
    {
        public TransactionsUserControl()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                this.WhenActivated(
                    d =>
                    {
                        //transactions list
                        this.Transactions = this.ViewModel.Transactions.CreateDerivedBindingList(x => x);
                        this.ViewModel.Transactions.ItemChanged.Subscribe(_ =>
                        {
                            this.Transactions.Reset();

                        });
                        this.dgTransactions.DataSource = this.Transactions;
                    });
            }
        }

        private IReactiveDerivedBindingList<TransactionViewModel> Transactions { get; set; }
        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (TransactionsViewModel)value; }
        }

        public TransactionsViewModel ViewModel { get; set; }
    }
}
