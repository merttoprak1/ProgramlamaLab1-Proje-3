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
    public partial class kullanıcıGiris : Form
    {
        public kullanıcıGiris()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DB66H3B;Initial Catalog=Kayit;Integrated Security=True");
            string query = "Select * from Uyeler where kullanici_adi ='" + textBox1.Text.Trim() + "' and sifre = '" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            if (dt.Rows.Count == 1)
            {
                this.Hide();
                kullaniciekran kullaniciekran = new kullaniciekran();
                kullaniciekran.Show();
            }

            else
            {
                MessageBox.Show("Username/Password is incorrect. Please try again!");

            }
        }
    }
}
