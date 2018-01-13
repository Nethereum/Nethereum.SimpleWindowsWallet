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
    public partial class HDWalletAccountLoaderUserControl : UserControl, IViewFor<HdWalletAccountLoaderViewModel>
    {
        public HDWalletAccountLoaderUserControl()
        {
            InitializeComponent();
            this.Bind(ViewModel, x => x.SeedPassword, x => x.txtPassword.Text);
            this.Bind(ViewModel, x => x.Words, x => x.txtWords.Text);
            this.BindCommand(ViewModel, x => x.LoadAccountsCommand, x => x.btnLoadHdAccounts);

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                this.WhenActivated(d =>
                {
                    this.Accounts = this.ViewModel.Accounts.CreateDerivedBindingList(x => x);
                    this.ViewModel.Accounts.ItemChanged.Subscribe(_ => this.Accounts.Reset());
                    this.dgAccounts.DataSource = this.Accounts;

                });

                dgAccounts.CellClick += dgAccounts_CellClick;
            }
        }

        private void dgAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == btnloadAccount.Index && e.RowIndex >= 0)
            {
                var vm = ViewModel.Accounts[e.RowIndex];
                vm.LoadAccountFromPrivateKeyCommand.Execute().Subscribe();
            }
        }


        private IReactiveDerivedBindingList<HdWalletAccountViewModel> Accounts { get; set; }
        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (HdWalletAccountLoaderViewModel) value; }
        }

        public HdWalletAccountLoaderViewModel ViewModel { get; set; }
    }
}
