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
    public partial class Hall : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        public Hall()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
            sda = new SqlDataAdapter("SELECT * FROM [Hall]", con);
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

        private void поАлфавитуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Hall ORDER BY Area ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void обратноАлфавитуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Hall ORDER BY Area DESC ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void поВозрастаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Hall ORDER BY floor ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void поУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Hall ORDER BY floor DESC ", con);
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

        private void официантToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Waiter ss = new Waiter();
            ss.Show();
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main ss = new Main();
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

        private void столToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Table ss = new Table();
            ss.Show();
        }
    }
}
