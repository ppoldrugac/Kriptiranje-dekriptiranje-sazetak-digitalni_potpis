namespace Projekt
{
    partial class FrmRSA
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
            this.btnUcitajDatoteku = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSadrzajDatoteke = new System.Windows.Forms.TextBox();
            this.btnDekriptiraj = new System.Windows.Forms.Button();
            this.btnKriptiraj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPrivatniKljuc = new System.Windows.Forms.TextBox();
            this.btnGenerirajKljuc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbJavniKljuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUcitajDatoteku
            // 
            this.btnUcitajDatoteku.Location = new System.Drawing.Point(22, 12);
            this.btnUcitajDatoteku.Name = "btnUcitajDatoteku";
            this.btnUcitajDatoteku.Size = new System.Drawing.Size(457, 26);
            this.btnUcitajDatoteku.TabIndex = 1;
            this.btnUcitajDatoteku.Text = "Učitaj datoteku";
            this.btnUcitajDatoteku.UseVisualStyleBackColor = true;
            this.btnUcitajDatoteku.Click += new System.EventHandler(this.btnUcitajDatoteku_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sadržaj datoteke:";
            // 
            // tbSadrzajDatoteke
            // 
            this.tbSadrzajDatoteke.Location = new System.Drawing.Point(22, 75);
            this.tbSadrzajDatoteke.Multiline = true;
            this.tbSadrzajDatoteke.Name = "tbSadrzajDatoteke";
            this.tbSadrzajDatoteke.Size = new System.Drawing.Size(457, 83);
            this.tbSadrzajDatoteke.TabIndex = 3;
            // 
            // btnDekriptiraj
            // 
            this.btnDekriptiraj.Location = new System.Drawing.Point(294, 424);
            this.btnDekriptiraj.Name = "btnDekriptiraj";
            this.btnDekriptiraj.Size = new System.Drawing.Size(162, 49);
            this.btnDekriptiraj.TabIndex = 12;
            this.btnDekriptiraj.Text = "Dekriptiraj";
            this.btnDekriptiraj.UseVisualStyleBackColor = true;
            this.btnDekriptiraj.Click += new System.EventHandler(this.btnDekriptiraj_Click);
            // 
            // btnKriptiraj
            // 
            this.btnKriptiraj.Location = new System.Drawing.Point(34, 424);
            this.btnKriptiraj.Name = "btnKriptiraj";
            this.btnKriptiraj.Size = new System.Drawing.Size(162, 49);
            this.btnKriptiraj.TabIndex = 11;
            this.btnKriptiraj.Text = "Kriptiraj";
            this.btnKriptiraj.UseVisualStyleBackColor = true;
            this.btnKriptiraj.Click += new System.EventHandler(this.btnKriptiraj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Privatni ključ:";
            // 
            // tbPrivatniKljuc
            // 
            this.tbPrivatniKljuc.Location = new System.Drawing.Point(22, 250);
            this.tbPrivatniKljuc.Multiline = true;
            this.tbPrivatniKljuc.Name = "tbPrivatniKljuc";
            this.tbPrivatniKljuc.Size = new System.Drawing.Size(457, 50);
            this.tbPrivatniKljuc.TabIndex = 9;
            // 
            // btnGenerirajKljuc
            // 
            this.btnGenerirajKljuc.Location = new System.Drawing.Point(22, 184);
            this.btnGenerirajKljuc.Name = "btnGenerirajKljuc";
            this.btnGenerirajKljuc.Size = new System.Drawing.Size(457, 26);
            this.btnGenerirajKljuc.TabIndex = 8;
            this.btnGenerirajKljuc.Text = "Generiraj ključeve";
            this.btnGenerirajKljuc.UseVisualStyleBackColor = true;
            this.btnGenerirajKljuc.Click += new System.EventHandler(this.btnGenerirajKljuc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Javni ključ:";
            // 
            // tbJavniKljuc
            // 
            this.tbJavniKljuc.Location = new System.Drawing.Point(22, 341);
            this.tbJavniKljuc.Multiline = true;
            this.tbJavniKljuc.Name = "tbJavniKljuc";
            this.tbJavniKljuc.Size = new System.Drawing.Size(457, 50);
            this.tbJavniKljuc.TabIndex = 13;
            // 
            // FrmRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 509);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbJavniKljuc);
            this.Controls.Add(this.btnDekriptiraj);
            this.Controls.Add(this.btnKriptiraj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPrivatniKljuc);
            this.Controls.Add(this.btnGenerirajKljuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSadrzajDatoteke);
            this.Controls.Add(this.btnUcitajDatoteku);
            this.Name = "FrmRSA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUcitajDatoteku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSadrzajDatoteke;
        private System.Windows.Forms.Button btnDekriptiraj;
        private System.Windows.Forms.Button btnKriptiraj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrivatniKljuc;
        private System.Windows.Forms.Button btnGenerirajKljuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbJavniKljuc;
    }
}