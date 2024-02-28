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
    public partial class FrmRSA : Form
    {
        public FrmRSA()
        {
            InitializeComponent();
        }

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
                        string sadrzajDatoteke = streamReader.ReadToEnd();
                        tbSadrzajDatoteke.Text = sadrzajDatoteke;
                    }
                }
            }
        }

        private void btnGenerirajKljuc_Click(object sender, EventArgs e)
        {
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                string javniKljuc = RSA.ToXmlString(false);
                string privatniKljuc = RSA.ToXmlString(true);

                File.WriteAllText("javni_kljuc.txt", javniKljuc);
                File.WriteAllText("privatni_kljuc.txt", privatniKljuc);

                tbJavniKljuc.Text = javniKljuc;
                tbPrivatniKljuc.Text = privatniKljuc;
            }
        }

        private void RSAKriptiranje()
        {
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(tbJavniKljuc.Text);

                byte[] sadrzajDatoteke = Encoding.UTF8.GetBytes(tbSadrzajDatoteke.Text);

                byte[] kriptiraniSadrzaj = RSA.Encrypt(sadrzajDatoteke, true);

                string kriptiraniSadrzajString = Convert.ToBase64String(kriptiraniSadrzaj);
                tbSadrzajDatoteke.Text = kriptiraniSadrzajString;

                File.WriteAllText("RSAkriptirano.txt", kriptiraniSadrzajString);
            }
        }

        private void btnKriptiraj_Click(object sender, EventArgs e)
        {
            if (tbSadrzajDatoteke.Text == "" || tbJavniKljuc.Text == "" || tbPrivatniKljuc.Text == "")
            {
                MessageBox.Show("Datoteka nije učitana ili ključevi nisu generirani!");
            }
            else
            {
                RSAKriptiranje();
            }
        }

        private void RSADekriptiranje()
        {
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                string privatniKljuc = File.ReadAllText("privatni_kljuc.txt");
                RSA.FromXmlString(privatniKljuc);

                string kriptiraniSadrzajString = File.ReadAllText("RSAkriptirano.txt");

                byte[] kriptiraniSadrzaj = Convert.FromBase64String(kriptiraniSadrzajString);

                byte[] dekriptiraniSadrzaj = RSA.Decrypt(kriptiraniSadrzaj, true);

                string dekriptiraniSadrzajString = Encoding.UTF8.GetString(dekriptiraniSadrzaj);
                tbSadrzajDatoteke.Text = dekriptiraniSadrzajString;

                File.WriteAllText("RSAdekriptirano.txt", dekriptiraniSadrzajString);
            }
        }

        private void btnDekriptiraj_Click(object sender, EventArgs e)
        {
            if (tbSadrzajDatoteke.Text == "" || tbPrivatniKljuc.Text == "" || tbJavniKljuc.Text == "")
            {
                MessageBox.Show("Datoteka nije učitana ili ključevi nisu generirani!");
            }
            else
            {
                RSADekriptiranje();
            }
        }
    }
}
