
namespace Bam4a19_H10_Tekenen
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
            this.BtnTeken = new System.Windows.Forms.Button();
            this.pbTekening = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTekening)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnTeken
            // 
            this.BtnTeken.Location = new System.Drawing.Point(565, 659);
            this.BtnTeken.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnTeken.Name = "BtnTeken";
            this.BtnTeken.Size = new System.Drawing.Size(138, 42);
            this.BtnTeken.TabIndex = 0;
            this.BtnTeken.Text = "Teken";
            this.BtnTeken.UseVisualStyleBackColor = true;
            this.BtnTeken.Click += new System.EventHandler(this.BtnTeken_Click);
            // 
            // pbTekening
            // 
            this.pbTekening.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTekening.Location = new System.Drawing.Point(22, 22);
            this.pbTekening.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pbTekening.Name = "pbTekening";
            this.pbTekening.Size = new System.Drawing.Size(679, 602);
            this.pbTekening.TabIndex = 1;
            this.pbTekening.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 659);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Teken de Y as";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 759);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbTekening);
            this.Controls.Add(this.BtnTeken);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbTekening)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTeken;
        private System.Windows.Forms.PictureBox pbTekening;
        private System.Windows.Forms.Button button1;
    }
}

