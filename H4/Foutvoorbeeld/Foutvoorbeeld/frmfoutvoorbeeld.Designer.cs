namespace WindowsFormsApplication3
{
    partial class frmfoutvoorbeeld
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
            this.lblgetal = new System.Windows.Forms.Label();
            this.txbGetal = new System.Windows.Forms.TextBox();
            this.btnBreuk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblgetal
            // 
            this.lblgetal.AutoSize = true;
            this.lblgetal.Location = new System.Drawing.Point(28, 31);
            this.lblgetal.Name = "lblgetal";
            this.lblgetal.Size = new System.Drawing.Size(32, 13);
            this.lblgetal.TabIndex = 0;
            this.lblgetal.Text = "Getal";
            // 
            // txbGetal
            // 
            this.txbGetal.Location = new System.Drawing.Point(66, 28);
            this.txbGetal.Name = "txbGetal";
            this.txbGetal.Size = new System.Drawing.Size(100, 20);
            this.txbGetal.TabIndex = 1;
            this.txbGetal.Text = "0";
            // 
            // btnBreuk
            // 
            this.btnBreuk.Location = new System.Drawing.Point(66, 54);
            this.btnBreuk.Name = "btnBreuk";
            this.btnBreuk.Size = new System.Drawing.Size(75, 23);
            this.btnBreuk.TabIndex = 2;
            this.btnBreuk.Text = "Breuk";
            this.btnBreuk.UseVisualStyleBackColor = true;
            this.btnBreuk.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmfoutvoorbeeld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 102);
            this.Controls.Add(this.btnBreuk);
            this.Controls.Add(this.txbGetal);
            this.Controls.Add(this.lblgetal);
            this.Name = "frmfoutvoorbeeld";
            this.Text = "FoutVoorbeeld";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgetal;
        private System.Windows.Forms.TextBox txbGetal;
        private System.Windows.Forms.Button btnBreuk;
    }
}

