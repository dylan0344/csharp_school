namespace RijGetallenZonderLoop
{
    partial class FrmRijGetallenZonderLoop
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
            this.btnVulTextBox = new System.Windows.Forms.Button();
            this.txbGetallen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEinde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVulTextBox
            // 
            this.btnVulTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnVulTextBox.Location = new System.Drawing.Point(36, 39);
            this.btnVulTextBox.Name = "btnVulTextBox";
            this.btnVulTextBox.Size = new System.Drawing.Size(75, 23);
            this.btnVulTextBox.TabIndex = 0;
            this.btnVulTextBox.Text = "&Vul textBox:";
            this.btnVulTextBox.UseVisualStyleBackColor = false;
            this.btnVulTextBox.Click += new System.EventHandler(this.btnVulTextBox_Click);
            // 
            // txbGetallen
            // 
            this.txbGetallen.BackColor = System.Drawing.Color.LimeGreen;
            this.txbGetallen.Font = new System.Drawing.Font("OCR A Extended", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGetallen.ForeColor = System.Drawing.Color.Red;
            this.txbGetallen.Location = new System.Drawing.Point(163, 69);
            this.txbGetallen.Multiline = true;
            this.txbGetallen.Name = "txbGetallen";
            this.txbGetallen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbGetallen.Size = new System.Drawing.Size(100, 504);
            this.txbGetallen.TabIndex = 1;
            this.txbGetallen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Getallen 50 t/m 100:";
            // 
            // btnEinde
            // 
            this.btnEinde.BackColor = System.Drawing.Color.Coral;
            this.btnEinde.Location = new System.Drawing.Point(310, 602);
            this.btnEinde.Name = "btnEinde";
            this.btnEinde.Size = new System.Drawing.Size(75, 23);
            this.btnEinde.TabIndex = 3;
            this.btnEinde.Text = "&Einde";
            this.btnEinde.UseVisualStyleBackColor = false;
            this.btnEinde.Click += new System.EventHandler(this.btnEinde_Click);
            // 
            // FrmRijGetallenZonderLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 637);
            this.Controls.Add(this.btnEinde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbGetallen);
            this.Controls.Add(this.btnVulTextBox);
            this.Name = "FrmRijGetallenZonderLoop";
            this.Text = "Opdracht Herhaling 1:  Rij getallen zonder loop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVulTextBox;
        private System.Windows.Forms.TextBox txbGetallen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEinde;
    }
}

