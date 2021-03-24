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

    public partial class MusterıKayıt : Form
    {
        OracleConnection con = new OracleConnection( "Data Source=XE;User ID = COMPUTER;Password=h1597531");
        public MusterıKayıt()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void müşteriKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String ad = textBox1.Text;
                String soyad = textBox2.Text;
                String tc = textBox3.Text.ToString();
                String adres = textBox4.Text;
                String telefon = textBox5.Text.ToString();
                String maıl = textBox6.Text;
                
                 
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                


                cmd.CommandText = "Insert into MUSTER(AD,SOYAD,TC,ADRES,TELEFON,MAIL) VALUES('"+ textBox1.Text + "','" + soyad + "','" + tc + "','" + textBox4.Text +"','"+telefon+"','"+maıl+ "')";


                int rowsUpdated = cmd.ExecuteNonQuery();
                if (rowsUpdated == 0)
                {
                    MessageBox.Show("Record not inserted");
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Success!");
                    temizle();
                    listeleme();
                }
  


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void listeleme()
        {
            con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from MUSTER";
            OracleDataAdapter data = new OracleDataAdapter(cmd.CommandText, con);
            DataSet ds = new DataSet();
            data.Fill(ds, "Müsteriler");
            con.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Müsteriler";
        }
        private void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
        private void MusterıKayıt_Load(object sender, EventArgs e)
        {

            listeleme();
            button2.Visible = false;
            button3.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int guncel = 0;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           label8.Text =dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            guncel = 0;
            button2.Visible = true;
            button3.Visible = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (guncel==0)
            {
                try
                {
                    String ad = textBox1.Text;
                    String soyad = textBox2.Text;
                    String tc = textBox3.Text.ToString();
                    String adres = textBox4.Text;
                    String telefon = textBox5.Text.ToString();
                    String maıl = textBox6.Text;


                    con.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = con;



                    cmd.CommandText = "Update MUSTER set AD='" + textBox1.Text + "',SOYAD='" + soyad + "',TC='" + tc + "',ADRES='" + textBox4.Text + "',TELEFON='" + telefon + "',MAIL='" + maıl + "'where ID=" + label8.Text.ToString() + "";


                    int rowsUpdated = cmd.ExecuteNonQuery();
                    if (rowsUpdated == 0)
                    {
                        MessageBox.Show("Record not inserted");
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show("Success!");
                        temizle();
                        listeleme();
                        button2.Visible = false;
                        button3.Visible = false;
                    }
                    con.Dispose();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String ad = textBox1.Text;
                String soyad = textBox2.Text;
                String tc = textBox3.Text.ToString();
                String adres = textBox4.Text;
                String telefon = textBox5.Text.ToString();
                String maıl = textBox6.Text;


                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;



                cmd.CommandText = "delete from MUSTER where ID='" + label8.Text.ToString() +"'" +"";


                int rowsUpdated = cmd.ExecuteNonQuery();
                if (rowsUpdated == 0)
                {
                    MessageBox.Show("Record not inserted");
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Success!");
                    temizle();
                    listeleme();
                    button2.Visible = false;
                    button3.Visible = false;
                }
                con.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
     
        }
    }
}
