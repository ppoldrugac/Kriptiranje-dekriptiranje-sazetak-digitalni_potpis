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
    public partial class FrmAES : Form
    {
        public FrmAES()
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
            using (Aes aes = Aes.Create())
            {
                aes.GenerateKey();
                aes.GenerateIV();

                byte[] kombiniraniKljuc = new byte[aes.Key.Length + aes.IV.Length];
                Array.Copy(aes.Key, 0, kombiniraniKljuc, 0, aes.Key.Length);
                Array.Copy(aes.IV, 0, kombiniraniKljuc, aes.Key.Length, aes.IV.Length);

                string kombiniraniKljucString = Convert.ToBase64String(kombiniraniKljuc);

                File.WriteAllText("tajni_kljuc.txt", kombiniraniKljucString);
                tbGeneriraniKljuc.Text = kombiniraniKljucString;
            }
        }

        private void btnKriptiraj_Click(object sender, EventArgs e)
        {
            if (tbSadrzajDatoteke.Text == "" || tbGeneriraniKljuc.Text == "")
            {
                MessageBox.Show("Datoteka nije učitana ili ključ nije generiran!");
            }
            else
            {
                AESKriptiranje();
            }
        }

        private void AESKriptiranje()
        {
            byte[] kombiniraniKljuc = Convert.FromBase64String(tbGeneriraniKljuc.Text);

            byte[] tajniKljuc = new byte[32];
            byte[] inicijalizacijskiVektor = new byte[16];
            Array.Copy(kombiniraniKljuc, 0, tajniKljuc, 0, 32);
            Array.Copy(kombiniraniKljuc, 32, inicijalizacijskiVektor, 0, 16);

            byte[] tekstZaKriptiranje = Encoding.UTF8.GetBytes(tbSadrzajDatoteke.Text);

            try
            {
                using (Aes aes = Aes.Create())
                {
                    aes.Key = tajniKljuc;
                    aes.IV = inicijalizacijskiVektor;

                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(tekstZaKriptiranje, 0, tekstZaKriptiranje.Length);
                            cs.FlushFinalBlock();
                            byte[] kriptiraniTekst = ms.ToArray();

                            tbSadrzajDatoteke.Text = Convert.ToBase64String(kriptiraniTekst);

                            File.WriteAllText("AESkriptirano.txt", tbSadrzajDatoteke.Text);
                        }
                    }
                }
                MessageBox.Show("Uspješno kriptiranje!");
            }
            catch
            {
                MessageBox.Show("Neuspješno kriptiranje!");
            }
        }

        private void AESDekriptiranje()
        {
            string tajniKljuc = File.ReadAllText("tajni_kljuc.txt");

            string kriptiraniSadrzaj = File.ReadAllText("AESkriptirano.txt");

            byte[] kriptiraniSadrzajBajtovi = Convert.FromBase64String(kriptiraniSadrzaj);

            byte[] kombiniraniKljuc = Convert.FromBase64String(tajniKljuc);

            byte[] key = new byte[32];
            byte[] iv = new byte[16];
            Array.Copy(kombiniraniKljuc, 0, key, 0, 32);
            Array.Copy(kombiniraniKljuc, 32, iv, 0, 16);


            try
            {
            Aes aesAlgoritam = Aes.Create();

            aesAlgoritam.Key = key;
            aesAlgoritam.IV = iv;

            ICryptoTransform dekripter = aesAlgoritam.CreateDecryptor();

            using (MemoryStream ms = new MemoryStream(kriptiraniSadrzajBajtovi))
            {
                using (CryptoStream cs = new CryptoStream(ms, dekripter, CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(cs))
                    {
                        string dekriptiraniSadrzaj = sr.ReadToEnd();

                        tbSadrzajDatoteke.Text = dekriptiraniSadrzaj;

                        File.WriteAllText("AESdekriptirano.txt", dekriptiraniSadrzaj);
                     }
                }
            }

            MessageBox.Show("Uspješno dekriptiranje!");

            }
            catch
            {
                MessageBox.Show("Neuspješno dekriptiranje!");
            }   
           
        }

        private void btnDekriptiraj_Click(object sender, EventArgs e)
        {
            if (tbSadrzajDatoteke.Text == "" || tbGeneriraniKljuc.Text == "")
            {
                MessageBox.Show("Datoteka nije učitana ili ključ nije generiran!");
            }
            else
            {
                AESDekriptiranje();
            }
        }
    }
}
