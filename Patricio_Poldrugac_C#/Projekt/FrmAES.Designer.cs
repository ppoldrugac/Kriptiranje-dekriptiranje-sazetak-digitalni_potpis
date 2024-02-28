namespace Projekt
{
    partial class FrmAES
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
            this.tbSadrzajDatoteke = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerirajKljuc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGeneriraniKljuc = new System.Windows.Forms.TextBox();
            this.btnKriptiraj = new System.Windows.Forms.Button();
            this.btnDekriptiraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUcitajDatoteku
            // 
            this.btnUcitajDatoteku.Location = new System.Drawing.Point(27, 12);
            this.btnUcitajDatoteku.Name = "btnUcitajDatoteku";
            this.btnUcitajDatoteku.Size = new System.Drawing.Size(457, 26);
            this.btnUcitajDatoteku.TabIndex = 0;
            this.btnUcitajDatoteku.Text = "Učitaj datoteku";
            this.btnUcitajDatoteku.UseVisualStyleBackColor = true;
            this.btnUcitajDatoteku.Click += new System.EventHandler(this.btnUcitajDatoteku_Click);
            // 
            // tbSadrzajDatoteke
            // 
            this.tbSadrzajDatoteke.Location = new System.Drawing.Point(27, 77);
            this.tbSadrzajDatoteke.Multiline = true;
            this.tbSadrzajDatoteke.Name = "tbSadrzajDatoteke";
            this.tbSadrzajDatoteke.Size = new System.Drawing.Size(457, 81);
            this.tbSadrzajDatoteke.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sadržaj datoteke:";
            // 
            // btnGenerirajKljuc
            // 
            this.btnGenerirajKljuc.Location = new System.Drawing.Point(27, 191);
            this.btnGenerirajKljuc.Name = "btnGenerirajKljuc";
            this.btnGenerirajKljuc.Size = new System.Drawing.Size(457, 26);
            this.btnGenerirajKljuc.TabIndex = 3;
            this.btnGenerirajKljuc.Text = "Generiraj ključ";
            this.btnGenerirajKljuc.UseVisualStyleBackColor = true;
            this.btnGenerirajKljuc.Click += new System.EventHandler(this.btnGenerirajKljuc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Generirani ključ:";
            // 
            // tbGeneriraniKljuc
            // 
            this.tbGeneriraniKljuc.Location = new System.Drawing.Point(27, 254);
            this.tbGeneriraniKljuc.Multiline = true;
            this.tbGeneriraniKljuc.Name = "tbGeneriraniKljuc";
            this.tbGeneriraniKljuc.Size = new System.Drawing.Size(457, 31);
            this.tbGeneriraniKljuc.TabIndex = 4;
            // 
            // btnKriptiraj
            // 
            this.btnKriptiraj.Location = new System.Drawing.Point(50, 307);
            this.btnKriptiraj.Name = "btnKriptiraj";
            this.btnKriptiraj.Size = new System.Drawing.Size(162, 49);
            this.btnKriptiraj.TabIndex = 6;
            this.btnKriptiraj.Text = "Kriptiraj";
            this.btnKriptiraj.UseVisualStyleBackColor = true;
            this.btnKriptiraj.Click += new System.EventHandler(this.btnKriptiraj_Click);
            // 
            // btnDekriptiraj
            // 
            this.btnDekriptiraj.Location = new System.Drawing.Point(285, 307);
            this.btnDekriptiraj.Name = "btnDekriptiraj";
            this.btnDekriptiraj.Size = new System.Drawing.Size(162, 49);
            this.btnDekriptiraj.TabIndex = 7;
            this.btnDekriptiraj.Text = "Dekriptiraj";
            this.btnDekriptiraj.UseVisualStyleBackColor = true;
            this.btnDekriptiraj.Click += new System.EventHandler(this.btnDekriptiraj_Click);
            // 
            // FrmAES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 379);
            this.Controls.Add(this.btnDekriptiraj);
            this.Controls.Add(this.btnKriptiraj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbGeneriraniKljuc);
            this.Controls.Add(this.btnGenerirajKljuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSadrzajDatoteke);
            this.Controls.Add(this.btnUcitajDatoteku);
            this.Name = "FrmAES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUcitajDatoteku;
        private System.Windows.Forms.TextBox tbSadrzajDatoteke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerirajKljuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGeneriraniKljuc;
        private System.Windows.Forms.Button btnKriptiraj;
        private System.Windows.Forms.Button btnDekriptiraj;
    }
}