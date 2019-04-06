using System;
using System.Windows.Forms;
using System.Collections.Generic;


namespace OtelReservasyonUygulamasi
{
    public partial class Form1 : Form
    {
        private Otel otel;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            otel = new Otel(35); //toplam oda sayısı gönderilip otel oluşturuluyor  
        }

        private void dateTimePickerBasTar_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerBitTar.MinDate = dateTimePickerBasTar.Value.AddDays(1);
            dateTimePickerBitTar.Enabled = true;
            //seçilebilecek bitiş tarihini başlangıç tarihinin 1 fazlası yapıyor.
        }

        private void comboBoxOdaTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxKisi.Enabled = true;
            comboBoxKisi.Items.Clear();
            comboBoxKisi.SelectedItem = null;
            comboBoxKisi.Text = null;

            if (comboBoxOdaTip.SelectedIndex == 0)
            {
                comboBoxKisi.Items.Add(1);
                comboBoxKisi.SelectedItem = false;
            }
            else
            {
                comboBoxKisi.Items.Add(1);
                comboBoxKisi.Items.Add(2);
            }
            //Oda tipine göre seçilebilecek kişi sayısı belirleniyor.
        }

        private void buttonRezYap_Click(object sender, EventArgs e) //RezervasyonYap
        {
            int hangiTip;
            Type tip;
            int kisiSayisi;
            int oda_no;
            DateTime basTar;
            DateTime bitTar;

            if(comboBoxKisi.SelectedItem == null && comboBoxOdaTip.SelectedItem == null)
            {
                MessageBox.Show("Lütfen önce seçimlerinizi yapınız.");
                return;
            }
            if (comboBoxKisi.SelectedItem == null)
            {
                MessageBox.Show("Hatalı kişi sayısı!");
                return;
            }
            if (comboBoxOdaTip.SelectedItem == null)
            {
                MessageBox.Show("Hatalı oda tipi seçimi!");
                return;
            }

                
            kisiSayisi = Convert.ToInt32(comboBoxKisi.SelectedItem);
            hangiTip = Convert.ToInt32(comboBoxOdaTip.SelectedIndex); //0: TekYatakli 1:CiftYatakli 2:IkizYatakli

            if(hangiTip == 0)
            {
                tip = typeof(TekYatakliOda);
            }
            else if (hangiTip == 1)
            {
                tip = typeof(CiftYatakliOda);
            }
            else
            {
                tip = typeof(IkizYatakliOda);
            }

 
            basTar = dateTimePickerBasTar.Value;
            bitTar = dateTimePickerBitTar.Value;

            Rezervasyon rezervasyon = new Rezervasyon(kisiSayisi, basTar, bitTar);
            oda_no = otel.rezervasyonYap(rezervasyon, tip);

            if(oda_no == 0)
            {
                MessageBox.Show("Rezervasyon başarısız!");
            }
            else
            {
                MessageBox.Show("Rezervasyonunuz " + oda_no + " no lu odaya yapıldı." +
                    "\nRezervasyon numaranız: " + rezervasyon.No);
                listView1.Items.Clear();
            }
            
        }

        private void RezIpt_Click(object sender, EventArgs e) //Rezervasyon İptal
        {
            if (Int32.TryParse(textBoxRezIpt.Text, out int value))  //Eğer numerik ise
            {
                if (otel.rezervasyonIptal(Convert.ToInt32(textBoxRezIpt.Text))){
                    MessageBox.Show("Rezervasyonunuz başarıyla iptal edildi.");
                    listView1.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Böyle bir rezervasyon bulunmamaktadır.");
                }
            }
            else
            {
                //Eğer numerik değilse
                MessageBox.Show("Lütfen doğru formatta sayı giriniz.");
            }
            textBoxRezIpt.Text = null;
        }
        
        private void RezYaz_Click(object sender, EventArgs e) //Rezervasyon listele
        {
            listView1.Items.Clear();
            foreach (Oda oda in otel.Odalar)
            {
                foreach (Rezervasyon rez in oda.Rezervasyonlar)
                {
                    ListViewItem ekle = new ListViewItem(rez.No.ToString());
                    ekle.SubItems.Add(oda.No.ToString());
                    ekle.SubItems.Add(oda.GetType().Name.ToString());
                    ekle.SubItems.Add(rez.Kisi_sayisi.ToString());
                    ekle.SubItems.Add(rez.Baslangic_Tarihi.ToShortDateString());
                    ekle.SubItems.Add(rez.Bitis_Tarihi.ToShortDateString());
                    listView1.Items.Add(ekle);
                }
            }
        }
    }
}
