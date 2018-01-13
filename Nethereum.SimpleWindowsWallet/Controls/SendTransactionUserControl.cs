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
    public partial class SendTransactionUserControl : UserControl, IViewFor<SendTransactionViewModel>
    {
        public SendTransactionUserControl()
        {
            InitializeComponent();

            this.Bind(ViewModel, x => x.AddressTo, x => x.txtToAddress.Text);
            this.Bind(ViewModel, x => x.AmountInEther, x => x.txtAmountInEther.Text);
            this.Bind(ViewModel, x => x.Gas, x => x.txtGas.Text);
            this.Bind(ViewModel, x => x.GasPrice, x => x.txtGasPrice.Text);
            this.Bind(ViewModel, x => x.Nonce, x => x.txtNonce.Text);
            this.Bind(ViewModel, x => x.Data, x => x.txtData.Text);

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
            set { ViewModel = (SendTransactionViewModel)value; }
        }

        public SendTransactionViewModel ViewModel { get; set; }

        private void txtToAddress_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
