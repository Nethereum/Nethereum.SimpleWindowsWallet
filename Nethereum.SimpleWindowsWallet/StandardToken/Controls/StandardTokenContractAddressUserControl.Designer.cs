namespace Nethereum.SimpleWindowsWallet.StandardToken.Controls
{
    partial class StandardTokenContractAddressUserControl
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
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtContractAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(13, 15);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(91, 13);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "Contract Address:";
            // 
            // txtContractAddress
            // 
            this.txtContractAddress.Location = new System.Drawing.Point(116, 14);
            this.txtContractAddress.Name = "txtContractAddress";
            this.txtContractAddress.Size = new System.Drawing.Size(197, 20);
            this.txtContractAddress.TabIndex = 21;
            // 
            // StandardTokenContractAddressUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtContractAddress);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StandardTokenContractAddressUserControl";
            this.Size = new System.Drawing.Size(402, 51);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtContractAddress;
    }
}
