using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_SiparisOtomasyon.Forms
{
    public partial class frmExtra : Form
    {
        public frmExtra()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Form1.Extralar.Add(new Entities.Extra() { ExtraAdi=txtextra.Text,ExtraFiyati=nmrfiyat.Value});
            Tools.Temizle(this.Controls);

        }
    }
}
