namespace Nethereum.SimpleWindowsWallet
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCurrentAccount = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblPrivateKey = new System.Windows.Forms.Label();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.btnRefreshBalance = new System.Windows.Forms.Button();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.lblTextAccountBalance = new System.Windows.Forms.Label();
            this.fileOpenerKeyStore = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbUrl = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageTransactions = new System.Windows.Forms.TabPage();
            this.transactionsUserControl1 = new Nethereum.SimpleWindowsWallet.Controls.TransactionsUserControl();
            this.panelSendTransactionStandardToken = new System.Windows.Forms.Panel();
            this.gbTransfer = new System.Windows.Forms.GroupBox();
            this.transferUserControl1 = new Nethereum.SimpleWindowsWallet.Controls.SendTransactionUserControl();
            this.gbStandardToken = new System.Windows.Forms.GroupBox();
            this.standardTokenBalanceOfUserControl1 = new Nethereum.SimpleWindowsWallet.StandardToken.Controls.StandardTokenBalanceOfUserControl();
            this.standardTokenTransferUserControl1 = new Nethereum.SimpleWindowsWallet.StandardToken.Controls.StandardTokenTransferUserControl();
            this.standardTokenContractAddressUserControl1 = new Nethereum.SimpleWindowsWallet.StandardToken.Controls.StandardTokenContractAddressUserControl();
            this.tabStepMainLoadAccount = new System.Windows.Forms.TabPage();
            this.tabPageLoadAccount = new System.Windows.Forms.TabControl();
            this.tabPageLoadAccountFromPrivateKey = new System.Windows.Forms.TabPage();
            this.privateKeyAccountLoaderUserControl1 = new Nethereum.SimpleWindowsWallet.PrivateKeyAccountLoaderUserControl();
            this.tabPageHdWallet = new System.Windows.Forms.TabPage();
            this.hdWalletAccountLoaderUserControl1 = new Nethereum.SimpleWindowsWallet.Controls.HDWalletAccountLoaderUserControl();
            this.tabPageLoadAccountFromFile = new System.Windows.Forms.TabPage();
            this.keystoreAccountLoaderUserControl3 = new Nethereum.SimpleWindowsWallet.KeystoreAccountLoaderUserControl();
            this.tabSteps = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.tabPageTransactions.SuspendLayout();
            this.panelSendTransactionStandardToken.SuspendLayout();
            this.gbTransfer.SuspendLayout();
            this.gbStandardToken.SuspendLayout();
            this.tabStepMainLoadAccount.SuspendLayout();
            this.tabPageLoadAccount.SuspendLayout();
            this.tabPageLoadAccountFromPrivateKey.SuspendLayout();
            this.tabPageHdWallet.SuspendLayout();
            this.tabPageLoadAccountFromFile.SuspendLayout();
            this.tabSteps.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCurrentAccount
            // 
            this.txtCurrentAccount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCurrentAccount.Location = new System.Drawing.Point(127, 17);
            this.txtCurrentAccount.Name = "txtCurrentAccount";
            this.txtCurrentAccount.ReadOnly = true;
            this.txtCurrentAccount.Size = new System.Drawing.Size(396, 20);
            this.txtCurrentAccount.TabIndex = 0;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(29, 20);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(91, 13);
            this.lblAccount.TabIndex = 1;
            this.lblAccount.Text = "Account Address:";
            // 
            // lblPrivateKey
            // 
            this.lblPrivateKey.AutoSize = true;
            this.lblPrivateKey.Location = new System.Drawing.Point(29, 46);
            this.lblPrivateKey.Name = "lblPrivateKey";
            this.lblPrivateKey.Size = new System.Drawing.Size(64, 13);
            this.lblPrivateKey.TabIndex = 2;
            this.lblPrivateKey.Text = "Private Key:";
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPrivateKey.Location = new System.Drawing.Point(127, 43);
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.ReadOnly = true;
            this.txtPrivateKey.Size = new System.Drawing.Size(396, 20);
            this.txtPrivateKey.TabIndex = 3;
            this.txtPrivateKey.UseSystemPasswordChar = true;
            // 
            // btnRefreshBalance
            // 
            this.btnRefreshBalance.Location = new System.Drawing.Point(403, 67);
            this.btnRefreshBalance.Name = "btnRefreshBalance";
            this.btnRefreshBalance.Size = new System.Drawing.Size(120, 23);
            this.btnRefreshBalance.TabIndex = 4;
            this.btnRefreshBalance.Text = "Refresh Balance";
            this.btnRefreshBalance.UseVisualStyleBackColor = true;
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.Location = new System.Drawing.Point(129, 71);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(13, 13);
            this.lblAccountBalance.TabIndex = 3;
            this.lblAccountBalance.Text = "0";
            // 
            // lblTextAccountBalance
            // 
            this.lblTextAccountBalance.AutoSize = true;
            this.lblTextAccountBalance.Location = new System.Drawing.Point(29, 72);
            this.lblTextAccountBalance.Name = "lblTextAccountBalance";
            this.lblTextAccountBalance.Size = new System.Drawing.Size(89, 13);
            this.lblTextAccountBalance.TabIndex = 2;
            this.lblTextAccountBalance.Text = "Balance In Ether:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefreshBalance);
            this.panel1.Controls.Add(this.cmbUrl);
            this.panel1.Controls.Add(this.lblAccountBalance);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTextAccountBalance);
            this.panel1.Controls.Add(this.lblAccount);
            this.panel1.Controls.Add(this.lblPrivateKey);
            this.panel1.Controls.Add(this.txtPrivateKey);
            this.panel1.Controls.Add(this.txtCurrentAccount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 131);
            this.panel1.TabIndex = 5;
            // 
            // cmbUrl
            // 
            this.cmbUrl.FormattingEnabled = true;
            this.cmbUrl.Items.AddRange(new object[] {
            "https://mainnet.infura.io",
            "http://localhost:8545"});
            this.cmbUrl.Location = new System.Drawing.Point(127, 92);
            this.cmbUrl.Name = "cmbUrl";
            this.cmbUrl.Size = new System.Drawing.Size(396, 21);
            this.cmbUrl.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "RPC Url:";
            // 
            // tabPageTransactions
            // 
            this.tabPageTransactions.Controls.Add(this.panelSendTransactionStandardToken);
            this.tabPageTransactions.Controls.Add(this.transactionsUserControl1);
            this.tabPageTransactions.Location = new System.Drawing.Point(4, 22);
            this.tabPageTransactions.Name = "tabPageTransactions";
            this.tabPageTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTransactions.Size = new System.Drawing.Size(844, 590);
            this.tabPageTransactions.TabIndex = 4;
            this.tabPageTransactions.Text = "Send Transaction / Standard Token";
            this.tabPageTransactions.UseVisualStyleBackColor = true;
            // 
            // transactionsUserControl1
            // 
            this.transactionsUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionsUserControl1.Location = new System.Drawing.Point(3, 3);
            this.transactionsUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.transactionsUserControl1.Name = "transactionsUserControl1";
            this.transactionsUserControl1.Size = new System.Drawing.Size(838, 584);
            this.transactionsUserControl1.TabIndex = 1;
            this.transactionsUserControl1.ViewModel = null;
            // 
            // panelSendTransactionStandardToken
            // 
            this.panelSendTransactionStandardToken.Controls.Add(this.gbStandardToken);
            this.panelSendTransactionStandardToken.Controls.Add(this.gbTransfer);
            this.panelSendTransactionStandardToken.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSendTransactionStandardToken.Location = new System.Drawing.Point(3, 3);
            this.panelSendTransactionStandardToken.Name = "panelSendTransactionStandardToken";
            this.panelSendTransactionStandardToken.Size = new System.Drawing.Size(838, 299);
            this.panelSendTransactionStandardToken.TabIndex = 3;
            // 
            // gbTransfer
            // 
            this.gbTransfer.Controls.Add(this.transferUserControl1);
            this.gbTransfer.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbTransfer.Location = new System.Drawing.Point(0, 0);
            this.gbTransfer.Name = "gbTransfer";
            this.gbTransfer.Size = new System.Drawing.Size(394, 299);
            this.gbTransfer.TabIndex = 1;
            this.gbTransfer.TabStop = false;
            this.gbTransfer.Text = "Send Transaction";
            // 
            // transferUserControl1
            // 
            this.transferUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transferUserControl1.Location = new System.Drawing.Point(3, 16);
            this.transferUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.transferUserControl1.Name = "transferUserControl1";
            this.transferUserControl1.Size = new System.Drawing.Size(388, 280);
            this.transferUserControl1.TabIndex = 0;
            this.transferUserControl1.ViewModel = null;
            // 
            // gbStandardToken
            // 
            this.gbStandardToken.Controls.Add(this.standardTokenContractAddressUserControl1);
            this.gbStandardToken.Controls.Add(this.standardTokenTransferUserControl1);
            this.gbStandardToken.Controls.Add(this.standardTokenBalanceOfUserControl1);
            this.gbStandardToken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbStandardToken.Location = new System.Drawing.Point(394, 0);
            this.gbStandardToken.Name = "gbStandardToken";
            this.gbStandardToken.Size = new System.Drawing.Size(444, 299);
            this.gbStandardToken.TabIndex = 3;
            this.gbStandardToken.TabStop = false;
            this.gbStandardToken.Text = "Standard Token";
            // 
            // standardTokenBalanceOfUserControl1
            // 
            this.standardTokenBalanceOfUserControl1.Location = new System.Drawing.Point(23, 71);
            this.standardTokenBalanceOfUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.standardTokenBalanceOfUserControl1.Name = "standardTokenBalanceOfUserControl1";
            this.standardTokenBalanceOfUserControl1.Size = new System.Drawing.Size(419, 41);
            this.standardTokenBalanceOfUserControl1.TabIndex = 2;
            this.standardTokenBalanceOfUserControl1.ViewModel = null;
            // 
            // standardTokenTransferUserControl1
            // 
            this.standardTokenTransferUserControl1.Location = new System.Drawing.Point(5, 108);
            this.standardTokenTransferUserControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.standardTokenTransferUserControl1.Name = "standardTokenTransferUserControl1";
            this.standardTokenTransferUserControl1.Size = new System.Drawing.Size(378, 176);
            this.standardTokenTransferUserControl1.TabIndex = 3;
            // 
            // standardTokenContractAddressUserControl1
            // 
            this.standardTokenContractAddressUserControl1.Location = new System.Drawing.Point(17, 18);
            this.standardTokenContractAddressUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.standardTokenContractAddressUserControl1.Name = "standardTokenContractAddressUserControl1";
            this.standardTokenContractAddressUserControl1.Size = new System.Drawing.Size(402, 51);
            this.standardTokenContractAddressUserControl1.TabIndex = 4;
            this.standardTokenContractAddressUserControl1.ViewModel = null;
            // 
            // tabStepMainLoadAccount
            // 
            this.tabStepMainLoadAccount.Controls.Add(this.tabPageLoadAccount);
            this.tabStepMainLoadAccount.Location = new System.Drawing.Point(4, 22);
            this.tabStepMainLoadAccount.Name = "tabStepMainLoadAccount";
            this.tabStepMainLoadAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabStepMainLoadAccount.Size = new System.Drawing.Size(844, 590);
            this.tabStepMainLoadAccount.TabIndex = 3;
            this.tabStepMainLoadAccount.Text = "Load Account";
            this.tabStepMainLoadAccount.UseVisualStyleBackColor = true;
            // 
            // tabPageLoadAccount
            // 
            this.tabPageLoadAccount.Controls.Add(this.tabPageLoadAccountFromFile);
            this.tabPageLoadAccount.Controls.Add(this.tabPageHdWallet);
            this.tabPageLoadAccount.Controls.Add(this.tabPageLoadAccountFromPrivateKey);
            this.tabPageLoadAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageLoadAccount.Location = new System.Drawing.Point(3, 3);
            this.tabPageLoadAccount.Name = "tabPageLoadAccount";
            this.tabPageLoadAccount.SelectedIndex = 0;
            this.tabPageLoadAccount.Size = new System.Drawing.Size(838, 584);
            this.tabPageLoadAccount.TabIndex = 0;
            // 
            // tabPageLoadAccountFromPrivateKey
            // 
            this.tabPageLoadAccountFromPrivateKey.Controls.Add(this.privateKeyAccountLoaderUserControl1);
            this.tabPageLoadAccountFromPrivateKey.Location = new System.Drawing.Point(4, 22);
            this.tabPageLoadAccountFromPrivateKey.Name = "tabPageLoadAccountFromPrivateKey";
            this.tabPageLoadAccountFromPrivateKey.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLoadAccountFromPrivateKey.Size = new System.Drawing.Size(830, 558);
            this.tabPageLoadAccountFromPrivateKey.TabIndex = 2;
            this.tabPageLoadAccountFromPrivateKey.Text = "Load Account From Private Key";
            this.tabPageLoadAccountFromPrivateKey.UseVisualStyleBackColor = true;
            // 
            // privateKeyAccountLoaderUserControl1
            // 
            this.privateKeyAccountLoaderUserControl1.Location = new System.Drawing.Point(1, 6);
            this.privateKeyAccountLoaderUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.privateKeyAccountLoaderUserControl1.Name = "privateKeyAccountLoaderUserControl1";
            this.privateKeyAccountLoaderUserControl1.Size = new System.Drawing.Size(406, 104);
            this.privateKeyAccountLoaderUserControl1.TabIndex = 0;
            this.privateKeyAccountLoaderUserControl1.ViewModel = null;
            // 
            // tabPageHdWallet
            // 
            this.tabPageHdWallet.Controls.Add(this.hdWalletAccountLoaderUserControl1);
            this.tabPageHdWallet.Location = new System.Drawing.Point(4, 22);
            this.tabPageHdWallet.Name = "tabPageHdWallet";
            this.tabPageHdWallet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHdWallet.Size = new System.Drawing.Size(830, 558);
            this.tabPageHdWallet.TabIndex = 1;
            this.tabPageHdWallet.Text = "Load from HD Wallet (backup words)";
            this.tabPageHdWallet.UseVisualStyleBackColor = true;
            // 
            // hdWalletAccountLoaderUserControl1
            // 
            this.hdWalletAccountLoaderUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hdWalletAccountLoaderUserControl1.Location = new System.Drawing.Point(3, 3);
            this.hdWalletAccountLoaderUserControl1.Margin = new System.Windows.Forms.Padding(4);
            this.hdWalletAccountLoaderUserControl1.Name = "hdWalletAccountLoaderUserControl1";
            this.hdWalletAccountLoaderUserControl1.Size = new System.Drawing.Size(824, 223);
            this.hdWalletAccountLoaderUserControl1.TabIndex = 0;
            this.hdWalletAccountLoaderUserControl1.ViewModel = null;
            // 
            // tabPageLoadAccountFromFile
            // 
            this.tabPageLoadAccountFromFile.Controls.Add(this.keystoreAccountLoaderUserControl3);
            this.tabPageLoadAccountFromFile.Location = new System.Drawing.Point(4, 22);
            this.tabPageLoadAccountFromFile.Name = "tabPageLoadAccountFromFile";
            this.tabPageLoadAccountFromFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLoadAccountFromFile.Size = new System.Drawing.Size(830, 558);
            this.tabPageLoadAccountFromFile.TabIndex = 0;
            this.tabPageLoadAccountFromFile.Text = "Load Account From File";
            this.tabPageLoadAccountFromFile.UseVisualStyleBackColor = true;
            // 
            // keystoreAccountLoaderUserControl3
            // 
            this.keystoreAccountLoaderUserControl3.Location = new System.Drawing.Point(0, 6);
            this.keystoreAccountLoaderUserControl3.Margin = new System.Windows.Forms.Padding(4);
            this.keystoreAccountLoaderUserControl3.Name = "keystoreAccountLoaderUserControl3";
            this.keystoreAccountLoaderUserControl3.Size = new System.Drawing.Size(440, 157);
            this.keystoreAccountLoaderUserControl3.TabIndex = 0;
            this.keystoreAccountLoaderUserControl3.ViewModel = null;
            // 
            // tabSteps
            // 
            this.tabSteps.Controls.Add(this.tabStepMainLoadAccount);
            this.tabSteps.Controls.Add(this.tabPageTransactions);
            this.tabSteps.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabSteps.Location = new System.Drawing.Point(0, 137);
            this.tabSteps.Name = "tabSteps";
            this.tabSteps.SelectedIndex = 0;
            this.tabSteps.Size = new System.Drawing.Size(852, 616);
            this.tabSteps.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabSteps);
            this.Name = "MainForm";
            this.Text = "Nethereum - Simple Wallet";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageTransactions.ResumeLayout(false);
            this.panelSendTransactionStandardToken.ResumeLayout(false);
            this.gbTransfer.ResumeLayout(false);
            this.gbStandardToken.ResumeLayout(false);
            this.tabStepMainLoadAccount.ResumeLayout(false);
            this.tabPageLoadAccount.ResumeLayout(false);
            this.tabPageLoadAccountFromPrivateKey.ResumeLayout(false);
            this.tabPageHdWallet.ResumeLayout(false);
            this.tabPageLoadAccountFromFile.ResumeLayout(false);
            this.tabSteps.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrentAccount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblPrivateKey;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.OpenFileDialog fileOpenerKeyStore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAccountBalance;
        private System.Windows.Forms.Label lblTextAccountBalance;
        private System.Windows.Forms.ComboBox cmbUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefreshBalance;
        private System.Windows.Forms.TabPage tabPageTransactions;
        private System.Windows.Forms.Panel panelSendTransactionStandardToken;
        private System.Windows.Forms.GroupBox gbStandardToken;
        private StandardToken.Controls.StandardTokenContractAddressUserControl standardTokenContractAddressUserControl1;
        private StandardToken.Controls.StandardTokenTransferUserControl standardTokenTransferUserControl1;
        private StandardToken.Controls.StandardTokenBalanceOfUserControl standardTokenBalanceOfUserControl1;
        private System.Windows.Forms.GroupBox gbTransfer;
        private Controls.SendTransactionUserControl transferUserControl1;
        private Controls.TransactionsUserControl transactionsUserControl1;
        private System.Windows.Forms.TabPage tabStepMainLoadAccount;
        private System.Windows.Forms.TabControl tabPageLoadAccount;
        private System.Windows.Forms.TabPage tabPageLoadAccountFromFile;
        private KeystoreAccountLoaderUserControl keystoreAccountLoaderUserControl3;
        private System.Windows.Forms.TabPage tabPageHdWallet;
        private Controls.HDWalletAccountLoaderUserControl hdWalletAccountLoaderUserControl1;
        private System.Windows.Forms.TabPage tabPageLoadAccountFromPrivateKey;
        private PrivateKeyAccountLoaderUserControl privateKeyAccountLoaderUserControl1;
        private System.Windows.Forms.TabControl tabSteps;
    }
}

