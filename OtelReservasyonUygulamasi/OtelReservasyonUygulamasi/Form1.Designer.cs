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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelKisi = new System.Windows.Forms.Label();
            this.labelOdaTip = new System.Windows.Forms.Label();
            this.comboBoxOdaTip = new System.Windows.Forms.ComboBox();
            this.dateTimePickerBasTar = new System.Windows.Forms.DateTimePicker();
            this.labelBasTar = new System.Windows.Forms.Label();
            this.dateTimePickerBitTar = new System.Windows.Forms.DateTimePicker();
            this.labelBitTar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxKisi
            // 
            this.comboBoxKisi.CausesValidation = false;
            this.comboBoxKisi.Enabled = false;
            this.comboBoxKisi.FormattingEnabled = true;
            this.comboBoxKisi.Location = new System.Drawing.Point(79, 33);
            this.comboBoxKisi.MaxDropDownItems = 2;
            this.comboBoxKisi.MaxLength = 1;
            this.comboBoxKisi.Name = "comboBoxKisi";
            this.comboBoxKisi.Size = new System.Drawing.Size(37, 21);
            this.comboBoxKisi.TabIndex = 0;
            // 
            // buttonRezYap
            // 
            this.buttonRezYap.Location = new System.Drawing.Point(12, 214);
            this.buttonRezYap.Name = "buttonRezYap";
            this.buttonRezYap.Size = new System.Drawing.Size(153, 23);
            this.buttonRezYap.TabIndex = 1;
            this.buttonRezYap.Text = "Rezervasyon Yap";
            this.buttonRezYap.UseVisualStyleBackColor = true;
            this.buttonRezYap.Click += new System.EventHandler(this.buttonRezYap_Click);
            // 
            // RezIpt
            // 
            this.RezIpt.Location = new System.Drawing.Point(12, 243);
            this.RezIpt.Name = "RezIpt";
            this.RezIpt.Size = new System.Drawing.Size(153, 23);
            this.RezIpt.TabIndex = 2;
            this.RezIpt.Text = "Rezervasyon İptal Et";
            this.RezIpt.UseVisualStyleBackColor = true;
            // 
            // RezYaz
            // 
            this.RezYaz.Location = new System.Drawing.Point(12, 272);
            this.RezYaz.Name = "RezYaz";
            this.RezYaz.Size = new System.Drawing.Size(153, 23);
            this.RezYaz.TabIndex = 3;
            this.RezYaz.Text = "Rezervasyonları Listele";
            this.RezYaz.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(564, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 426);
            this.textBox1.TabIndex = 4;
            // 
            // labelKisi
            // 
            this.labelKisi.AutoSize = true;
            this.labelKisi.Location = new System.Drawing.Point(17, 36);
            this.labelKisi.Name = "labelKisi";
            this.labelKisi.Size = new System.Drawing.Size(56, 13);
            this.labelKisi.TabIndex = 5;
            this.labelKisi.Text = "Kişi Sayısı:";
            // 
            // labelOdaTip
            // 
            this.labelOdaTip.AutoSize = true;
            this.labelOdaTip.Location = new System.Drawing.Point(23, 9);
            this.labelOdaTip.Name = "labelOdaTip";
            this.labelOdaTip.Size = new System.Drawing.Size(50, 13);
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
            this.comboBoxOdaTip.Location = new System.Drawing.Point(79, 6);
            this.comboBoxOdaTip.MaxDropDownItems = 3;
            this.comboBoxOdaTip.Name = "comboBoxOdaTip";
            this.comboBoxOdaTip.Size = new System.Drawing.Size(99, 21);
            this.comboBoxOdaTip.TabIndex = 7;
            this.comboBoxOdaTip.SelectedIndexChanged += new System.EventHandler(this.comboBoxOdaTip_SelectedIndexChanged);
            // 
            // dateTimePickerBasTar
            // 
            this.dateTimePickerBasTar.Location = new System.Drawing.Point(100, 73);
            this.dateTimePickerBasTar.MaxDate = new System.DateTime(2020, 11, 30, 0, 0, 0, 0);
            this.dateTimePickerBasTar.MinDate = new System.DateTime(2019, 3, 30, 0, 0, 0, 0);
            this.dateTimePickerBasTar.Name = "dateTimePickerBasTar";
            this.dateTimePickerBasTar.Size = new System.Drawing.Size(129, 20);
            this.dateTimePickerBasTar.TabIndex = 8;
            this.dateTimePickerBasTar.ValueChanged += new System.EventHandler(this.dateTimePickerBasTar_ValueChanged);
            // 
            // labelBasTar
            // 
            this.labelBasTar.AutoSize = true;
            this.labelBasTar.Location = new System.Drawing.Point(9, 79);
            this.labelBasTar.Name = "labelBasTar";
            this.labelBasTar.Size = new System.Drawing.Size(85, 13);
            this.labelBasTar.TabIndex = 9;
            this.labelBasTar.Text = "Başlangıç Tarihi:";
            // 
            // dateTimePickerBitTar
            // 
            this.dateTimePickerBitTar.Enabled = false;
            this.dateTimePickerBitTar.Location = new System.Drawing.Point(100, 99);
            this.dateTimePickerBitTar.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerBitTar.Name = "dateTimePickerBitTar";
            this.dateTimePickerBitTar.Size = new System.Drawing.Size(129, 20);
            this.dateTimePickerBitTar.TabIndex = 10;
            // 
            // labelBitTar
            // 
            this.labelBitTar.AutoSize = true;
            this.labelBitTar.Location = new System.Drawing.Point(36, 105);
            this.labelBitTar.Name = "labelBitTar";
            this.labelBitTar.Size = new System.Drawing.Size(58, 13);
            this.labelBitTar.TabIndex = 11;
            this.labelBitTar.Text = "Bitiş Tarihi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBitTar);
            this.Controls.Add(this.dateTimePickerBitTar);
            this.Controls.Add(this.labelBasTar);
            this.Controls.Add(this.dateTimePickerBasTar);
            this.Controls.Add(this.comboBoxOdaTip);
            this.Controls.Add(this.labelOdaTip);
            this.Controls.Add(this.labelKisi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RezYaz);
            this.Controls.Add(this.RezIpt);
            this.Controls.Add(this.buttonRezYap);
            this.Controls.Add(this.comboBoxKisi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKisi;
        private System.Windows.Forms.Button buttonRezYap;
        private System.Windows.Forms.Button RezIpt;
        private System.Windows.Forms.Button RezYaz;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelKisi;
        private System.Windows.Forms.Label labelOdaTip;
        private System.Windows.Forms.ComboBox comboBoxOdaTip;
        private System.Windows.Forms.DateTimePicker dateTimePickerBasTar;
        private System.Windows.Forms.Label labelBasTar;
        private System.Windows.Forms.DateTimePicker dateTimePickerBitTar;
        private System.Windows.Forms.Label labelBitTar;
    }
}

