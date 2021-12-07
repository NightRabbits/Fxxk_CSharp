using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpgardeWeapon
{
    public partial class Form1 : Form
    {
        int inchantScroll = 0;
        int inchantWeapon = 0;
        String myWeapon = "";
        int myATK = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//재시작 매서드
        {
            Application.Restart();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//콤보박스 텍스트 표시
        {
            textBox3.Text = comboBox1.SelectedItem.ToString();

        }

        private void button1_Click(object sender, EventArgs e)//강화 매서드
        {
            inchantScroll -= 1;
            Random rnd = new Random();
            int inchantPer = rnd.Next(1, 101);
            if (inchantPer < 51)
            {
                inchantWeapon += 1;
                myATK += 1;
                textBox4.Text = ("성공! "+inchantWeapon + "강");
            }
            else
            {
                textBox4.Text = ("실패... " + inchantWeapon + "강");
            }
        }
    }
   }

