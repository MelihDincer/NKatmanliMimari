using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace NKatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = TxtAD.Text;
            ent.Soyad = TxtSOYAD.Text;
            ent.Sehir = TxtSEHIR.Text;
            ent.Maas = short.Parse(TxtMAAS.Text);
            ent.Gorev = TxtGOREV.Text;
            LogicPersonel.LLPersonelEkle(ent);
            MessageBox.Show("Personel Başarıyla Eklendi!");
            textBox1.Text = "";
            TxtAD.Text = "";
            TxtSOYAD.Text = "";
            TxtGOREV.Text = "";
            TxtMAAS.Text = "";
            TxtSEHIR.Text = "";
            
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            if(textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Bir Id Değeri Giriniz...");
            }
            else
            {
                ent.Id = Convert.ToInt32(textBox1.Text);
                LogicPersonel.LLPersonelSil(ent.Id);
                MessageBox.Show("Personel Başarıyla Silindi...");
                List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
                dataGridView1.DataSource = PerList;
            }
            textBox1.Text = "";
            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(textBox1.Text);
            ent.Ad = TxtAD.Text;
            ent.Soyad = TxtSOYAD.Text;
            ent.Sehir = TxtSEHIR.Text;
            ent.Gorev = TxtGOREV.Text;
            ent.Maas=short.Parse(TxtMAAS.Text);
            LogicPersonel.LLPersonelGuncelle(ent);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;
        }
    }
}
