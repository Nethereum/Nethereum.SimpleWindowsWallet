using Nethereum.UI.ViewModels;

namespace Nethereum.SimpleWindowsWallet.Controls
{
    partial class SendTransactionUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSendTransaction = new System.Windows.Forms.Button();
            this.lblAmountInEther = new System.Windows.Forms.Label();
            this.lblToAddress = new System.Windows.Forms.Label();
            this.txtAmountInEther = new System.Windows.Forms.TextBox();
            this.txtToAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGasPrice = new System.Windows.Forms.TextBox();
            this.txtGas = new System.Windows.Forms.TextBox();
            this.errorProviderToAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lblNonce = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtNonce = new System.Windows.Forms.TextBox();
            this.transactionViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderToAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSendTransaction
            // 
            this.btnSendTransaction.Location = new System.Drawing.Point(270, 245);
            this.btnSendTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendTransaction.Name = "btnSendTransaction";
            this.btnSendTransaction.Size = new System.Drawing.Size(143, 28);
            this.btnSendTransaction.TabIndex = 22;
            this.btnSendTransaction.Text = "Send Transaction";
            this.btnSendTransaction.UseVisualStyleBackColor = true;
            // 
            // lblAmountInEther
            // 
            this.lblAmountInEther.AutoSize = true;
            this.lblAmountInEther.Location = new System.Drawing.Point(21, 63);
            this.lblAmountInEther.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountInEther.Name = "lblAmountInEther";
            this.lblAmountInEther.Size = new System.Drawing.Size(113, 17);
            this.lblAmountInEther.TabIndex = 21;
            this.lblAmountInEther.Text = "Amount in Ether:";
            // 
            // lblToAddress
            // 
            this.lblToAddress.AutoSize = true;
            this.lblToAddress.Location = new System.Drawing.Point(21, 27);
            this.lblToAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToAddress.Name = "lblToAddress";
            this.lblToAddress.Size = new System.Drawing.Size(85, 17);
            this.lblToAddress.TabIndex = 20;
            this.lblToAddress.Text = "To Address:";
            // 
            // txtAmountInEther
            // 
            this.txtAmountInEther.Location = new System.Drawing.Point(152, 63);
            this.txtAmountInEther.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmountInEther.Name = "txtAmountInEther";
            this.txtAmountInEther.Size = new System.Drawing.Size(261, 22);
            this.txtAmountInEther.TabIndex = 19;
            // 
            // txtToAddress
            // 
            this.txtToAddress.Location = new System.Drawing.Point(152, 27);
            this.txtToAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtToAddress.Name = "txtToAddress";
            this.txtToAddress.Size = new System.Drawing.Size(261, 22);
            this.txtToAddress.TabIndex = 18;
            this.txtToAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtToAddress_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Gas Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Gas:";
            // 
            // txtGasPrice
            // 
            this.txtGasPrice.Location = new System.Drawing.Point(152, 133);
            this.txtGasPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtGasPrice.Name = "txtGasPrice";
            this.txtGasPrice.Size = new System.Drawing.Size(261, 22);
            this.txtGasPrice.TabIndex = 24;
            // 
            // txtGas
            // 
            this.txtGas.Location = new System.Drawing.Point(152, 97);
            this.txtGas.Margin = new System.Windows.Forms.Padding(4);
            this.txtGas.Name = "txtGas";
            this.txtGas.Size = new System.Drawing.Size(261, 22);
            this.txtGas.TabIndex = 23;
            // 
            // errorProviderToAddress
            // 
            this.errorProviderToAddress.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Data (Optional):";
            // 
            // lblNonce
            // 
            this.lblNonce.AutoSize = true;
            this.lblNonce.Location = new System.Drawing.Point(21, 165);
            this.lblNonce.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNonce.Name = "lblNonce";
            this.lblNonce.Size = new System.Drawing.Size(120, 17);
            this.lblNonce.TabIndex = 30;
            this.lblNonce.Text = "Nonce (Optional):";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(152, 201);
            this.txtData.Margin = new System.Windows.Forms.Padding(4);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(261, 22);
            this.txtData.TabIndex = 29;
            // 
            // txtNonce
            // 
            this.txtNonce.Location = new System.Drawing.Point(152, 165);
            this.txtNonce.Margin = new System.Windows.Forms.Padding(4);
            this.txtNonce.Name = "txtNonce";
            this.txtNonce.Size = new System.Drawing.Size(261, 22);
            this.txtNonce.TabIndex = 28;
            // 
            // transactionViewModelBindingSource
            // 
            this.transactionViewModelBindingSource.DataSource = typeof(TransactionViewModel);
            // 
            // SendTransactionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNonce);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtNonce);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGasPrice);
            this.Controls.Add(this.txtGas);
            this.Controls.Add(this.btnSendTransaction);
            this.Controls.Add(this.lblAmountInEther);
            this.Controls.Add(this.lblToAddress);
            this.Controls.Add(this.txtAmountInEther);
            this.Controls.Add(this.txtToAddress);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SendTransactionUserControl";
            this.Size = new System.Drawing.Size(579, 327);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderToAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendTransaction;
        private System.Windows.Forms.Label lblAmountInEther;
        private System.Windows.Forms.Label lblToAddress;
        private System.Windows.Forms.TextBox txtAmountInEther;
        private System.Windows.Forms.TextBox txtToAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGasPrice;
        private System.Windows.Forms.TextBox txtGas;
        private System.Windows.Forms.ErrorProvider errorProviderToAddress;
        private System.Windows.Forms.BindingSource transactionViewModelBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNonce;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtNonce;
    }
}
