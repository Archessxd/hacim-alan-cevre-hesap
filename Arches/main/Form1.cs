using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class Form1 : Form
    {
        const double pi = 3.14;
        double birinciDegisken, ikinciDegisken, yukseklik;
        string obje, birim;
        public Form1()
        {
            InitializeComponent();
        }
        public  class islemler
        {
            //küre
            public void cevreKure(double yaricap)
            {
                double sonuc = 2 / pi * yaricap;
                MessageBox.Show("kürenin çevresi = " + sonuc.ToString());
            }
        
            public void hacimKure(double yaricap)
            {
                double sonuc = 4 / 3 * pi * (yaricap * yaricap * yaricap);
                MessageBox.Show("kürenin hacmi = " + sonuc.ToString());
            }

            public void alanKure(double yaricap)
            {
                double sonuc = 4 * pi * (yaricap * yaricap);
                MessageBox.Show("kürenin alanı = " + sonuc.ToString());
            }
            
            //silindir
            public void cevreSilindir(double yaricap , double h)
            {
                double tabanCevreSonuc = 2 * pi * yaricap;
                double boyCevreSonuc = 2 * (h + (yaricap * yaricap));
                MessageBox.Show("taban çevresi = " + tabanCevreSonuc.ToString() + " " + "düşey çevresi = " + boyCevreSonuc.ToString());
            }
        
            public void hacimSilindir(double yaricap, double h) 
            {
                double sonuc = 2 * pi * (yaricap * yaricap) * h;
                MessageBox.Show("silindirin hacmi =" + sonuc.ToString());
            }

            public void alanSilindir(double yaricap)
            {
                double sonuc = pi * (yaricap * yaricap);
                MessageBox.Show("silindirin alanı =" + sonuc.ToString());
            }

            //Dikdörtgenler Prizması
            public void cevrePrizma(double uzunluk , double genislik , double h)
            {
                double sonuc = (uzunluk + genislik + h) * 4;
                MessageBox.Show("Prizmanın çevresi = " + sonuc.ToString());
            }

            public void hacimPrizma(double h, double birincikenar, double ikincikenar)
            {
                double sonuc = birincikenar * h * ikincikenar;
                MessageBox.Show("Prizmanın Hacmi = " + sonuc.ToString());
            }
            
            public void alanPrizma(double birinci , double ikinci , double ucuncu)
            {
                double sonuc = 2 * ((birinci * ikinci) * (ikinci * ucuncu) * (birinci * ucuncu));
                MessageBox.Show("Prizmanın alanı =" + sonuc.ToString());
            }

        
        }

        private void cevreRBT_CheckedChanged(object sender, EventArgs e)
        {
            if (cevreRBT.Checked==true)
            {
                birim = "cevre";
            }
        }

        private void hacimRBT_CheckedChanged(object sender, EventArgs e)
        {
            if (hacimRBT.Checked==true)
            {
                birim = "hacim";
            }
        }

        private void alanRBT_CheckedChanged(object sender, EventArgs e)
        {
            if (alanRBT.Checked==true)
            {
                birim = "alan";
            }
        }

        private void kureRBT_CheckedChanged(object sender, EventArgs e)
        {
            if (kureRBT.Checked==true) 
            {
                obje = "kure";
                
            }
        }

        private void silindirRBT_CheckedChanged(object sender, EventArgs e)
        {
            if (silindirRBT.Checked==true)
            {
                obje = "silindir";
            }
        }

        private void dPrizmasiRBT_CheckedChanged(object sender, EventArgs e)
        {
            if (dPrizmasiRBT.Checked==true)
            {
                obje = "prizma";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
        }

        private void onaylaBTN_Click(object sender, EventArgs e)
        {
            if (obje==null || birim == null)
            {
                MessageBox.Show("lütfen seçenekleri işaretleyin");
            }
            else if (birim!=null || obje !=null) 
            {
                groupBox2.Enabled = true;
                groupBox1.Enabled = false;
                ObjectsGroupBox.Enabled = false;

                //cevre
                if (birim == "cevre" && obje == "kure")
                {
                    yariCapLabel.Text = "yarıçap (r)";
                    yukseklikLabel.Visible = false;
                    yukseklikTextBox.Visible = false;
                    ikinciKenarLabel.Visible = false;
                    ikinciKenarTextBox.Visible = false;
                }
            
                else if (birim == "cevre" && obje=="silindir")
                {
                    yukseklikLabel.Visible = true;
                    yukseklikTextBox.Visible = true;        
                    yariCapLabel.Text = "yarıçap (r)";
                    ikinciKenarLabel.Visible = false;
                    ikinciKenarTextBox.Visible = false;
                }
            
                else if (birim == "cevre" && obje =="prizma")
                {
                    ikinciKenarLabel.Visible = true;
                    ikinciKenarTextBox.Visible = true;
                    yariCapLabel.Text = "birinci kenar";
                    yukseklikLabel.Visible = true;
                    yukseklikTextBox.Visible = true;
                    
                }
                
                
                //hacim
                else if (birim == "hacim" && obje=="kure")
                {
                    yukseklikLabel.Visible = false;
                    yukseklikTextBox.Visible = false;
                    ikinciKenarLabel.Visible = false;
                    ikinciKenarTextBox.Visible = false;
                    yariCapLabel.Text = "birinci kenar";
                }
            
                else if (birim == "hacim" && obje == "silindir")
                {
                    yukseklikLabel.Visible = true;
                    yukseklikTextBox.Visible = true;
                    yariCapLabel.Text = "yaricap (r)";
                    ikinciKenarLabel.Visible = false;
                    ikinciKenarTextBox.Visible = false;
                }
                else if (birim == "hacim" && obje == "prizma")
                {
                    yariCapLabel.Text = "birinci kenar";
                    ikinciKenarLabel.Visible = true;
                    ikinciKenarTextBox.Visible = true;
                    yukseklikLabel.Visible = true;
                    yukseklikTextBox.Visible = true;
                }
                

                //alan
                else if (birim == "alan" && obje=="kure")
                {
                    yariCapLabel.Text = "yaricap (r)";
                    yukseklikLabel.Visible = false;
                    yukseklikTextBox.Visible = false;
                }

                else if (birim == "alan" && obje == "silindir")
                {
                    yukseklikLabel.Visible = false;
                    yukseklikTextBox.Visible = false;
                    ikinciKenarLabel.Visible = false;
                    ikinciKenarTextBox.Visible = false;
                    yariCapLabel.Text = "yaricap (r)";
                }
                
                else if (birim == "alan" && obje == "prizma")
                {
                    yukseklikLabel.Visible = true;
                    yukseklikTextBox.Visible = true;
                    ikinciKenarTextBox.Visible = true;
                    ikinciKenarLabel.Visible = true;
                    yariCapLabel.Text = "birinci kenar";

                }

            }
            
        }

        private void yenidenSecBTN_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            obje = null;
            birim = null;
            groupBox2.Enabled = false;
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            islemler i = new islemler();
            birinciDegisken = Convert.ToDouble(yaricapTextBox.Text);

            //cevre
            if (birim == "cevre" && obje == "kure")
            {
                i.cevreKure(birinciDegisken);    
            }

            else if (birim == "cevre" && obje == "silindir")
            {
                yukseklik = Convert.ToDouble(yukseklikTextBox.Text);
                i.cevreSilindir(birinciDegisken , yukseklik);
            }

            else if (birim == "cevre" && obje == "prizma")
            {
                yukseklik = Convert.ToDouble(yukseklikTextBox.Text);
                ikinciDegisken = Convert.ToDouble(ikinciKenarTextBox.Text);
                i.cevrePrizma(birinciDegisken , yukseklik , ikinciDegisken);
            }
            

            //hacim
            else if (birim == "hacim" && obje == "kure")
            {
                i.hacimKure(birinciDegisken);
            }

            else if (birim == "hacim" && obje == "silindir")
            {
                yukseklik = Convert.ToDouble(yukseklikTextBox.Text);

                i.hacimSilindir(birinciDegisken , yukseklik);
            }
                
            else if (birim == "hacim" && obje == "prizma")
            {
                yukseklik = Convert.ToDouble(yukseklikTextBox.Text);
                ikinciDegisken = Convert.ToDouble(ikinciKenarTextBox.Text);
                i.hacimPrizma(birinciDegisken, ikinciDegisken, yukseklik);
            }
            
            //alan
            else if (birim == "alan" && obje =="kure")
            {
                i.alanKure(birinciDegisken);
            }

            else if (birim == "alan" && obje == "silindir")
            {
                i.alanSilindir(birinciDegisken);
            }

            else if (birim == "alan" && obje == "prizma")
            {
                yukseklik = Convert.ToDouble(yukseklikTextBox.Text);
                ikinciDegisken = Convert.ToDouble(ikinciKenarTextBox.Text);
                i.alanPrizma(birinciDegisken, yukseklik, ikinciDegisken);
            }


        }
    }
}
