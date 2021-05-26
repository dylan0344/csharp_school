
namespace H3_1_DatumTijd
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
            this.btnVandaag = new System.Windows.Forms.Button();
            this.lblDatumTijd = new System.Windows.Forms.Label();
            this.dateTimePickerGeboortedatum = new System.Windows.Forms.DateTimePicker();
            this.btnLeeftijd = new System.Windows.Forms.Button();
            this.lblGeboortedatum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVandaag
            // 
            this.btnVandaag.Location = new System.Drawing.Point(13, 23);
            this.btnVandaag.Name = "btnVandaag";
            this.btnVandaag.Size = new System.Drawing.Size(75, 23);
            this.btnVandaag.TabIndex = 0;
            this.btnVandaag.Text = "Vandaag";
            this.btnVandaag.UseVisualStyleBackColor = true;
            this.btnVandaag.Click += new System.EventHandler(this.btnVandaag_Click);
            // 
            // lblDatumTijd
            // 
            this.lblDatumTijd.AutoSize = true;
            this.lblDatumTijd.Location = new System.Drawing.Point(13, 401);
            this.lblDatumTijd.Name = "lblDatumTijd";
            this.lblDatumTijd.Size = new System.Drawing.Size(69, 13);
            this.lblDatumTijd.TabIndex = 1;
            this.lblDatumTijd.Text = "Datum en tijd";
            // 
            // dateTimePickerGeboortedatum
            // 
            this.dateTimePickerGeboortedatum.Location = new System.Drawing.Point(217, 60);
            this.dateTimePickerGeboortedatum.Name = "dateTimePickerGeboortedatum";
            this.dateTimePickerGeboortedatum.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerGeboortedatum.TabIndex = 2;
            // 
            // btnLeeftijd
            // 
            this.btnLeeftijd.Location = new System.Drawing.Point(437, 57);
            this.btnLeeftijd.Name = "btnLeeftijd";
            this.btnLeeftijd.Size = new System.Drawing.Size(75, 23);
            this.btnLeeftijd.TabIndex = 3;
            this.btnLeeftijd.Text = "Leeftijd";
            this.btnLeeftijd.UseVisualStyleBackColor = true;
            this.btnLeeftijd.Click += new System.EventHandler(this.btnLeeftijd_Click);
            // 
            // lblGeboortedatum
            // 
            this.lblGeboortedatum.AutoSize = true;
            this.lblGeboortedatum.Location = new System.Drawing.Point(217, 32);
            this.lblGeboortedatum.Name = "lblGeboortedatum";
            this.lblGeboortedatum.Size = new System.Drawing.Size(80, 13);
            this.lblGeboortedatum.TabIndex = 4;
            this.lblGeboortedatum.Text = "Geboortedatum";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGeboortedatum);
            this.Controls.Add(this.btnLeeftijd);
            this.Controls.Add(this.dateTimePickerGeboortedatum);
            this.Controls.Add(this.lblDatumTijd);
            this.Controls.Add(this.btnVandaag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVandaag;
        private System.Windows.Forms.Label lblDatumTijd;
        private System.Windows.Forms.DateTimePicker dateTimePickerGeboortedatum;
        private System.Windows.Forms.Button btnLeeftijd;
        private System.Windows.Forms.Label lblGeboortedatum;
    }
}

