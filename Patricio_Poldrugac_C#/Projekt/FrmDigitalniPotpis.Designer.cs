namespace Projekt
{
    partial class FrmDigitalniPotpis
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
            this.btnDigitalniPotpis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDigitalniPotpis = new System.Windows.Forms.TextBox();
            this.btnProvjeriDigitalniPotpis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUcitajDatoteku
            // 
            this.btnUcitajDatoteku.Location = new System.Drawing.Point(12, 12);
            this.btnUcitajDatoteku.Name = "btnUcitajDatoteku";
            this.btnUcitajDatoteku.Size = new System.Drawing.Size(457, 26);
            this.btnUcitajDatoteku.TabIndex = 6;
            this.btnUcitajDatoteku.Text = "Učitaj datoteku";
            this.btnUcitajDatoteku.UseVisualStyleBackColor = true;
            this.btnUcitajDatoteku.Click += new System.EventHandler(this.btnUcitajDatoteku_Click);
            // 
            // btnDigitalniPotpis
            // 
            this.btnDigitalniPotpis.Location = new System.Drawing.Point(142, 57);
            this.btnDigitalniPotpis.Name = "btnDigitalniPotpis";
            this.btnDigitalniPotpis.Size = new System.Drawing.Size(205, 49);
            this.btnDigitalniPotpis.TabIndex = 13;
            this.btnDigitalniPotpis.Text = "Izradi digitalni potpis";
            this.btnDigitalniPotpis.UseVisualStyleBackColor = true;
            this.btnDigitalniPotpis.Click += new System.EventHandler(this.btnDigitalniPotpis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Digitalni potpis:";
            // 
            // tbDigitalniPotpis
            // 
            this.tbDigitalniPotpis.Location = new System.Drawing.Point(15, 129);
            this.tbDigitalniPotpis.Multiline = true;
            this.tbDigitalniPotpis.Name = "tbDigitalniPotpis";
            this.tbDigitalniPotpis.Size = new System.Drawing.Size(457, 56);
            this.tbDigitalniPotpis.TabIndex = 14;
            // 
            // btnProvjeriDigitalniPotpis
            // 
            this.btnProvjeriDigitalniPotpis.Location = new System.Drawing.Point(142, 222);
            this.btnProvjeriDigitalniPotpis.Name = "btnProvjeriDigitalniPotpis";
            this.btnProvjeriDigitalniPotpis.Size = new System.Drawing.Size(205, 49);
            this.btnProvjeriDigitalniPotpis.TabIndex = 17;
            this.btnProvjeriDigitalniPotpis.Text = "Provjeri digitalni potpis";
            this.btnProvjeriDigitalniPotpis.UseVisualStyleBackColor = true;
            this.btnProvjeriDigitalniPotpis.Click += new System.EventHandler(this.btnProvjeriDigitalniPotpis_Click);
            // 
            // FrmDigitalniPotpis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 293);
            this.Controls.Add(this.btnProvjeriDigitalniPotpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDigitalniPotpis);
            this.Controls.Add(this.btnDigitalniPotpis);
            this.Controls.Add(this.btnUcitajDatoteku);
            this.Name = "FrmDigitalniPotpis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digitalni potpis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUcitajDatoteku;
        private System.Windows.Forms.Button btnDigitalniPotpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDigitalniPotpis;
        private System.Windows.Forms.Button btnProvjeriDigitalniPotpis;
    }
}