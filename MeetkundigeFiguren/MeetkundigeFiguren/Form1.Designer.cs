namespace MeetkundigeFiguren
{
    partial class Form1
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
            this.btnCirkel = new System.Windows.Forms.Button();
            this.lblOmtrek = new System.Windows.Forms.Label();
            this.lblOppervlak = new System.Windows.Forms.Label();
            this.btnRechthoek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCirkel
            // 
            this.btnCirkel.Location = new System.Drawing.Point(12, 366);
            this.btnCirkel.Name = "btnCirkel";
            this.btnCirkel.Size = new System.Drawing.Size(95, 34);
            this.btnCirkel.TabIndex = 0;
            this.btnCirkel.Text = "Cirkel";
            this.btnCirkel.UseVisualStyleBackColor = true;
            this.btnCirkel.Click += new System.EventHandler(this.btnCirkel_Click_1);
            // 
            // lblOmtrek
            // 
            this.lblOmtrek.AutoSize = true;
            this.lblOmtrek.Location = new System.Drawing.Point(12, 412);
            this.lblOmtrek.Name = "lblOmtrek";
            this.lblOmtrek.Size = new System.Drawing.Size(54, 17);
            this.lblOmtrek.TabIndex = 1;
            this.lblOmtrek.Text = "Omtrek";
            // 
            // lblOppervlak
            // 
            this.lblOppervlak.AutoSize = true;
            this.lblOppervlak.Location = new System.Drawing.Point(12, 429);
            this.lblOppervlak.Name = "lblOppervlak";
            this.lblOppervlak.Size = new System.Drawing.Size(85, 17);
            this.lblOppervlak.TabIndex = 2;
            this.lblOppervlak.Text = "Oppervlakte";
            // 
            // btnRechthoek
            // 
            this.btnRechthoek.Location = new System.Drawing.Point(12, 326);
            this.btnRechthoek.Name = "btnRechthoek";
            this.btnRechthoek.Size = new System.Drawing.Size(95, 34);
            this.btnRechthoek.TabIndex = 3;
            this.btnRechthoek.Text = "Rechthoek";
            this.btnRechthoek.UseVisualStyleBackColor = true;
            this.btnRechthoek.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(639, 481);
            this.Controls.Add(this.btnRechthoek);
            this.Controls.Add(this.lblOppervlak);
            this.Controls.Add(this.lblOmtrek);
            this.Controls.Add(this.btnCirkel);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.Button btnCirkel;
        //private System.Windows.Forms.Label lblOmtrek;
        //private System.Windows.Forms.Label lblOppervlak;
        private System.Windows.Forms.Button btnCirkel;
        private System.Windows.Forms.Label lblOmtrek;
        private System.Windows.Forms.Label lblOppervlak;
        private System.Windows.Forms.Button btnRechthoek;
    }
}

