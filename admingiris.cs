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

namespace prolabodev
{
    public partial class admingiris : Form
    {
        public admingiris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DB66H3B;Initial Catalog=Kayit;Integrated Security=True");
            string query = "Select * from adminler where kullaniciad ='" + textBox1.Text.Trim() + "' and sifre = '" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            if (dt.Rows.Count == 1)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }

            else
            {
                MessageBox.Show("Username/Password is incorrect. Please try again!");

            }
        }
    }
}
