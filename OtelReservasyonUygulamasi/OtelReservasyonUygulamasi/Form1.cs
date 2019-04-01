using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OtelReservasyonUygulamasi
{
    public partial class Form1 : Form
    {
        private Otel otel;
        private int hangiTip;
        private int kisiSayisi;
        private int rez_no;
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
        }

        private void buttonRezYap_Click(object sender, EventArgs e)
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
            hangiTip = Convert.ToInt32(comboBoxOdaTip.SelectedIndex);
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


            textBox1.Text += kisiSayisi.ToString() + "\r\n";
            textBox1.Text += comboBoxOdaTip.SelectedItem.ToString() + "\r\n";
            textBox1.Text += dateTimePickerBasTar.Text + "\r\n";
            textBox1.Text += dateTimePickerBitTar.Text + "\r\n";
            textBox1.Text += hangiTip.ToString() + "\r\n";

        }

        private void comboBoxOdaTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxKisi.Enabled = true;
            comboBoxKisi.Items.Clear();
       
            if(comboBoxOdaTip.SelectedIndex == 0)
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
    }
}
