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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void поОтеллюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void LoadData(string st, int k, List<string> colName, string atr1 = "", string atr2 = "", string atr3 = "")
        {
            string connectionString = "Data Source=311-UCH\\MSSQLSERVER1;Initial Catalog=turagenstvo;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = st;
            SqlCommand command = new SqlCommand(query, connection);
            if (!String.IsNullOrEmpty(atr1))
            {
                command.Parameters.Add("@atr1", atr1);
                command.Parameters.Add("@atr2", atr2);
                command.Parameters.Add("@atr3", atr3);
            }

            SqlDataReader reader = command.ExecuteReader();
            List<string[]> list = new List<string[]>();
            while (reader.Read())
            {
                list.Add(new string[k]);
                for (int i = 0; i < k; i++)
                {
                    dataGridView1.ColumnCount = k;
                    list[list.Count - 1][i] = reader[i].ToString();
                    dataGridView1.Columns[i].HeaderText = colName[i];
                }
            }
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = k;


            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;

            reader.Close();
            connection.Close();
            foreach (string[] s in list)
                dataGridView1.Rows.Add(s);
        }

        //tables
        
        
        public void creation()
        {
            
            
            
        }
        
    private void putevki()
        {
            Table tputevki = new Table();
            tputevki.K = 8;
            tputevki.ColName = new List<string>() { "Номер", "Страна", "Город", "Место проживания", "Стоимость", "Страховка", "Доп.информация", "Длительность" };
            string st = "Select * from putevki";
            int k = tputevki.K;
            List <string> colName =tputevki.ColName;
            LoadData(st,k, colName);
            
        }

        private void poezdki()
        {
            Table tpoezdki = new Table();
            tpoezdki.K = 9;
            tpoezdki.ColName = new List<string>() { "ID", "Номер путевки", "Пасспортные данные", "Дата", "Дата возвращения", "Статус","Статус оплаты", "Доп.информация", "Стоимость" };
            string st = "Select * from poezdkii";
            int k = tpoezdki.K;
            List<string> colName = tpoezdki.ColName;
            LoadData(st, k, colName);
        }
        private void turisti()
        {
            Table tturisti = new Table();
            tturisti.K = 7;
            tturisti.ColName = new List<string>() { "Фамилия", "Имя", "Отчество", "Пасспортные данные", "Почта", "Телефон", "Место работы" };
            string st = "USE[turagenstvo] SELECT* FROM[dbo].[turist]" ;
            List<string> colName = tturisti.ColName;
            int k = tturisti.K;
            LoadData(st, k, colName);
        }

        //querys
        private void q1()
        {
            string st = "Select num_putevki,familiya, imya, otchestvo, data from poezdkii, turist WHERE data BETWEEN '2022-01-01' AND '2022-12-31' AND num_putevki='7'";
            int k = 5;
            List<string> colName =  new List<string>() { "Номер", "Фамилия","Имя","Отчество" ,"Дата" };
            LoadData(st, k, colName);
        }
        private void q2()
        {
            string st = "Select gorod, mesto_projivaniya, stoimost from putevki WHERE mesto_projivaniya='turistichesliy lager'";
            int k = 3;
            List<string> colName =  new List<string>() { "Город", "Место проживания", "Стоимость" };
            LoadData(st, k, colName);
        }
        private void q3()
        {
            string st = "Select strana, num from putevki WHERE strana='Egypt'";
            int k = 2;
            List<string> colName =  new List<string>() { "Страна", "Номер" };
            LoadData(st, k, colName);
        }
        private void q4()
        {
            Query f2 = new Query("query");
            f2.ShowDialog();

            string lastName = Query.atr[1];
            string firstName = Query.atr[2];
            string patronymic = Query.atr[3];
            
            if (!String.IsNullOrEmpty(lastName))
            {

                //string st = $"SELECT turist.familiya,turist.imya,turist.otchestvo, putevki.mesto_projivaniya  FROM poezdkii JOIN putevki  ON putevki.num = poezdkii.num_putevki JOIN turist ON poezdkii.pasp_turista = turist.passp_dannye WHERE familiya = {atr1} AND imya = {atr2} AND otchestvo = {atr3}";
                string st = $"SELECT turist.familiya,turist.imya,turist.otchestvo, putevki.mesto_projivaniya, poezdkii.data  FROM poezdkii JOIN putevki  ON putevki.num = poezdkii.num_putevki JOIN turist ON poezdkii.pasp_turista = turist.passp_dannye WHERE familiya = @atr1 AND imya = @atr2 AND otchestvo = @atr3";
                    int k = 5;
                List<string> colName =  new List<string>() { "Фамилия", "Имя", "Отчество", "Место Проживания", "Дата" };
                    LoadData(st, k, colName,lastName,firstName,patronymic);
            }
            //MessageBox.Show("idjfiosdgio");
        }
        //private void q4()
        //{
        //    string st = "Select strana, num from putevki WHERE strana='Egypt'";
        //    int k = 2;
        //    string[] colName = { "Страна", "Номер" };
        //    LoadData(st, k, colName);
        //}



        private void туристыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turisti();
        }

        private void пездкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            poezdki();
        }

        private void путевкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            putevki();
        }

        private void стоимостьПутевкиВТуристическийЛагерьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            q2();
        }

        private void естьЛиПутевкиВЕгипетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            q3();
        }

        private void сколькоТуристовПосетилоАнглиюВТекущемГодуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            q1();
        }

        private void вКакомОтелеОстановилсяТуристToolStripMenuItem_Click(object sender, EventArgs e)
        {
            q4();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void данныеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void просмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void туристыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Anket f3 = new Anket("turisti");
            f3.Show();
        }
        public class Table
        {
            public List<string> ColName { get; set; }
            public int K { get; set; }
            //public Table(List<string[]> colName, int k)
            //{
            //    K = k;
            //    ColName = colName;
            //}

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void поездкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anket f3 = new Anket("poezdki");
            f3.Show();
        }

        private void путевкиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Anket f3 = new Anket("putevki");
            f3.Show();
        }

        private void поСтранеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query f2 = new Query("poisk", "putevki");
            f2.Show();
        }

        private void поСтоимостиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
} 
