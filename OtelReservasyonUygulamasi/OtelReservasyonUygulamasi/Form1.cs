using System;
using System.Windows.Forms;
using System.Collections.Generic;


namespace OtelReservasyonUygulamasi
{
    public partial class Form1 : Form
    {
        private Otel otel;
        private int hangiTip;
        private int kisiSayisi;
        //private int rez_no;
        private int oda_no;
        private DateTime basTar;
        private DateTime bitTar;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            otel = new Otel();
        }

        private void dateTimePickerBasTar_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerBitTar.MinDate = dateTimePickerBasTar.Value;
            dateTimePickerBitTar.Enabled = true;
            //bitiş tarihi datetimerpicker ın min alabileceği değeri baş tarihinde seçilen değer yapıyor.
        }

        private void comboBoxOdaTip_SelectedIndexChanged(object sender, EventArgs e) //
        {
            comboBoxKisi.Enabled = true;
            comboBoxKisi.Items.Clear();

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
        }

        private void buttonRezYap_Click(object sender, EventArgs e) //RezervasyonYap
        {

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
            if (dateTimePickerBitTar.Text == dateTimePickerBasTar.Text)
            {
                MessageBox.Show("Bitiş Tarihi başlangıç tarihine eşit olmamalı!");
                return;
            }
            if(comboBoxKisi.SelectedIndex == 1 && comboBoxOdaTip.SelectedIndex == 0)
            {
                MessageBox.Show("Tek kişilik odaya iki kişi rezervasyon yapılamaz!");
                return;
            }


            kisiSayisi = Convert.ToInt32(comboBoxKisi.SelectedItem);
            hangiTip = Convert.ToInt32(comboBoxOdaTip.SelectedIndex); //0: TekYatakli 1:CiftYatakli 2:IkizYatakli
            basTar = dateTimePickerBasTar.Value;
            bitTar = dateTimePickerBitTar.Value;


            Rezervasyon rezervasyon = new Rezervasyon(kisiSayisi, basTar, bitTar);
            oda_no = otel.rezervasyonYap(rezervasyon, hangiTip);


            if(oda_no == 0)
            {
                MessageBox.Show("Rezervasyon basarisiz!");
            }
            else
            {
                MessageBox.Show("Rezervasyonunuz " + oda_no + " no lu odaya yapıldı.");
            }
            /*
            ListViewItem ekle = new ListViewItem(kisiSayisi.ToString());
            //ekle.SubItems.Add(kisiSayisi.ToString());
            ekle.SubItems.Add(comboBoxOdaTip.SelectedItem.ToString());
            ekle.SubItems.Add(dateTimePickerBasTar.Text);
            ekle.SubItems.Add(dateTimePickerBitTar.Text);
            ekle.SubItems.Add(hangiTip.ToString());
            listView1.Items.Add(ekle);
            */
            //buttonRezYap += Click() ;
            
        }

        private void RezIpt_Click(object sender, EventArgs e)
        {
            foreach (Oda oda in otel.odalar)
            {
                foreach (Rezervasyon rez in oda.rezervasyonlar)
                {
                    if(rez)
                }
            }
        }
        
        private void RezYaz_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (Oda oda in otel.odalar)
            {
                foreach (Rezervasyon rez in oda.rezervasyonlar)
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
