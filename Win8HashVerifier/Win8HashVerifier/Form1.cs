using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Win8HashVerifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static SHA1 sha1 = new SHA1CryptoServiceProvider();
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Windows 8 İso dosyasını seçiniz.."; 
            openFileDialog1.Filter = "İso Dosyaları (*.iso) | *.iso";
			if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            textBox1.Text = System.IO.Path.GetFileName(openFileDialog1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            using (FileStream stream = File.OpenRead(this.textBox1.Text))
            {
                byte[] sha1Checksum = sha1.ComputeHash(stream);
                this.textBox2.Text = BitConverter.ToString(sha1Checksum).Replace("-", string.Empty);
            }
            if ("22D680EC53336BEE8A5B276A972CEBA104787F62" == textBox2.Text.ToString())
                {
                    listBox1.Items.Add("Orjinal Dosya Adı:tr_windows_8_x86_dvd_915522.iso");
                    listBox1.Items.Add("Dil:Türkçe");
                    listBox1.Items.Add("Sürüm:Windows 8 ve Windows 8 PRO");
                    listBox1.Items.Add("Versiyon:Multiple");
                    listBox1.Items.Add("Mimari:(X86) 32 BİT");
                    listBox1.Items.Add("Çıkış Tarihi:8/15/2012");
                }
                else if ("11388CFC2DD8D50792090DBB28BA60FDB60D4DB2" == textBox2.Text.ToString())
                {
                    listBox1.Items.Add("Orjinal Dosya Adı:tr_windows_8_x64_dvd_915425.iso");
                    listBox1.Items.Add("Dil:Türkçe");
                    listBox1.Items.Add("Sürüm:Windows 8 ve Windows 8 PRO");
                    listBox1.Items.Add("Versiyon:Multiple");
                    listBox1.Items.Add("Mimari:(X64) 64 BİT");
                    listBox1.Items.Add("Çıkış Tarihi:8/15/2012");
                }
                else if ("96F25045AAF55FF4640C10C931C071ED7B2ABA69" == textBox2.Text.ToString())
                {
                    listBox1.Items.Add("Orjinal Dosya Adı:tr_windows_8_enterprise_x86_dvd_917693.iso");
                    listBox1.Items.Add("Dil:Türkçe");
                    listBox1.Items.Add("Sürüm:Windows 8");
                    listBox1.Items.Add("Versiyon:Enterprise");
                    listBox1.Items.Add("Mimari:(X86) 32 BİT");
                    listBox1.Items.Add("Çıkış Tarihi:8/15/2012");
                }
                else if ("1F9CB34B68CCCE6142272D7C5A3B0240BF8C32B6" == textBox2.Text.ToString())
                {
                    listBox1.Items.Add("Orjinal Dosya Adı:tr_windows_8_enterprise_x64_dvd_917582.iso");
                    listBox1.Items.Add("Dil:Türkçe");
                    listBox1.Items.Add("Sürüm:Windows 8");
                    listBox1.Items.Add("Versiyon:Enterprise");
                    listBox1.Items.Add("Mimari:(X64) 64 BİT");
                    listBox1.Items.Add("Çıkış Tarihi:8/15/2012");
                }
                else if ("67D2DFFC26447DB6C17E2800981E32602511E6FA" == textBox2.Text.ToString())
                {
                    listBox1.Items.Add("Orjinal Dosya Adı:tr_windows_8_pro_vl_x64_dvd_917824.iso");
                    listBox1.Items.Add("Dil:Türkçe");
                    listBox1.Items.Add("Sürüm:Windows 8");
                    listBox1.Items.Add("Versiyon:PRO VL");
                    listBox1.Items.Add("Mimari:(X64) 64 BİT");
                    listBox1.Items.Add("Çıkış Tarihi:8/15/2012");
                }
                else if ("F25930D5D81EFDB7652A74E0A244FD387B2AD236" == textBox2.Text.ToString())
                {
                    listBox1.Items.Add("Orjinal Dosya Adı:tr_windows_8_pro_vl_x86_dvd_917731.iso");
                    listBox1.Items.Add("Dil:Türkçe");
                    listBox1.Items.Add("Sürüm:Windows 8");
                    listBox1.Items.Add("Versiyon:PRO VL");
                    listBox1.Items.Add("Mimari:(X86) 32 BİT");
                    listBox1.Items.Add("Çıkış Tarihi:8/15/2012");
                }
                else
                {
                    listBox1.Items.Add("Bilinmeyen İSO Dosyası");
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.sezerturkmen.com/win8hashverifier");
        }
    }
}
