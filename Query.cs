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
        public Query(string naznach,string poisk="",bool txtbox1 = true, bool txtbox2 = true, bool txtbox3=true,bool txtbox4 = true, bool cmbbox1 = true)
        {
            atr[1] = poisk;
            
            InitializeComponent();
            if (naznach== "poisk")
            {
                txtbox1 = false;
                txtbox2 = false;
                txtbox3 = false;
                label4.Text = "Параметр";
                label5.Text = "Значение";
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
            if(poisk=="turist")
            {
                atr[2] = "7";
            }
            if (poisk == "poezdkii")
            {
                atr[2] = "9";
            }
            if (poisk == "putevki")
            {
                atr[2] = "8";
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turagenstvoDataSet.turist". При необходимости она может быть перемещена или удалена.
            this.turistTableAdapter.Fill(this.turagenstvoDataSet.turist);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "turagenstvoDataSet.poezdkii". При необходимости она может быть перемещена или удалена.
            this.poezdkiiTableAdapter.Fill(this.turagenstvoDataSet.poezdkii);

        }
        private void Poisk(string p, string z)

        {





            string connectionString = "Data Source=311-UCH\\MSSQLSERVER1;Initial Catalog=turagenstvo;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string[] f = new string[10];
            try
            {

                string query = $"SELECT * FROM {atr[1]} WHERE {p}='{z}'";

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < Convert.ToInt32(atr[2]); i++)
                    {
                        f[i] = reader[i].ToString();
                    }
                }

                //Form2 £2
                //¥2.show()5
                //this.Close()s
                //
                //
                //
                //ew Form2(Fl@], F[2], F121, F131)
                
            }
            catch { } finally { connection.Close(); }
            }
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
