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

namespace Restaurant
{
    public partial class Waiter : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        public Waiter()
        {
            InitializeComponent();
        }

        private void поАлфавитуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Waiter ORDER BY Name ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void обратноАлфавитуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Waiter ORDER BY Name DESC ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
            sda = new SqlDataAdapter("SELECT * FROM [Waiter]", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                scb = new SqlCommandBuilder(sda);
                sda.Update(dt);
            }
            catch
            {
                MessageBox.Show("Ошибка заполнения данных");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Name")
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Waiter WHERE Name LIKE '" + textBox1.Text + "% ' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "Surname")
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Waiter WHERE Salary LIKE '" + textBox1.Text + "% ' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "TelephoneNumber")
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Waiter WHERE TelephoneNumber LIKE '" + textBox1.Text + "% ' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "ID")
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Waiter WHERE WaiterID LIKE '" + textBox1.Text + "% ' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void поАлфавитуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Waiter ORDER BY Surname ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void обратноАлфавитуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Waiter ORDER BY Surname DESC ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void поАлфавитуToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Waiter ORDER BY Adress ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void обратноАлфавитуToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Waiter ORDER BY Adress DESC ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void поАлфавитуToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Waiter ORDER BY Email ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void обратноАлфавитуToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Waiter ORDER BY Email DESC ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void поВозрастаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Waiter ORDER BY Salary ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void поУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Waiter ORDER BY Salary DESC ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void заказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order ss = new Order();
            ss.Show();
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main ss = new Main();
            ss.Show();
        }

        private void столToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Table ss = new Table();
            ss.Show();
        }

        private void залToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hall ss = new Hall();
            ss.Show();
        }

        private void блюдоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dish ss = new Dish();
            ss.Show();
        }

        private void оценкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Assessment ss = new Assessment();
            ss.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.Text == "Официант + Заказ")
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT Waiter.Name,Waiter.Surname,Waiter.Salary,[Order].OrderCost,[Order].OrderTime FROM [Order] INNER JOIN Waiter ON [Order].WaiterID = Waiter.WaiterID", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView2.DataSource = dt;
                }
                else if (comboBox2.Text == "Официант + Заказ + Стол")
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT Waiter.Name,Waiter.Surname,Waiter.Salary,[Order].OrderCost,[Order].OrderTime,[Table].PersonsQuantity FROM [Order] INNER JOIN Waiter ON [Order].WaiterID = Waiter.WaiterID INNER JOIN [Table] ON [Order].TableNumber = [Table].TableNumber ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView2.DataSource = dt;
                }


                else if (comboBox2.Text == "Официант + Заказ(Cвой вариант)")
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT   " + textBox2.Text + " FROM [Order] INNER JOIN Waiter ON [Order].WaiterID = Waiter.WaiterID  ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView2.DataSource = dt;
                }
                else if (comboBox2.Text == "Официант + Заказ + Стол(Cвой вариант)")
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT   " + textBox2.Text + " FROM [Order] INNER JOIN Waiter ON [Order].WaiterID = Waiter.WaiterID INNER JOIN [Table] ON [Order].TableNumber = [Table].TableNumber ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView2.DataSource = dt;
                                        
                }
            }
            catch
            {
                label1.Visible = true;
            }
        }

        private void результирующаяТаблицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        /*SELECT Waiter.Name,Waiter.Surname,Waiter.Salary,[Order].OrderCost,[Order].OrderTime,[Table].PersonsQuantity FROM [Order]
	        INNER JOIN Waiter ON [Order].WaiterID = Waiter.WaiterID
		        INNER JOIN [Table] ON [Order].TableNumber = [Table].TableNumber */

        private void button4_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
            con.Open();
           
            SqlCommand sc = new SqlCommand("SELECT SUM(OrderCost) From [Order] where WaiterID =  " + textBox3.Text + "  ", con);
            SqlDataReader read = sc.ExecuteReader();
           
            while(read.Read())
            {
                textBox4.Text += read["SUM"].ToString();
            }
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("Select Waiter.WaiterID,[Order].OrderCost,[Order].Assesment, Waiter.Salary FROM [Order] INNER JOIN Waiter ON [Order].WaiterID = Waiter.WaiterID where Waiter.WaiterID = " + textBox3.Text + "  ", con);
                //sda = new SqlDataAdapter("SELECT * FROM [Waiter] where WaiterID = "+ a + "", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch { MessageBox.Show("Произошла ошибка выполнения операции"); }
        }

        private void Waiter_Load(object sender, EventArgs e)
        {

        }
        
    }
}
