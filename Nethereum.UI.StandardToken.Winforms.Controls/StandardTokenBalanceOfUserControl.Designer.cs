namespace Nethereum.SimpleWindowsWallet.StandardToken.Controls
{
    partial class StandardTokenBalanceOfUserControl
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
            this.btnRefreshBalance = new System.Windows.Forms.Button();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.lblTextAccountBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRefreshBalance
            // 
            this.btnRefreshBalance.Location = new System.Drawing.Point(274, 7);
            this.btnRefreshBalance.Name = "btnRefreshBalance";
            this.btnRefreshBalance.Size = new System.Drawing.Size(120, 23);
            this.btnRefreshBalance.TabIndex = 7;
            this.btnRefreshBalance.Text = "Refresh Balance";
            this.btnRefreshBalance.UseVisualStyleBackColor = true;
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.Location = new System.Drawing.Point(104, 7);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(13, 13);
            this.lblAccountBalance.TabIndex = 6;
            this.lblAccountBalance.Text = "0";
            // 
            // lblTextAccountBalance
            // 
            this.lblTextAccountBalance.AutoSize = true;
            this.lblTextAccountBalance.Location = new System.Drawing.Point(4, 9);
            this.lblTextAccountBalance.Name = "lblTextAccountBalance";
            this.lblTextAccountBalance.Size = new System.Drawing.Size(49, 13);
            this.lblTextAccountBalance.TabIndex = 5;
            this.lblTextAccountBalance.Text = "Balance:";
            // 
            // StandardTokenBalanceOfUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefreshBalance);
            this.Controls.Add(this.lblAccountBalance);
            this.Controls.Add(this.lblTextAccountBalance);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StandardTokenBalanceOfUserControl";
            this.Size = new System.Drawing.Size(419, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefreshBalance;
        private System.Windows.Forms.Label lblAccountBalance;
        private System.Windows.Forms.Label lblTextAccountBalance;
    }
}
