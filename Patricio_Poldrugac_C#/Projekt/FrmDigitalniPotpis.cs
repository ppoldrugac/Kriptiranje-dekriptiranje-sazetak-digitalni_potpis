using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class FrmDigitalniPotpis : Form
    {
        public FrmDigitalniPotpis()
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
                    }
                }
            }
        }

        private void btnDigitalniPotpis_Click(object sender, EventArgs e)
        {

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(File.ReadAllText("privatni_kljuc.txt"));

                string sazetakString = File.ReadAllText("sazetak.txt");
                byte[] sazetak = Convert.FromBase64String(sazetakString);

                byte[] potpisBytes = rsa.SignHash(sazetak, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

                string digitalniPotips = Convert.ToBase64String(potpisBytes);

                tbDigitalniPotpis.Text = digitalniPotips;

                File.WriteAllText("digitalni_potpis.txt", digitalniPotips);
            }

        }

        private void btnProvjeriDigitalniPotpis_Click(object sender, EventArgs e)
        {
            using(RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(File.ReadAllText("javni_kljuc.txt"));

                string digitalniPotpis = File.ReadAllText("digitalni_potpis.txt");
                byte[] digitalniPotpisBytes = Convert.FromBase64String(digitalniPotpis);

                string orginalnaDatoteka = File.ReadAllText("tekst.txt");
                byte[] orginalnaDatotekaBytes = Encoding.UTF8.GetBytes(orginalnaDatoteka);

                byte[] sazetak = SHA256.Create().ComputeHash(orginalnaDatotekaBytes);

                string message = rsa.VerifyHash(sazetak, CryptoConfig.MapNameToOID("SHA256"), digitalniPotpisBytes) ? "Digitalni potpis je valjan." : "Digitalni potpis nije valjan.";
                MessageBox.Show(message);
            }
        }
    }
}
