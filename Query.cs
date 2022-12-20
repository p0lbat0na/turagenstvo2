using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace turagenstvo2
{
    public partial class Query : Form
    {
        public static string[] atr = new string[4];
        public Query(string naznach,bool txtbox1 = true, bool txtbox2 = true, bool txtbox3=true,bool txtbox4 = true, bool cmbbox1 = true)
        {
            InitializeComponent();
            if (naznach== "poisk")
            {
                txtbox1 = false;
                txtbox2 = false;
                txtbox3 = false;
            }
            if (naznach == "query")
            {
                txtbox4 = false;
                cmbbox1 = false;
                label4.Hide();
                label5.Hide();
                label1.Text = "Фамилия";
                label2.Text = "Имя";
                label3.Text = "Отчество";
            }
            if (txtbox1 == false) textBox1.Hide();
            if (txtbox2 == false) textBox2.Hide();
            if (txtbox3 == false) textBox3.Hide();
            if (txtbox4 == false) textBox4.Hide();
            if (cmbbox1 == false) comboBox1.Hide();
            
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turagenstvoDataSet.poezdkii". При необходимости она может быть перемещена или удалена.
            this.poezdkiiTableAdapter.Fill(this.turagenstvoDataSet.poezdkii);

        }
    }
}
