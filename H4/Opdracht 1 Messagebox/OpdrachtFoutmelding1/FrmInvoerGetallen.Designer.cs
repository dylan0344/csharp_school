namespace OpdrachtVariabelen2
{
    partial class FrmInvoerGetallen
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbGetal1 = new System.Windows.Forms.TextBox();
            this.txbGetal2 = new System.Windows.Forms.TextBox();
            this.lblUitvoer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voer een getal in:";
            // 
            // txbGetal1
            // 
            this.txbGetal1.Location = new System.Drawing.Point(36, 50);
            this.txbGetal1.Name = "txbGetal1";
            this.txbGetal1.Size = new System.Drawing.Size(100, 20);
            this.txbGetal1.TabIndex = 1;
            this.txbGetal1.TextChanged += new System.EventHandler(this.txbGetal1_TextChanged);
            // 
            // txbGetal2
            // 
            this.txbGetal2.Location = new System.Drawing.Point(36, 76);
            this.txbGetal2.Name = "txbGetal2";
            this.txbGetal2.Size = new System.Drawing.Size(100, 20);
            this.txbGetal2.TabIndex = 2;
            this.txbGetal2.TextChanged += new System.EventHandler(this.txbGetal2_TextChanged);
            // 
            // lblUitvoer
            // 
            this.lblUitvoer.BackColor = System.Drawing.Color.LightCyan;
            this.lblUitvoer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUitvoer.ForeColor = System.Drawing.Color.Red;
            this.lblUitvoer.Location = new System.Drawing.Point(33, 109);
            this.lblUitvoer.Name = "lblUitvoer";
            this.lblUitvoer.Size = new System.Drawing.Size(103, 16);
            this.lblUitvoer.TabIndex = 3;
            this.lblUitvoer.Text = "Uitvoer";
            // 
            // FrmInvoerGetallen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 146);
            this.Controls.Add(this.lblUitvoer);
            this.Controls.Add(this.txbGetal2);
            this.Controls.Add(this.txbGetal1);
            this.Controls.Add(this.label1);
            this.Name = "FrmInvoerGetallen";
            this.Text = "Opdracht Foutafhandeling 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbGetal1;
        private System.Windows.Forms.TextBox txbGetal2;
        private System.Windows.Forms.Label lblUitvoer;
    }
}

