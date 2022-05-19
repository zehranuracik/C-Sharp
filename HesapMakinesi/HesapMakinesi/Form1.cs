using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class form1 : Form
    {
        private char _islem;
        private bool _ekranTemizlenecekmi;
        private int _ilksayi;
        private int _sonuc;
        private int _ikincisayi;
        public form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekmi = false;
            }

            if (lblEkran.Text == "0") lblEkran.Text = "";
            lblEkran.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekmi = false;
            }

            if (lblEkran.Text == "0" || lblEkran.Text == Convert.ToString(_sonuc)) lblEkran.Text = ""; 

            lblEkran.Text += "1";
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekmi = false;
            }

            if (lblEkran.Text == "0" || lblEkran.Text == Convert.ToString(_sonuc)) lblEkran.Text = "";
            lblEkran.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekmi = false;
            }

            if (lblEkran.Text == "0" || lblEkran.Text == Convert.ToString(_sonuc)) lblEkran.Text = "";
            lblEkran.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekmi = false;
            }

            if (lblEkran.Text == "0" || lblEkran.Text == Convert.ToString(_sonuc)) lblEkran.Text = "";
            lblEkran.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekmi = false;
            }

            if (lblEkran.Text == "0" || lblEkran.Text == Convert.ToString(_sonuc)) lblEkran.Text = "";
            lblEkran.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekmi = false;
            }

            if (lblEkran.Text == "0" || lblEkran.Text == Convert.ToString(_sonuc)) lblEkran.Text = "";
            lblEkran.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekmi = false;
            }

            if (lblEkran.Text == "0" || lblEkran.Text == Convert.ToString(_sonuc)) lblEkran.Text = "";
            lblEkran.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekmi = false;
            }

            if (lblEkran.Text == "0" || lblEkran.Text == Convert.ToString(_sonuc)) lblEkran.Text = "";
            lblEkran.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekmi)
            {
                lblEkran.Text = "";
                _ekranTemizlenecekmi = false;
            }

            if (lblEkran.Text == "0" || lblEkran.Text == Convert.ToString(_sonuc)) lblEkran.Text = "";
            lblEkran.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(lblEkran.Text);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekranTemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(lblEkran.Text);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(lblEkran.Text);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekranTemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(lblEkran.Text);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            lblEkran.Text = "";

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            _ikincisayi = Convert.ToInt32(lblEkran.Text);
            switch (_islem)
            {
                case '+':
                    _sonuc = _ilksayi + _ikincisayi;
                    break;

                case '-':
                    _sonuc = _ilksayi - _ikincisayi;
                    break;

                case '*':
                    _sonuc = _ilksayi * _ikincisayi;
                    break;

                case '/':
                    _sonuc = _ilksayi / _ikincisayi;
                    break;
                 
                default:
                    _sonuc = 0;
                    break;
            }
            lblEkran.Text = Convert.ToString(_sonuc);

        }

        
    }
}
