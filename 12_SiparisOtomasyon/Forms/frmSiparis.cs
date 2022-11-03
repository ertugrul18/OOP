using _12_SiparisOtomasyon.Entities;
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
    public partial class frmSiparis : Form
    {
        public frmSiparis()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmSiparis_Load(object sender, EventArgs e)
        {

            foreach (var item in Form1.Menuler)
            {
                cmbmenu.Items.Add(item);
            }
            foreach (var ex in Form1.Extralar)
            {
                flvpExtra.Controls.Add(new CheckBox() { Text = ex.ExtraAdi, Tag = ex });
            }
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            Siparis yenisiparis = new Siparis();
            if (radioButton1.Checked)
                yenisiparis.Boyut = Boyut.Kucuk;
            else if (radioButton2.Checked)
                yenisiparis.Boyut = Boyut.Orta;
            else
                yenisiparis.Boyut = Boyut.Buyuk;

            yenisiparis.Adet = (int)nmradet.Value;

            yenisiparis.Extralar = new List<Extra>();
            foreach (CheckBox item in flvpExtra.Controls)
            {
                if (item.Checked)
                {
                    yenisiparis.Extralar.Add((Extra)item.Tag);
                }
            }

            yenisiparis.SeciliMenu = (_12_SiparisOtomasyon.Entities.Menu)cmbmenu.SelectedItem;

            yenisiparis.Hesapla();

            Form1.MevcutSiparis.Add(yenisiparis);

            lstSiparisler.Items.Add(yenisiparis);
            TutarHesapla();

            Tools.Temizle(this.Controls);
        }
        private decimal TutarHesapla()
        {
            decimal toplamtutar = 0;

            for (int i = 0; i < lstSiparisler.Items.Count; i++)
            {
                Siparis gelen = (Siparis)lstSiparisler.Items[i];
                toplamtutar += gelen.ToplamTutar;
            }
            lblToplamtutar.Text = toplamtutar.ToString("C2");

            return toplamtutar;

        }

        private void btntamamla_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Toplam siparis Ucreti:" + TutarHesapla().ToString("C2")
               + " Satin almaya devam etmek istermisiniz ?", "Siparis Bilgisi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                lstSiparisler.Items.Clear();

            }
            else
            {
                MessageBox.Show("Siparis Iptal edildi");
            }

        }
    }
}
