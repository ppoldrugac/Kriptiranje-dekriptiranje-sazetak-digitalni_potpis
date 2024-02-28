using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Projekt : Form
    {
        public Projekt()
        {
            InitializeComponent();
        }

        private void Projekt_Load(object sender, EventArgs e)
        {

        }

        private void btnRSA_Click(object sender, EventArgs e)
        {
            FrmRSA frmRSA = new FrmRSA();
            frmRSA.ShowDialog();
        }

        private void btnAES_Click(object sender, EventArgs e)
        {
            FrmAES frmAES = new FrmAES();
            frmAES.ShowDialog();
        }

        private void btnSazetak_Click(object sender, EventArgs e)
        {
            FrmSazetak frmSazetak = new FrmSazetak();
            frmSazetak.ShowDialog();
        }

        private void btnDigitalniPotpis_Click(object sender, EventArgs e)
        {
            FrmDigitalniPotpis frmDigitalniPotpis = new FrmDigitalniPotpis();
            frmDigitalniPotpis.ShowDialog();
        }
    }
}
