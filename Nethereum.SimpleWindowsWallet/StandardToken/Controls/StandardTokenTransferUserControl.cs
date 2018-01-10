using System.ComponentModel;
using System.Windows.Forms;
using Nethereum.SimpleWindowsWallet.StandardToken.ViewModels;
using ReactiveUI;

namespace Nethereum.SimpleWindowsWallet.StandardToken.Controls
{
    public partial class StandardTokenTransferUserControl : UserControl, IViewFor<StandardTokenTransferViewModel>
    {
        public StandardTokenTransferUserControl()
        {
            InitializeComponent();
            this.Bind(ViewModel, x => x.AddressTo, x => x.txtToAddress.Text);
            this.Bind(ViewModel, x => x.Amount, x => x.txtTokenAmount.Text);
            this.Bind(ViewModel, x => x.Gas, x => x.txtGas.Text);
            this.Bind(ViewModel, x => x.GasPrice, x => x.txtGasPrice.Text);
            this.BindCommand(ViewModel, x => x.ExecuteTransactionCommand, x => x.btnSendTransaction);

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                this.WhenActivated(
                    d =>
                    {
                        d(this.ViewModel
                            .ConfirmTransfer
                            .RegisterHandler(
                                interaction =>
                                {
                                    var dialogResult = MessageBox.Show(
                                        interaction.Input,
                                        "Confirm Transaction",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question
                                    );

                                    if (dialogResult == DialogResult.Yes)
                                    {
                                        interaction.SetOutput(true);
                                    }
                                    else
                                    {
                                        interaction.SetOutput(false);
                                    }
                                }));
                    });
            }
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (StandardTokenTransferViewModel)value; }
        }

        public StandardTokenTransferViewModel ViewModel { get; set; }
    }
}
