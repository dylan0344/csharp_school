namespace Hoofdstuk7
{
    partial class FrmWaarBenIk
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
            this.pnlLocation = new System.Windows.Forms.Panel();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.pnlLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLocation
            // 
            this.pnlLocation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlLocation.Controls.Add(this.lblY);
            this.pnlLocation.Controls.Add(this.lblX);
            this.pnlLocation.Location = new System.Drawing.Point(110, 113);
            this.pnlLocation.Name = "pnlLocation";
            this.pnlLocation.Size = new System.Drawing.Size(112, 56);
            this.pnlLocation.TabIndex = 0;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(19, 31);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(13, 13);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "0";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(19, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(13, 13);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "0";
            // 
            // FrmWaarBenIk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 383);
            this.Controls.Add(this.pnlLocation);
            this.Name = "FrmWaarBenIk";
            this.Text = "Waar Ben Ik?";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FrmWaarBenIk_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmWaarBenIk_MouseMove);
            this.pnlLocation.ResumeLayout(false);
            this.pnlLocation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLocation;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
    }
}

