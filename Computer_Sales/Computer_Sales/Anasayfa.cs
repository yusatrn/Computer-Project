using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace Computer_Sales
{
    public partial class Anasayfa : Form
    {
        OracleConnection con;
        Connect baglanti = new Connect();
        public Anasayfa()
        {
           // con = new OracleConnection(baglanti.adres);
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            /* 
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select ad from deneme where id=1";
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                label1.Text = dr.GetString(0);

                con.Close();
                con.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }*/
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ürünSatışıToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void teknikServisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void müşteriKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personelKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void satılanÜrünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void servisteOlanÜrünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form satis = new Bilgisayar_Satis();
            satis.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form kayit = new Bilgisayar_Kayit();
            kayit.ShowDialog();
        }

        private void bilgisayarSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form satis = new Bilgisayar_Satis();
            satis.ShowDialog();

        }

        private void bilgisayarKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kayit = new Bilgisayar_Kayit();
            kayit.ShowDialog();
        }
    }
}
