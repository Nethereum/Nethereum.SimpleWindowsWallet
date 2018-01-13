namespace Nethereum.SimpleWindowsWallet.Controls.StandardToken
{
    partial class StandardTokenTransferUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGasPrice = new System.Windows.Forms.TextBox();
            this.txtGas = new System.Windows.Forms.TextBox();
            this.btnSendTransaction = new System.Windows.Forms.Button();
            this.lblAmountInEther = new System.Windows.Forms.Label();
            this.lblToAddress = new System.Windows.Forms.Label();
            this.txtTokenAmount = new System.Windows.Forms.TextBox();
            this.txtToAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Gas Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Gas (Optional Calculated):";
            // 
            // txtGasPrice
            // 
            this.txtGasPrice.Location = new System.Drawing.Point(157, 102);
            this.txtGasPrice.Name = "txtGasPrice";
            this.txtGasPrice.Size = new System.Drawing.Size(197, 20);
            this.txtGasPrice.TabIndex = 33;
            // 
            // txtGas
            // 
            this.txtGas.Location = new System.Drawing.Point(157, 72);
            this.txtGas.Name = "txtGas";
            this.txtGas.Size = new System.Drawing.Size(197, 20);
            this.txtGas.TabIndex = 32;
            // 
            // btnSendTransaction
            // 
            this.btnSendTransaction.Location = new System.Drawing.Point(245, 140);
            this.btnSendTransaction.Name = "btnSendTransaction";
            this.btnSendTransaction.Size = new System.Drawing.Size(107, 23);
            this.btnSendTransaction.TabIndex = 31;
            this.btnSendTransaction.Text = "Send Transaction";
            this.btnSendTransaction.UseVisualStyleBackColor = true;
            // 
            // lblAmountInEther
            // 
            this.lblAmountInEther.AutoSize = true;
            this.lblAmountInEther.Location = new System.Drawing.Point(21, 45);
            this.lblAmountInEther.Name = "lblAmountInEther";
            this.lblAmountInEther.Size = new System.Drawing.Size(80, 13);
            this.lblAmountInEther.TabIndex = 30;
            this.lblAmountInEther.Text = "Token Amount:";
            // 
            // lblToAddress
            // 
            this.lblToAddress.AutoSize = true;
            this.lblToAddress.Location = new System.Drawing.Point(21, 15);
            this.lblToAddress.Name = "lblToAddress";
            this.lblToAddress.Size = new System.Drawing.Size(64, 13);
            this.lblToAddress.TabIndex = 29;
            this.lblToAddress.Text = "To Address:";
            // 
            // txtTokenAmount
            // 
            this.txtTokenAmount.Location = new System.Drawing.Point(157, 45);
            this.txtTokenAmount.Name = "txtTokenAmount";
            this.txtTokenAmount.Size = new System.Drawing.Size(197, 20);
            this.txtTokenAmount.TabIndex = 28;
            // 
            // txtToAddress
            // 
            this.txtToAddress.Location = new System.Drawing.Point(157, 15);
            this.txtToAddress.Name = "txtToAddress";
            this.txtToAddress.Size = new System.Drawing.Size(197, 20);
            this.txtToAddress.TabIndex = 27;
            // 
            // StandardTokenTransferUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGasPrice);
            this.Controls.Add(this.txtGas);
            this.Controls.Add(this.btnSendTransaction);
            this.Controls.Add(this.lblAmountInEther);
            this.Controls.Add(this.lblToAddress);
            this.Controls.Add(this.txtTokenAmount);
            this.Controls.Add(this.txtToAddress);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StandardTokenTransferUserControl";
            this.Size = new System.Drawing.Size(378, 176);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGasPrice;
        private System.Windows.Forms.TextBox txtGas;
        private System.Windows.Forms.Button btnSendTransaction;
        private System.Windows.Forms.Label lblAmountInEther;
        private System.Windows.Forms.Label lblToAddress;
        private System.Windows.Forms.TextBox txtTokenAmount;
        private System.Windows.Forms.TextBox txtToAddress;
    }
}
