using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Projekt
{
    public partial class FrmSazetak : Form
    {
        public FrmSazetak()
        {
            InitializeComponent();
        }

        private string sadrzajDatoteke;

        private void btnUcitajDatoteku_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "c:\\";
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.FilterIndex = 2;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string putanjaDoDatoteke = ofd.FileName;

                    using (StreamReader streamReader = new StreamReader(putanjaDoDatoteke))
                    {
                        sadrzajDatoteke = streamReader.ReadToEnd();
                        tbSadrzajDatoteke.Text = sadrzajDatoteke;
                    }
                }
            }
        }

        private void btnIzradiSazetak_Click(object sender, EventArgs e)
        {
            if (tbSadrzajDatoteke.Text == "")
            {
                MessageBox.Show("Niste učitali datoteku za sažimanje!");
            }
            else
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] sadrzajDatotekeBytes = Encoding.UTF8.GetBytes(sadrzajDatoteke);

                    byte[] hashiraniBajtovi = sha256.ComputeHash(sadrzajDatotekeBytes);

                    string sazetak = Convert.ToBase64String(hashiraniBajtovi);
                    tbSazetak.Text = sazetak;

                    File.WriteAllText("sazetak.txt", sazetak);
                }
            }
        }
    }
}
