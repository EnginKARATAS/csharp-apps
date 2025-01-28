using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week9StoredProceduresAndFunctionsAppInForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conSrt = String.Format("Server={0};Database={1};Uid={2};Pwd={3}", @"(localdb)\mssqllocaldb", "Test", "", "");
            SqlConnection sqlCon = new SqlConnection(conSrt); //Bağlantımızı oluşturduk.
            SqlCommand cmd = new SqlCommand("Musteriler", sqlCon); //Hangi Procedure yi kullanıcagımızı belirtiyoruz. Musteriler bizim S.P adımızdı

            cmd.CommandType = CommandType.StoredProcedure; //Komut tipimizde StoredProcedure kullanacagımızı belirtiyoruz.
            cmd.Parameters.Add("@ID", SqlDbType.Int); //Parametrelerimizi ekliyoruz
            cmd.Parameters.Add("@ADI", SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@SOYADI", SqlDbType.VarChar, 50);
            cmd.Parameters["@ID"].Value = Convert.ToInt32(txtBoxId.Text); // Arama yapacagımız ID noyu içeri yolluyoruz. Procedurede tipimiz int oldugu için int tipine Convert etmemiz gerekiyor.
            cmd.Parameters["@ADI"].Direction = ParameterDirection.Output; //Parametremizin akış yönünü belirtir.Hatırlasınız bu iki parametreyi output parametre verdiğimişdik
            cmd.Parameters["@SOYADI"].Direction = ParameterDirection.Output;
            sqlCon.Open(); // Tüm hazırlıklar tamam olduguna göre artıkbağlantımızı açalım
            cmd.ExecuteNonQuery(); // komutu çalıştırdık
            textBox2.Text = cmd.Parameters["@ADI"].Value.ToString(); //Sonuçları textBoxlara atalımtextBox3.Text = cmd.Parameters["@SOYADI"].Value.ToString(); // Sonuçlar object tipinde geldiği için ToString() metodunu kullanarak string e çevirmeniz gerekir.
            textBox3.Text = cmd.Parameters["@SOYADI"].Value.ToString(); //Sonuçları textBoxlara atalımtextBox3.Text = cmd.Parameters["@SOYADI"].Value.ToString(); // Sonuçlar object tipinde geldiği için ToString() metodunu kullanarak string e çevirmeniz gerekir.

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conSrt = String.Format("Server={0};Database={1};Uid={2};Pwd={3}", @"(localdb)\mssqllocaldb", "Test", "", "");
            SqlConnection conn = new SqlConnection(conSrt);
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Func_MusteriGetir(@adi)", conn);
            // cmd.CommandType=CommandType.StoredProcedure;  
            cmd.Parameters.Add("@adi", SqlDbType.VarChar,20);
            cmd.Parameters["@adi"].Value = textBox1.Text.ToString();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Width = 45;
            dataGridView2.Columns[2].Width = 45;
            dataGridView2.Columns[3].Width = 45;

        }
    }
}
