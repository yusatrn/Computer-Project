﻿using System;
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
            con = new OracleConnection(baglanti.adres);
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
    }
}
