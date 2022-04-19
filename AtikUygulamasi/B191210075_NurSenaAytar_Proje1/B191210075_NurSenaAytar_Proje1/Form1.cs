using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace B191210075_NurSenaAytar_Proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sure = 60;
        int toplamAgirlik = 0;
        double toplamAVitamin = 0;
        double toplamCVitamin = 0;
        double toplamSiviPureHal = 0;
        string[] dosyalar = Directory.GetFiles("meyve");
       

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            button3.Enabled = false;
            button4.Enabled = false;

            label5.Text = sure.ToString();
            label6.Text = toplamAVitamin.ToString();
            label7.Text = toplamCVitamin.ToString();
            label8.Text = toplamSiviPureHal.ToString();

        }

        //Geri sayım başlatılır.
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Zamanlayıcı ilk başladığında rastgele resim gösterir.
            if(sure==60)
            {
                Random r = new Random();
                pictureBox1.ImageLocation = dosyalar[r.Next(0, dosyalar.Length)];
            }
            //Kalan süre 0dan buyukse süreyi azaltır.
            if(sure>=0)
            {
                timer1.Interval = 1000;
                int sayac = sure--;
                label5.Text = sayac.ToString();

            }
            //Süre bittiyse butonlara basmayı engeller.
            else
            {
                button3.Enabled = false;
                button4.Enabled = false;
                timer1.Stop();
                button1.Enabled = true;
            }
        }

        //Oyuna başlanır.
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            sure = 60;
            timer1.Start();
            toplamAgirlik = 0;
            toplamAVitamin = 0;
            toplamCVitamin = 0;
            toplamSiviPureHal = 0;
            label6.Text = Convert.ToString(toplamAVitamin);
            label7.Text = Convert.ToString(toplamCVitamin);
            label8.Text = Convert.ToString(toplamSiviPureHal);
            label10.Text = Convert.ToString(toplamAgirlik);
            button3.Enabled = true;
            button4.Enabled = true;
        }

        //Sistemden çıkış yapılır.
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            //Eğer pictureBox'taki resim greyfurt ise greyfurt için istenen değerler hesaplanır.
            if (pictureBox1.ImageLocation == dosyalar[3])
            {
                Greyfurt greyfurt = new Greyfurt();
                greyfurt.AgirlikHesaplama();
                greyfurt.VitaminAHesaplama();
                greyfurt.VitaminCHesaplama();
                greyfurt.verimNarenciyeSikacagi();

                toplamAgirlik += greyfurt.AgirlikHesaplama();
                toplamAVitamin += greyfurt.VitaminAHesaplama();
                toplamCVitamin += greyfurt.VitaminCHesaplama();
                toplamSiviPureHal += greyfurt.verimNarenciyeSikacagi();
                label6.Text = Convert.ToString(toplamAVitamin);
                label7.Text = Convert.ToString(toplamCVitamin);
                label8.Text = Convert.ToString(toplamSiviPureHal);
                label10.Text = Convert.ToString(toplamAgirlik);

                string agirligi= Convert.ToString(greyfurt.AgirlikHesaplama());
                string verimi = Convert.ToString(greyfurt.verimNarenciyeSikacagi());
                string AVitamin = Convert.ToString(greyfurt.VitaminAHesaplama());
                string CVitamin = Convert.ToString(greyfurt.VitaminCHesaplama());

                listBox3.Items.Add("Greyfurt (" + verimi + ")");
                listBox1.Items.Add("Greyfurt (" + AVitamin + ")");
                listBox2.Items.Add("Greyfurt (" + CVitamin + ")");
                listBox4.Items.Add("Greyfurt (" + agirligi + ")");

                //Rastgele resim seçilir.
                Random r = new Random();
                pictureBox1.ImageLocation = dosyalar[r.Next(0, dosyalar.Length)];
            }

            //Eğer pictureBox'taki resim mandalina ise mandalina için istenen değerler hesaplanır.
            if (pictureBox1.ImageLocation == dosyalar[4])
            {
                Mandalina mandalina = new Mandalina();
                mandalina.AgirlikHesaplama();
                mandalina.VitaminAHesaplama();
                mandalina.VitaminCHesaplama();
                mandalina.verimNarenciyeSikacagi();

                toplamAgirlik += mandalina.AgirlikHesaplama();
                toplamAVitamin += mandalina.VitaminAHesaplama();
                toplamCVitamin += mandalina.VitaminCHesaplama();
                toplamSiviPureHal += mandalina.verimNarenciyeSikacagi();
                label6.Text = Convert.ToString(toplamAVitamin);
                label7.Text = Convert.ToString(toplamCVitamin);
                label8.Text = Convert.ToString(toplamSiviPureHal);
                label10.Text = Convert.ToString(toplamAgirlik);

                string agirligi = Convert.ToString(mandalina.AgirlikHesaplama());
                string verimi = Convert.ToString(mandalina.verimNarenciyeSikacagi());
                string AVitamin = Convert.ToString(mandalina.VitaminAHesaplama());
                string CVitamin = Convert.ToString(mandalina.VitaminCHesaplama());
                listBox3.Items.Add("Mandalina (" + verimi + ")");
                listBox1.Items.Add("Mandalina (" + AVitamin + ")");
                listBox2.Items.Add("Mandalina (" + CVitamin + ")");
                listBox4.Items.Add("Mandalina (" + agirligi + ")");

                //Rastgele resim seçilir.
                Random r = new Random();
                pictureBox1.ImageLocation = dosyalar[r.Next(0, dosyalar.Length)];
            }

            //Eğer pictureBox'taki resim portakal ise portakal için istenen değerler hesaplanır.
            if (pictureBox1.ImageLocation == dosyalar[5])
            {
                Portakal portakal = new Portakal();
                portakal.AgirlikHesaplama();
                portakal.VitaminAHesaplama();
                portakal.VitaminCHesaplama();
                portakal.verimNarenciyeSikacagi();

                toplamAgirlik += portakal.AgirlikHesaplama();
                toplamAVitamin += portakal.VitaminAHesaplama();
                toplamCVitamin += portakal.VitaminCHesaplama();
                toplamSiviPureHal += portakal.verimNarenciyeSikacagi();
                label6.Text = Convert.ToString(toplamAVitamin);
                label7.Text = Convert.ToString(toplamCVitamin);
                label8.Text = Convert.ToString(toplamSiviPureHal);
                label10.Text = Convert.ToString(toplamAgirlik);

                string agirligi = Convert.ToString(portakal.AgirlikHesaplama());
                string verimi = Convert.ToString(portakal.verimNarenciyeSikacagi());
                string AVitamin = Convert.ToString(portakal.VitaminAHesaplama());
                string CVitamin = Convert.ToString(portakal.VitaminCHesaplama());
                listBox3.Items.Add("Portakal (" + verimi + ")");
                listBox1.Items.Add("Portakal (" + AVitamin + ")");
                listBox2.Items.Add("Portakal (" + CVitamin + ")");
                listBox4.Items.Add("Portakal (" + agirligi + ")");

                //Rastgele resim seçilir.
                Random r = new Random();
                pictureBox1.ImageLocation = dosyalar[r.Next(0, dosyalar.Length)];
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Eğer pictureBox'taki resim armut ise armut için istenen değerler hesaplanır.
            if (pictureBox1.ImageLocation == dosyalar[0])
            {
                Armut armut = new Armut();
                armut.AgirlikHesaplama();
                armut.VitaminAHesaplama();
                armut.VitaminCHesaplama();
                armut.verimKatiMeyveSikacagi();

                toplamAgirlik += armut.AgirlikHesaplama();
                toplamAVitamin += armut.VitaminAHesaplama();
                toplamCVitamin += armut.VitaminCHesaplama();
                toplamSiviPureHal += armut.verimKatiMeyveSikacagi();
                label6.Text = Convert.ToString(toplamAVitamin);
                label7.Text = Convert.ToString(toplamCVitamin);
                label8.Text = Convert.ToString(toplamSiviPureHal);
                label10.Text = Convert.ToString(toplamAgirlik);

                string agirligi = Convert.ToString(armut.AgirlikHesaplama());
                string verimi = Convert.ToString(armut.verimKatiMeyveSikacagi());
                string AVitamin = Convert.ToString(armut.VitaminAHesaplama());
                string CVitamin = Convert.ToString(armut.VitaminCHesaplama());
                listBox3.Items.Add("Armut (" + verimi + ")");
                listBox1.Items.Add("Armut (" + AVitamin + ")");
                listBox2.Items.Add("Armut (" + CVitamin + ")");
                listBox4.Items.Add("Armut (" + agirligi + ")");

                //Rastgele resim seçilir.
                Random r = new Random();
                pictureBox1.ImageLocation = dosyalar[r.Next(0, dosyalar.Length)];

            }

            //Eğer pictureBox'taki resim cilek ise cilek için istenen değerler hesaplanır.
            if (pictureBox1.ImageLocation == dosyalar[1])
            {
                Cilek cilek = new Cilek();
                cilek.AgirlikHesaplama();
                cilek.VitaminAHesaplama();
                cilek.VitaminCHesaplama();
                cilek.verimKatiMeyveSikacagi();

                toplamAgirlik += cilek.AgirlikHesaplama();
                toplamAVitamin += cilek.VitaminAHesaplama();
                toplamCVitamin += cilek.VitaminCHesaplama();
                toplamSiviPureHal += cilek.verimKatiMeyveSikacagi();
                label6.Text = Convert.ToString(toplamAVitamin);
                label7.Text = Convert.ToString(toplamCVitamin);
                label8.Text = Convert.ToString(toplamSiviPureHal);
                label10.Text = Convert.ToString(toplamAgirlik);

                string agirligi = Convert.ToString(cilek.AgirlikHesaplama());
                string verimi = Convert.ToString(cilek.verimKatiMeyveSikacagi());
                string AVitamin = Convert.ToString(cilek.VitaminAHesaplama());
                string CVitamin = Convert.ToString(cilek.VitaminCHesaplama());
                listBox3.Items.Add("Çilek (" + verimi + ")");
                listBox1.Items.Add("Çilek (" + AVitamin + ")");
                listBox2.Items.Add("Çilek (" + CVitamin + ")");
                listBox4.Items.Add("Çilek (" + agirligi + ")");

                //Rastgele resim seçilir.
                Random r = new Random();
                pictureBox1.ImageLocation = dosyalar[r.Next(0, dosyalar.Length)];
            }

            //Eğer pictureBox'taki resim elma ise elma için istenen değerler hesaplanır.
            if (pictureBox1.ImageLocation == dosyalar[2])
            {
                Elma elma = new Elma();
                elma.AgirlikHesaplama();
                elma.VitaminAHesaplama();
                elma.VitaminCHesaplama();
                elma.verimKatiMeyveSikacagi();

                toplamAgirlik += elma.AgirlikHesaplama();
                toplamAVitamin += elma.VitaminAHesaplama();
                toplamCVitamin += elma.VitaminCHesaplama();
                toplamSiviPureHal += elma.verimKatiMeyveSikacagi();
                label6.Text = Convert.ToString(toplamAVitamin);
                label7.Text = Convert.ToString(toplamCVitamin);
                label8.Text = Convert.ToString(toplamSiviPureHal);
                label10.Text = Convert.ToString(toplamAgirlik);

                string agirligi = Convert.ToString(elma.AgirlikHesaplama());
                string verimi = Convert.ToString(elma.verimKatiMeyveSikacagi());
                string AVitamin = Convert.ToString(elma.VitaminAHesaplama());
                string CVitamin = Convert.ToString(elma.VitaminCHesaplama());
                listBox3.Items.Add("Elma (" + verimi + ")");
                listBox1.Items.Add("Elma (" + AVitamin + ")");
                listBox2.Items.Add("Elma (" + CVitamin + ")");
                listBox4.Items.Add("Elma (" + agirligi + ")");

                //Rastgele resim seçilir.
                Random r = new Random();
                pictureBox1.ImageLocation = dosyalar[r.Next(0, dosyalar.Length)];
            }

        }

    }
}
