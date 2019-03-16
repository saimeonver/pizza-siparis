using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp3.Enums.Enum;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //        Class yapısı ile yapıyorum,
        //Enum Kullanıyorum,
        //Order Date = Sipariş verildiğinde
        //  tarihi atanmalı
        //  Ekstra eklediğim her değer
        //0.50 kuruş arttıracak.
        //Telefon no,10 hane olmalı başında 0 olmamalı.
        //isteyen farklı formlar açabilir.
        //isteyen aynı formda gösterebilir.
        //Kupon kodunu yazılımcı biliyor, kullanıcı doğru girerse %20 indirim uygulansın toplam tutar üzerinden

        double toplam;
        double toplamt;
        double toplamt1;
        double sonuc;
        double sonuc1;
        int sayac = 1;
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox2.DataSource = Enum.GetValues(typeof(OdemeSekli));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temizle();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        string[] dizi = new string[5];
        private void button2_Click(object sender, EventArgs e)
        {
            
            Bilgiler b = new Bilgiler();
            {

                b.Ad = textBox1.Text;
                b.Adres = textBox2.Text;
                b.Sehir = textBox3.Text;
                b.PostaKodu = Convert.ToInt32(textBox4.Text);
                b.Telefon = Convert.ToInt64(textBox5.Text);
                b.qty = Convert.ToInt32(textBox6.Text);
                b.KuponNumarasi = textBox7.Text;
                b.KrediKartiNumarasi = Convert.ToInt32(textBox8.Text);
                b.SonKullanmaTarihi = dateTimePicker1.Value.ToShortDateString();

                




                string[] bilgiler = { b.Ad, b.Adres, b.Sehir, b.PostaKodu.ToString(), b.Telefon.ToString(), " ", " ", b.qty.ToString(), b.KuponNumarasi.ToString(), " ", b.KrediKartiNumarasi.ToString(), b.SonKullanmaTarihi.ToString() };





                label5.Text = b.Tarih.ToString();


                if (radioButton1.Checked)
                {
                    bilgiler[5] = "KÜÇÜK";
                    toplam = 15;
                }
                else if (radioButton2.Checked)
                {
                    bilgiler[5] = "ORTA";
                    toplam = 20;
                }
                else if (radioButton3.Checked)
                {
                    bilgiler[5] = "BÜYÜK";
                    toplam = 25;
                }


                if (checkBox1.Checked)
                {
                    bilgiler[6] += "Sosis ";
                    toplam += 0.5;
                }

                if (checkBox2.Checked)
                {
                    bilgiler[6] += "Sucuk ";
                    toplam += 0.5;
                }

                if (checkBox3.Checked)
                {
                    bilgiler[6] += "Peperoni ";
                    toplam += 0.5;
                }

                if (checkBox4.Checked)
                {
                    bilgiler[6] += "Soğan ";
                    toplam += 0.5;
                }

                if (checkBox5.Checked)
                {
                    bilgiler[6] += "Zeytin ";
                    toplam += 0.5;
                }
                if (checkBox6.Checked)

                {
                    bilgiler[6] += "Ekstra Peynir ";
                    toplam += 0.5;
                }


                if (comboBox2.SelectedIndex == 0)
                {
                    bilgiler[9] += "Nakit";

                }

                if (comboBox2.SelectedIndex == 1)
                {
                    bilgiler[9] += "Kredi Kartı";

                }


                const double kdv = 0.18;
                toplamt1 = toplam * b.qty;
                if (b.KuponNumarasi == "123456")
                {  MessageBox.Show("% 20 İNDİRİM KAZANDINIZ");
                    toplamt += toplamt1 - (toplamt1 * 0.2);
                    label16.Text = toplamt.ToString();
                    sonuc = kdv * toplamt;
                    label18.Text = sonuc.ToString();
                    sonuc1 = toplamt + sonuc;
                    label20.Text = sonuc1.ToString();
                    
                }
                else
                {
                    label16.Text = toplamt1.ToString();
                    sonuc = kdv * toplamt1;
                    label18.Text = sonuc.ToString();
                    sonuc1 = toplamt1 + sonuc;
                    label20.Text = sonuc1.ToString();
                    

                }
               
               
                sayac++;
                label13.Text = sayac + " .Sipariş";

                
                listView1.Items.Add(new ListViewItem(bilgiler));
                
            }
        }

        void temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }

            foreach (Control item in this.groupBox3.Controls)
            {
                if(item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
            
            foreach (Control item in this.groupBox1.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton rb = (RadioButton)item;
                    rb.Checked = false;
                }

            }

            foreach (Control item in this.groupBox2.Controls)
            {
                if (item is CheckBox)
                {
                    CheckBox chbox = (CheckBox)item;
                    chbox.Checked = false;
                }


            }
            
            label5.Text = "";
            label16.Text = "";
            label18.Text = "";
            label20.Text = "";
           


        }
        }
    }

//private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
//{

//}


