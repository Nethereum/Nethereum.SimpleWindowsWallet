using System.ComponentModel;
using System.Windows.Forms;
using Nethereum.SimpleWindowsWallet.StandardToken.ViewModels;
using ReactiveUI;

namespace Nethereum.SimpleWindowsWallet.StandardToken.Controls
{
    public partial class StandardTokenBalanceOfUserControl : UserControl, IViewFor<StandardTokenBalanceOfViewModel>
    {
        public StandardTokenBalanceOfUserControl()
        {
            InitializeComponent();
            this.Bind(ViewModel, x => x.Balance, x => x.lblAccountBalance.Text);
            this.BindCommand(ViewModel, x => x.RefreshBalanceCommand, x => x.btnRefreshBalance);
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (StandardTokenBalanceOfViewModel)value; }
        }

        public StandardTokenBalanceOfViewModel ViewModel { get; set; }
    }
}
