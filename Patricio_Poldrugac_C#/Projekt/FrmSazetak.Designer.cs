namespace Projekt
{
    partial class FrmSazetak
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
            this.tbSadrzajDatoteke = new System.Windows.Forms.TextBox();
            this.btnUcitajDatoteku = new System.Windows.Forms.Button();
            this.btnIzradiSazetak = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSazetak = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sadržaj datoteke:";
            // 
            // tbSadrzajDatoteke
            // 
            this.tbSadrzajDatoteke.Location = new System.Drawing.Point(23, 75);
            this.tbSadrzajDatoteke.Multiline = true;
            this.tbSadrzajDatoteke.Name = "tbSadrzajDatoteke";
            this.tbSadrzajDatoteke.Size = new System.Drawing.Size(455, 85);
            this.tbSadrzajDatoteke.TabIndex = 6;
            // 
            // btnUcitajDatoteku
            // 
            this.btnUcitajDatoteku.Location = new System.Drawing.Point(23, 12);
            this.btnUcitajDatoteku.Name = "btnUcitajDatoteku";
            this.btnUcitajDatoteku.Size = new System.Drawing.Size(457, 26);
            this.btnUcitajDatoteku.TabIndex = 5;
            this.btnUcitajDatoteku.Text = "Učitaj datoteku";
            this.btnUcitajDatoteku.UseVisualStyleBackColor = true;
            this.btnUcitajDatoteku.Click += new System.EventHandler(this.btnUcitajDatoteku_Click);
            // 
            // btnIzradiSazetak
            // 
            this.btnIzradiSazetak.Location = new System.Drawing.Point(150, 195);
            this.btnIzradiSazetak.Name = "btnIzradiSazetak";
            this.btnIzradiSazetak.Size = new System.Drawing.Size(190, 49);
            this.btnIzradiSazetak.TabIndex = 12;
            this.btnIzradiSazetak.Text = "Izradi sažetak";
            this.btnIzradiSazetak.UseVisualStyleBackColor = true;
            this.btnIzradiSazetak.Click += new System.EventHandler(this.btnIzradiSazetak_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sažetak:";
            // 
            // tbSazetak
            // 
            this.tbSazetak.Location = new System.Drawing.Point(23, 278);
            this.tbSazetak.Multiline = true;
            this.tbSazetak.Name = "tbSazetak";
            this.tbSazetak.Size = new System.Drawing.Size(455, 85);
            this.tbSazetak.TabIndex = 13;
            // 
            // FrmSazetak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 394);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSazetak);
            this.Controls.Add(this.btnIzradiSazetak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSadrzajDatoteke);
            this.Controls.Add(this.btnUcitajDatoteku);
            this.Name = "FrmSazetak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreiranje sažetka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSadrzajDatoteke;
        private System.Windows.Forms.Button btnUcitajDatoteku;
        private System.Windows.Forms.Button btnIzradiSazetak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSazetak;
    }
}