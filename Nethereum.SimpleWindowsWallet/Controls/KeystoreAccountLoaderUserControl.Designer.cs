namespace Nethereum.SimpleWindowsWallet
{
    partial class KeystoreAccountLoaderUserControl
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
            this.btnLoadPrivateKeyFromKeyStore = new System.Windows.Forms.Button();
            this.lblKeyStoreFilePassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasswordKeyStore = new System.Windows.Forms.TextBox();
            this.txtFileKeyStore = new System.Windows.Forms.TextBox();
            this.btnOpenFileKeyStore = new System.Windows.Forms.Button();
            this.fileOpenerKeyStore = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnLoadPrivateKeyFromKeyStore
            // 
            this.btnLoadPrivateKeyFromKeyStore.Location = new System.Drawing.Point(185, 91);
            this.btnLoadPrivateKeyFromKeyStore.Name = "btnLoadPrivateKeyFromKeyStore";
            this.btnLoadPrivateKeyFromKeyStore.Size = new System.Drawing.Size(207, 23);
            this.btnLoadPrivateKeyFromKeyStore.TabIndex = 17;
            this.btnLoadPrivateKeyFromKeyStore.Text = "Load Private Key From File";
            this.btnLoadPrivateKeyFromKeyStore.UseVisualStyleBackColor = true;
            // 
            // lblKeyStoreFilePassword
            // 
            this.lblKeyStoreFilePassword.AutoSize = true;
            this.lblKeyStoreFilePassword.Location = new System.Drawing.Point(20, 50);
            this.lblKeyStoreFilePassword.Name = "lblKeyStoreFilePassword";
            this.lblKeyStoreFilePassword.Size = new System.Drawing.Size(56, 13);
            this.lblKeyStoreFilePassword.TabIndex = 16;
            this.lblKeyStoreFilePassword.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Key Store file:";
            // 
            // txtPasswordKeyStore
            // 
            this.txtPasswordKeyStore.Location = new System.Drawing.Point(96, 50);
            this.txtPasswordKeyStore.Name = "txtPasswordKeyStore";
            this.txtPasswordKeyStore.Size = new System.Drawing.Size(197, 20);
            this.txtPasswordKeyStore.TabIndex = 14;
            this.txtPasswordKeyStore.UseSystemPasswordChar = true;
            // 
            // txtFileKeyStore
            // 
            this.txtFileKeyStore.Location = new System.Drawing.Point(96, 21);
            this.txtFileKeyStore.Name = "txtFileKeyStore";
            this.txtFileKeyStore.Size = new System.Drawing.Size(197, 20);
            this.txtFileKeyStore.TabIndex = 13;
            // 
            // btnOpenFileKeyStore
            // 
            this.btnOpenFileKeyStore.Location = new System.Drawing.Point(317, 21);
            this.btnOpenFileKeyStore.Name = "btnOpenFileKeyStore";
            this.btnOpenFileKeyStore.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFileKeyStore.TabIndex = 12;
            this.btnOpenFileKeyStore.Text = "Open File..";
            this.btnOpenFileKeyStore.UseVisualStyleBackColor = true;
            this.btnOpenFileKeyStore.Click += new System.EventHandler(this.btnLoadPrivateKeyFromKeyStore_Click);
            // 
            // fileOpenerKeyStore
            // 
            this.fileOpenerKeyStore.FileOk += new System.ComponentModel.CancelEventHandler(this.fileOpenerKeyStore_FileOk);
            // 
            // KeystoreAccountLoaderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLoadPrivateKeyFromKeyStore);
            this.Controls.Add(this.lblKeyStoreFilePassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasswordKeyStore);
            this.Controls.Add(this.txtFileKeyStore);
            this.Controls.Add(this.btnOpenFileKeyStore);
            this.Name = "KeystoreAccountLoaderUserControl";
            this.Size = new System.Drawing.Size(406, 129);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadPrivateKeyFromKeyStore;
        private System.Windows.Forms.Label lblKeyStoreFilePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasswordKeyStore;
        private System.Windows.Forms.TextBox txtFileKeyStore;
        private System.Windows.Forms.Button btnOpenFileKeyStore;
        private System.Windows.Forms.OpenFileDialog fileOpenerKeyStore;
    }
}
