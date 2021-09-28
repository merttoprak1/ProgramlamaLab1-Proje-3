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
    public partial class kullaniciekran : Form
    {
        public kullaniciekran()
        {
            InitializeComponent();
        }
        static string constring = ("Data Source=DESKTOP-DB66H3B;Initial Catalog=Kayit;Integrated Security=True");
        SqlConnection baglan = new SqlConnection(constring);


        public void kayitları_getir()
        {

            string getir = "Select * From Sarkilar";
            SqlCommand komut = new SqlCommand(getir, baglan);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;

            baglan.Close();
        }

        

        private void kullaniciekran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kayitDataSet1.Sarkilar' table. You can move, or remove it, as needed.
            this.sarkilarTableAdapter.Fill(this.kayitDataSet1.Sarkilar);
            kayitları_getir();
        }
    }
}
