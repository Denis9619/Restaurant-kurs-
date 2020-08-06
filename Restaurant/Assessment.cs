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
    public partial class Assessment : Form
    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;

        public Assessment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
            sda = new SqlDataAdapter("SELECT * FROM Assessment", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
        }

        private void поВозрастаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Assessment ORDER BY Assessment ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void поУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Restaurant2;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Assessment ORDER BY Assessment DESC ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main ss = new Main();
            ss.Show();
        }

        private void залToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hall ss = new Hall();
            ss.Show();
        }

        private void столToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Table ss = new Table();
            ss.Show();
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

        private void блюдоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dish ss = new Dish();
            ss.Show();
        }
    }
}
