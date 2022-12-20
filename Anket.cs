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
    public partial class Anket : Form
    {
        string tablename;
        int colCount;
        string znacheniye;
        public Anket(string table, int count = 0, string znach = "")
        {
            colCount = count;
            tablename = table;
            znacheniye = znach;
            InitializeComponent();
            if (table == "turisti")
            {
                label1.Text = "Фамилия";
                label2.Text = "Имя";
                label3.Text = "Отчество";
                label4.Text = "Пасспортные данные";
                label5.Text = "Почта";
                label6.Text = "Телефон";
                label7.Text = "Место работы";
                label8.Hide();
                label9.Hide();
                textBox8.Hide();
                textBox9.Hide();
            }
            if (table == "putevki")
            {
                label1.Text = "Номер";
                label2.Text = "Страна";
                label3.Text = "Город";
                label4.Text = "Место проживания";
                label5.Text = "Стоимость";
                label6.Text = "Страховка";
                label7.Text = "Доп.информация";
                label8.Text = "Длительность";
                label9.Hide();
                textBox9.Hide();
            }
            if (table == "poezdki")
            {
                label1.Text = "ID";
                label2.Text = "Номер путевки";
                label3.Text = "Пасспортные данные";
                label4.Text = "Дата";
                label5.Text = "Дата возвращения";
                label6.Text = "Статус";
                label7.Text = "Статус оплаты";
                label8.Text = "Доп.информация";
                label9.Text = "Стоимость";
            }
            if (count != 0)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string atribut1 = textBox1.Text;
            string atribut2 = textBox2.Text;
            string atribut3 = textBox3.Text;
            string atribut4 = textBox4.Text;
            string atribut5 = textBox5.Text;
            string atribut6 = textBox6.Text;
            string atribut7 = textBox7.Text;
            string atribut8 = textBox8.Text;
            string atribut9 = textBox9.Text;

            string connectionString = "Data Source=311-UCH\\MSSQLSERVER1;Initial Catalog=turagenstvo;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "kasjl";
            try
            {
            if (tablename == "poezdki")
            {
                query = $"INSERT INTO poezdkii (id,num_putevki,pasp_turista,data,data_vozvrasheniya,status,status_oplati,dop_infa,stoimost)VALUES(@atribut1, @atribut2,@atribut3,@atribut4,@atribut5,@atribut6,@atribut7,@atribut8)";
            }
            if (tablename == "turisti")
            {
                query = $"INSERT INTO turist (familiya,imya,otchestvo,passp_dannye,e_mail,telefon,mesto_raboti)VALUES(@atribut1, @atribut2,@atribut3,@atribut4,@atribut5,@atribut6,@atribut7)";
            }
            if (tablename == "putevki")
            {
                query = $"INSERT INTO putevki (num,strana,gorod,mesto_projivaniya,stoimost,strahovka,dop_infa,dlitelnost)VALUES(@atribut1, @atribut2,@atribut3,@atribut4,@atribut5,@atribut6,@atribut7,@atribut8)";
            }

            SqlCommand command = new SqlCommand(query, connection);

            if (!String.IsNullOrEmpty(atribut1))
            {
                command.Parameters.Add("@atribut1", atribut1);
                command.Parameters.Add("@atribut2", atribut2);
                command.Parameters.Add("@atribut3", atribut3);
                command.Parameters.Add("@atribut4", atribut4);
                command.Parameters.Add("@atribut5", atribut5);
                command.Parameters.Add("@atribut6", atribut6);
                command.Parameters.Add("@atribut7", atribut7);
                command.Parameters.Add("@atribut8", atribut8);
                command.Parameters.Add("@atribut9", atribut9);
            }

            command.ExecuteNonQuery();
            MessageBox.Show("Данные сохранены");
            }
            catch
            {
            
                DialogResult result = MessageBox.Show(
                "Такая запись уже существует. Перезаписать данные?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.None,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            
                if (result == DialogResult.Yes)
            
                {
            
            
                    if (tablename == "poezdki")
                    {
                        query = $"UPDATE poezdkii SET num_putevki=@atribut2,pasp_turista=@atribut3,data=@atribut4,data_vozvrasheniya=@atribut5,status=@atribut6,status_oplati=@atribut7,dop_infa=@atribut8,stoimost=@atribut9 WHERE id=@atribut1";
                    }
                    if (tablename == "turisti")
                    {
                        query = $"UPDATE turist SET familiya=@atribut1,imya=@atribut2,otchestvo=@atribut3,e_mail=@atribut5,telefon=@atribut6,mesto_raboti=@atribut7 WHERE passp_dannye=@atribut4";
                    }
                    if (tablename == "putevki")
                    {
                        query = $"UPDATE putevki SET strana=@atribut2,gorod=@atribut3,mesto_projivaniya=@atribut4,stoimost=@atribut5,strahovka=@atribut6,dop_infa=@atribut7,dlitelnost=@atribut8 WHERE num=@atribut1";
                    }
            
            
                    SqlCommand command = new SqlCommand(query, connection);

                    if (!String.IsNullOrEmpty(atribut1))
                    {
                        command.Parameters.Add("@atribut1", atribut1);
                        command.Parameters.Add("@atribut2", atribut2);
                        command.Parameters.Add("@atribut3", atribut3);
                        command.Parameters.Add("@atribut4", atribut4);
                        command.Parameters.Add("@atribut5", atribut5);
                        command.Parameters.Add("@atribut6", atribut6);
                        command.Parameters.Add("@atribut7", atribut7);
                        command.Parameters.Add("@atribut8", atribut8);
                        command.Parameters.Add("@atribut9", atribut9);
                    }

                    command.ExecuteNonQuery();
                    MessageBox.Show("Данные изменены");
                        }
            } 
        }
    }
}
