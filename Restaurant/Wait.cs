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
    public partial class Order : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        public Order()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
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
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
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

        private void заказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order ss = new Order();
            ss.Show();
        }
    }
}
