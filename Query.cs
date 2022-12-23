using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace turagenstvo2
{
    public partial class Query : Form
    {
        public static string[] atr = new string[4];
        public Query(string naznach,string poisk="")
        {
            atr[1] = poisk;
            
            InitializeComponent();
            if (naznach== "poisk")
            {
                textBox1.Hide();
                textBox2.Hide();
                textBox3.Hide();
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Text = "Параметр";
                label5.Text = "Значение";
                button1.Hide();
            }
            if (naznach == "query4")
            {
                comboBox1.Hide();
                comboBox2.Hide();
                comboBox3.Hide();
                textBox4.Hide();
                label4.Hide();
                label5.Hide();
                label1.Text = "Фамилия";
                label2.Text = "Имя";
                label3.Text = "Отчество";
                button2.Hide();
            }
            if (naznach == "query3")
            {
                comboBox1.Hide();
                comboBox2.Hide();
                comboBox3.Hide();
                textBox4.Hide();
                label4.Hide();
                label5.Hide();
                textBox3.Hide();
                textBox2.Hide();
                label2.Hide();
                label3.Hide();
                label1.Text = "Страна";                
                button2.Hide();
            }
            if (poisk=="turist")
            {
                comboBox1.Hide();
                comboBox3.Hide();
                atr[2] = "7";
                atr[3] = "comboBox2.Text";
            }
            if (poisk == "poezdkii")
            {
                comboBox2.Hide();
                comboBox3.Hide();
                atr[3] = "comboBox1.Text";
                atr[2] = "9";
            }
            if (poisk == "putevki")
            {
                atr[3] = "comboBox3.Text";
                atr[2] = "8";
                comboBox1.Hide();
                comboBox2.Hide();
            }
            
            
            //string atr0, string atr1, string atr2, string atr3
            //atr[0] = atr0;
            //atr[1] = atr1;
            //atr[2] = atr2;
            //atr[3] = atr3;
        }

        private void Query_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            //Form1 form1 = new Form1();
            //form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            atr[1] = textBox1.Text;
            atr[2] = textBox2.Text;
            atr[3] = textBox3.Text;
            //On
            //Query.Close(atr[1], atr[2], atr[3]);
            this.DialogResult = DialogResult.OK;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Query_Load(object sender, EventArgs e)
        {
       
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            Anket f3 = new Anket(atr[1]);
            f3.Show();
            this.Hide();
            string pole = comboBox1.Text + comboBox2.Text + comboBox3.Text;
            f3.poisk(atr[1], textBox4.Text, pole);
        }
    }
}
