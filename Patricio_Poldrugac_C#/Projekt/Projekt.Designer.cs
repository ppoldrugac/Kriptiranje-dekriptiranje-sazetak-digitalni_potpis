namespace Projekt
{
    partial class Projekt
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
            this.btnAES = new System.Windows.Forms.Button();
            this.btnRSA = new System.Windows.Forms.Button();
            this.btnDigitalniPotpis = new System.Windows.Forms.Button();
            this.btnSazetak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAES
            // 
            this.btnAES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAES.Location = new System.Drawing.Point(78, 31);
            this.btnAES.Name = "btnAES";
            this.btnAES.Size = new System.Drawing.Size(220, 75);
            this.btnAES.TabIndex = 0;
            this.btnAES.Text = "AES";
            this.btnAES.UseVisualStyleBackColor = true;
            this.btnAES.Click += new System.EventHandler(this.btnAES_Click);
            // 
            // btnRSA
            // 
            this.btnRSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRSA.Location = new System.Drawing.Point(78, 144);
            this.btnRSA.Name = "btnRSA";
            this.btnRSA.Size = new System.Drawing.Size(220, 75);
            this.btnRSA.TabIndex = 1;
            this.btnRSA.Text = "RSA";
            this.btnRSA.UseVisualStyleBackColor = true;
            this.btnRSA.Click += new System.EventHandler(this.btnRSA_Click);
            // 
            // btnDigitalniPotpis
            // 
            this.btnDigitalniPotpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDigitalniPotpis.Location = new System.Drawing.Point(78, 373);
            this.btnDigitalniPotpis.Name = "btnDigitalniPotpis";
            this.btnDigitalniPotpis.Size = new System.Drawing.Size(220, 75);
            this.btnDigitalniPotpis.TabIndex = 2;
            this.btnDigitalniPotpis.Text = "Digitalni potpis";
            this.btnDigitalniPotpis.UseVisualStyleBackColor = true;
            this.btnDigitalniPotpis.Click += new System.EventHandler(this.btnDigitalniPotpis_Click);
            // 
            // btnSazetak
            // 
            this.btnSazetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSazetak.Location = new System.Drawing.Point(78, 263);
            this.btnSazetak.Name = "btnSazetak";
            this.btnSazetak.Size = new System.Drawing.Size(220, 75);
            this.btnSazetak.TabIndex = 3;
            this.btnSazetak.Text = "Sažetak";
            this.btnSazetak.UseVisualStyleBackColor = true;
            this.btnSazetak.Click += new System.EventHandler(this.btnSazetak_Click);
            // 
            // Projekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 481);
            this.Controls.Add(this.btnSazetak);
            this.Controls.Add(this.btnDigitalniPotpis);
            this.Controls.Add(this.btnRSA);
            this.Controls.Add(this.btnAES);
            this.Name = "Projekt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projekt";
            this.Load += new System.EventHandler(this.Projekt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAES;
        private System.Windows.Forms.Button btnRSA;
        private System.Windows.Forms.Button btnDigitalniPotpis;
        private System.Windows.Forms.Button btnSazetak;
    }
}

