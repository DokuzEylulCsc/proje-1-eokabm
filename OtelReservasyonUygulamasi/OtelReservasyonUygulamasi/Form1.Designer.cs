namespace OtelReservasyonUygulamasi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxKisi = new System.Windows.Forms.ComboBox();
            this.buttonRezYap = new System.Windows.Forms.Button();
            this.RezIpt = new System.Windows.Forms.Button();
            this.RezYaz = new System.Windows.Forms.Button();
            this.labelKisi = new System.Windows.Forms.Label();
            this.labelOdaTip = new System.Windows.Forms.Label();
            this.comboBoxOdaTip = new System.Windows.Forms.ComboBox();
            this.dateTimePickerBasTar = new System.Windows.Forms.DateTimePicker();
            this.labelBasTar = new System.Windows.Forms.Label();
            this.dateTimePickerBitTar = new System.Windows.Forms.DateTimePicker();
            this.labelBitTar = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxRezIpt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxKisi
            // 
            this.comboBoxKisi.CausesValidation = false;
            this.comboBoxKisi.Enabled = false;
            this.comboBoxKisi.FormattingEnabled = true;
            this.comboBoxKisi.Location = new System.Drawing.Point(200, 62);
            this.comboBoxKisi.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxKisi.MaxDropDownItems = 2;
            this.comboBoxKisi.MaxLength = 1;
            this.comboBoxKisi.Name = "comboBoxKisi";
            this.comboBoxKisi.Size = new System.Drawing.Size(63, 24);
            this.comboBoxKisi.TabIndex = 0;
            // 
            // buttonRezYap
            // 
            this.buttonRezYap.Location = new System.Drawing.Point(83, 159);
            this.buttonRezYap.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRezYap.Name = "buttonRezYap";
            this.buttonRezYap.Size = new System.Drawing.Size(305, 28);
            this.buttonRezYap.TabIndex = 1;
            this.buttonRezYap.Text = "Rezervasyon Yap";
            this.buttonRezYap.UseVisualStyleBackColor = true;
            this.buttonRezYap.Click += new System.EventHandler(this.buttonRezYap_Click);
            // 
            // RezIpt
            // 
            this.RezIpt.Location = new System.Drawing.Point(83, 262);
            this.RezIpt.Margin = new System.Windows.Forms.Padding(4);
            this.RezIpt.Name = "RezIpt";
            this.RezIpt.Size = new System.Drawing.Size(305, 28);
            this.RezIpt.TabIndex = 2;
            this.RezIpt.Text = "Rezervasyon İptal Et";
            this.RezIpt.UseVisualStyleBackColor = true;
            this.RezIpt.Click += new System.EventHandler(this.RezIpt_Click);
            // 
            // RezYaz
            // 
            this.RezYaz.Location = new System.Drawing.Point(83, 312);
            this.RezYaz.Margin = new System.Windows.Forms.Padding(4);
            this.RezYaz.Name = "RezYaz";
            this.RezYaz.Size = new System.Drawing.Size(305, 28);
            this.RezYaz.TabIndex = 3;
            this.RezYaz.Text = "Rezervasyonları Listele";
            this.RezYaz.UseVisualStyleBackColor = true;
            this.RezYaz.Click += new System.EventHandler(this.RezYaz_Click);
            // 
            // labelKisi
            // 
            this.labelKisi.AutoSize = true;
            this.labelKisi.Location = new System.Drawing.Point(117, 65);
            this.labelKisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKisi.Name = "labelKisi";
            this.labelKisi.Size = new System.Drawing.Size(72, 16);
            this.labelKisi.TabIndex = 5;
            this.labelKisi.Text = "Kişi Sayısı:";
            // 
            // labelOdaTip
            // 
            this.labelOdaTip.AutoSize = true;
            this.labelOdaTip.Location = new System.Drawing.Point(125, 32);
            this.labelOdaTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOdaTip.Name = "labelOdaTip";
            this.labelOdaTip.Size = new System.Drawing.Size(63, 16);
            this.labelOdaTip.TabIndex = 6;
            this.labelOdaTip.Text = "Oda Tipi:";
            // 
            // comboBoxOdaTip
            // 
            this.comboBoxOdaTip.BackColor = System.Drawing.Color.White;
            this.comboBoxOdaTip.FormattingEnabled = true;
            this.comboBoxOdaTip.Items.AddRange(new object[] {
            "Tek Yataklı",
            "Çift Yataklı",
            "İkiz Yataklı"});
            this.comboBoxOdaTip.Location = new System.Drawing.Point(200, 28);
            this.comboBoxOdaTip.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOdaTip.MaxDropDownItems = 3;
            this.comboBoxOdaTip.Name = "comboBoxOdaTip";
            this.comboBoxOdaTip.Size = new System.Drawing.Size(187, 24);
            this.comboBoxOdaTip.TabIndex = 7;
            this.comboBoxOdaTip.SelectedIndexChanged += new System.EventHandler(this.comboBoxOdaTip_SelectedIndexChanged);
            // 
            // dateTimePickerBasTar
            // 
            this.dateTimePickerBasTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBasTar.Location = new System.Drawing.Point(200, 95);
            this.dateTimePickerBasTar.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerBasTar.MaxDate = new System.DateTime(2023, 11, 30, 0, 0, 0, 0);
            this.dateTimePickerBasTar.MinDate = new System.DateTime(2019, 4, 5, 19, 59, 23, 0);
            this.dateTimePickerBasTar.Name = "dateTimePickerBasTar";
            this.dateTimePickerBasTar.Size = new System.Drawing.Size(187, 22);
            this.dateTimePickerBasTar.TabIndex = 8;
            this.dateTimePickerBasTar.Value = new System.DateTime(2019, 4, 5, 19, 59, 23, 0);
            this.dateTimePickerBasTar.ValueChanged += new System.EventHandler(this.dateTimePickerBasTar_ValueChanged);
            // 
            // labelBasTar
            // 
            this.labelBasTar.AutoSize = true;
            this.labelBasTar.Location = new System.Drawing.Point(79, 102);
            this.labelBasTar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBasTar.Name = "labelBasTar";
            this.labelBasTar.Size = new System.Drawing.Size(108, 16);
            this.labelBasTar.TabIndex = 9;
            this.labelBasTar.Text = "Başlangıç Tarihi:";
            // 
            // dateTimePickerBitTar
            // 
            this.dateTimePickerBitTar.Enabled = false;
            this.dateTimePickerBitTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBitTar.Location = new System.Drawing.Point(200, 127);
            this.dateTimePickerBitTar.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerBitTar.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerBitTar.Name = "dateTimePickerBitTar";
            this.dateTimePickerBitTar.Size = new System.Drawing.Size(187, 22);
            this.dateTimePickerBitTar.TabIndex = 10;
            // 
            // labelBitTar
            // 
            this.labelBitTar.AutoSize = true;
            this.labelBitTar.Location = new System.Drawing.Point(115, 134);
            this.labelBitTar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBitTar.Name = "labelBitTar";
            this.labelBitTar.Size = new System.Drawing.Size(73, 16);
            this.labelBitTar.TabIndex = 11;
            this.labelBitTar.Text = "Bitiş Tarihi:";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Location = new System.Drawing.Point(501, 15);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(538, 369);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Rez No";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Oda No";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Oda Tipi";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 86;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kisi Sayisi";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 92;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Baslangic";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 107;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Bitis";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 101;
            // 
            // textBoxRezIpt
            // 
            this.textBoxRezIpt.Location = new System.Drawing.Point(263, 230);
            this.textBoxRezIpt.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRezIpt.Name = "textBoxRezIpt";
            this.textBoxRezIpt.Size = new System.Drawing.Size(124, 22);
            this.textBoxRezIpt.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 234);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Silinecek Rezervasyon No:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1080, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRezIpt);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelBitTar);
            this.Controls.Add(this.dateTimePickerBitTar);
            this.Controls.Add(this.labelBasTar);
            this.Controls.Add(this.dateTimePickerBasTar);
            this.Controls.Add(this.comboBoxOdaTip);
            this.Controls.Add(this.labelOdaTip);
            this.Controls.Add(this.labelKisi);
            this.Controls.Add(this.RezYaz);
            this.Controls.Add(this.RezIpt);
            this.Controls.Add(this.buttonRezYap);
            this.Controls.Add(this.comboBoxKisi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otel Rezervasyon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKisi;
        private System.Windows.Forms.Button buttonRezYap;
        private System.Windows.Forms.Button RezIpt;
        private System.Windows.Forms.Button RezYaz;
        private System.Windows.Forms.Label labelKisi;
        private System.Windows.Forms.Label labelOdaTip;
        private System.Windows.Forms.ComboBox comboBoxOdaTip;
        private System.Windows.Forms.DateTimePicker dateTimePickerBasTar;
        private System.Windows.Forms.Label labelBasTar;
        private System.Windows.Forms.DateTimePicker dateTimePickerBitTar;
        private System.Windows.Forms.Label labelBitTar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox textBoxRezIpt;
        private System.Windows.Forms.Label label1;
    }
}

