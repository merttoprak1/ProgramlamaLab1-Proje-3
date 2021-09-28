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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string constring = ("Data Source=DESKTOP-DB66H3B;Initial Catalog=Kayit;Integrated Security=True");
        SqlConnection baglan = new SqlConnection(constring);


        public void kayitları_getir()
        {
           
            string getir = "Select * From Uyeler";
            SqlCommand komut = new SqlCommand(getir, baglan);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kayitları_getir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string kayit = "insert into Uyeler (ad_soyad, kullanici_adi, sifre, email, uyelik_tur, ulke) values(@ad_soyad, @kullanici_adi, @sifre, @email, @uyelik_tur, @ulke)";
                    SqlCommand komut = new SqlCommand(kayit, baglan);
                    komut.Parameters.AddWithValue("@ad_soyad", textBox1.Text);
                    komut.Parameters.AddWithValue("@kullanici_adi", textBox2.Text);
                    komut.Parameters.AddWithValue("@sifre", textBox3.Text);
                    komut.Parameters.AddWithValue("@email", textBox4.Text);
                    komut.Parameters.AddWithValue("@uyelik_tur", textBox5.Text);
                    komut.Parameters.AddWithValue("@ulke", textBox6.Text);


                    komut.ExecuteNonQuery();

                    MessageBox.Show("Kayıt eklenmiştir.");
                }
            }
            catch(Exception hata)
            {
                MessageBox.Show("Bir hata oluştu."+ hata.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
