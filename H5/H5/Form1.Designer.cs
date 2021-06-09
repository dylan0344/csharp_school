namespace H5 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txbLeeftijd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbRijbewijs = new System.Windows.Forms.TextBox();
            this.txbJaren = new System.Windows.Forms.TextBox();
            this.lblResultaat = new System.Windows.Forms.Label();
            this.btnControleer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLeeftijdError = new System.Windows.Forms.Label();
            this.lblRijbewijsError = new System.Windows.Forms.Label();
            this.lblJarenError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbLeeftijd
            // 
            this.txbLeeftijd.Location = new System.Drawing.Point(150, 42);
            this.txbLeeftijd.Name = "txbLeeftijd";
            this.txbLeeftijd.Size = new System.Drawing.Size(100, 20);
            this.txbLeeftijd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Leeftijd ( >= 18)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rijbewijs (A1/A2/A3)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Aantal jaar in bezit (>0)";
            // 
            // txbRijbewijs
            // 
            this.txbRijbewijs.Location = new System.Drawing.Point(150, 78);
            this.txbRijbewijs.Name = "txbRijbewijs";
            this.txbRijbewijs.Size = new System.Drawing.Size(100, 20);
            this.txbRijbewijs.TabIndex = 4;
            // 
            // txbJaren
            // 
            this.txbJaren.Location = new System.Drawing.Point(150, 121);
            this.txbJaren.Name = "txbJaren";
            this.txbJaren.Size = new System.Drawing.Size(100, 20);
            this.txbJaren.TabIndex = 5;
            // 
            // lblResultaat
            // 
            this.lblResultaat.AutoSize = true;
            this.lblResultaat.Location = new System.Drawing.Point(162, 186);
            this.lblResultaat.Name = "lblResultaat";
            this.lblResultaat.Size = new System.Drawing.Size(52, 13);
            this.lblResultaat.TabIndex = 6;
            this.lblResultaat.Text = "Resultaat";
            // 
            // btnControleer
            // 
            this.btnControleer.Location = new System.Drawing.Point(150, 151);
            this.btnControleer.Name = "btnControleer";
            this.btnControleer.Size = new System.Drawing.Size(75, 23);
            this.btnControleer.TabIndex = 7;
            this.btnControleer.Text = "Controleer";
            this.btnControleer.UseVisualStyleBackColor = true;
            this.btnControleer.Click += new System.EventHandler(this.btnControleer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(408, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vul je leeftijd, soort motorrijbewijs en het aantal dat je het motorrijbewijs in " +
    "bezit hebt in";
            // 
            // lblLeeftijdError
            // 
            this.lblLeeftijdError.AutoSize = true;
            this.lblLeeftijdError.Location = new System.Drawing.Point(281, 48);
            this.lblLeeftijdError.Name = "lblLeeftijdError";
            this.lblLeeftijdError.Size = new System.Drawing.Size(73, 13);
            this.lblLeeftijdError.TabIndex = 10;
            this.lblLeeftijdError.Text = "lblLeeftijdError";
            // 
            // lblRijbewijsError
            // 
            this.lblRijbewijsError.AutoSize = true;
            this.lblRijbewijsError.Location = new System.Drawing.Point(281, 85);
            this.lblRijbewijsError.Name = "lblRijbewijsError";
            this.lblRijbewijsError.Size = new System.Drawing.Size(80, 13);
            this.lblRijbewijsError.TabIndex = 11;
            this.lblRijbewijsError.Text = "lblRijbewijsError";
            // 
            // lblJarenError
            // 
            this.lblJarenError.AutoSize = true;
            this.lblJarenError.Location = new System.Drawing.Point(281, 131);
            this.lblJarenError.Name = "lblJarenError";
            this.lblJarenError.Size = new System.Drawing.Size(65, 13);
            this.lblJarenError.TabIndex = 12;
            this.lblJarenError.Text = "lblJarenError";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 223);
            this.Controls.Add(this.lblJarenError);
            this.Controls.Add(this.lblRijbewijsError);
            this.Controls.Add(this.lblLeeftijdError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnControleer);
            this.Controls.Add(this.lblResultaat);
            this.Controls.Add(this.txbJaren);
            this.Controls.Add(this.txbRijbewijs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbLeeftijd);
            this.Name = "Form1";
            this.Text = "Motorrijbewijs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbLeeftijd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbRijbewijs;
        private System.Windows.Forms.TextBox txbJaren;
        private System.Windows.Forms.Label lblResultaat;
        private System.Windows.Forms.Button btnControleer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLeeftijdError;
        private System.Windows.Forms.Label lblRijbewijsError;
        private System.Windows.Forms.Label lblJarenError;
    }
}

