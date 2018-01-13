using System.Windows.Forms;
using Nethereum.StandardToken.UI.ViewModels;
using ReactiveUI;

namespace Nethereum.SimpleWindowsWallet.Controls.StandardToken
{
    public partial class StandardTokenContractAddressUserControl : UserControl, IViewFor<StandardTokenContractAddressViewModel>
    {
        public StandardTokenContractAddressUserControl()
        {
            InitializeComponent();
            this.Bind(ViewModel, x => x.ContractAddress, x => x.txtContractAddress.Text);
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (StandardTokenContractAddressViewModel)value; }
        }

        public StandardTokenContractAddressViewModel ViewModel { get; set; }
    }
}
