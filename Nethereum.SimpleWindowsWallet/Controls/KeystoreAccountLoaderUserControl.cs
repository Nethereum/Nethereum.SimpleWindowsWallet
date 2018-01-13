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
    public partial class KeystoreAccountLoaderUserControl : UserControl , IViewFor<KeyStoreLoaderViewModel>
    {
        public KeystoreAccountLoaderUserControl()
        {
            InitializeComponent();
            this.Bind(ViewModel, x => x.FileName, x => x.txtFileKeyStore.Text);
            this.Bind(ViewModel, x => x.Password, x => x.txtPasswordKeyStore.Text);
            this.BindCommand(ViewModel, x => x.LoadPrivateKeyCommand, x => x.btnLoadPrivateKeyFromKeyStore);
        }

        private void btnLoadPrivateKeyFromKeyStore_Click(object sender, EventArgs e)
        {
            fileOpenerKeyStore.ShowDialog(this);
        }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (KeyStoreLoaderViewModel)value;
        }

        public KeyStoreLoaderViewModel ViewModel { get; set; }

        private void fileOpenerKeyStore_FileOk(object sender, CancelEventArgs e)
        {
            txtFileKeyStore.Text = fileOpenerKeyStore.FileName;
        }
    }
}
