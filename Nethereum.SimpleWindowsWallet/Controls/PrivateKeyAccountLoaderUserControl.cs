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

namespace Nethereum.SimpleWindowsWallet
{
    public partial class PrivateKeyAccountLoaderUserControl : UserControl , IViewFor<PrivateKeyLoaderViewModel>
    {
        public PrivateKeyAccountLoaderUserControl()
        {
            InitializeComponent();
            this.Bind(ViewModel, x => x.PrivateKey, x => x.txtPrivateKey.Text);
            this.BindCommand(ViewModel, x => x.LoadAccountFromPrivateKeyCommand, x => x.btnLoadAccountFromPrivateKey);
        }

      
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (PrivateKeyLoaderViewModel)value;
        }

        public PrivateKeyLoaderViewModel ViewModel { get; set; }
    }
}
