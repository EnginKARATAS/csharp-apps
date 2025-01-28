using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_12_2020
{
    public partial class Form1 : Form
    {
        KitapVT _kitapVT;
        public Form1()
        {
            InitializeComponent();
            _kitapVT = new KitapVT();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {

            ListeGuncelle();

        }

        private void ListeGuncelle()
        {
            DataTable dt = new DataTable();
            dt.Rows.Add(_kitapVT.DatagridGuncelle());
            dataGridView1.DataSource = dt;



        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kitap kt = new Kitap();
            kt.AD = txtKitapAd.Text;
            kt.Yazar = txtKitapYazar.Text;

            _kitapVT.KitapEkle(kt);
            _kitapVT.DatagridGuncelle();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            int a = Convert.ToInt32(selectedRow.Cells["id"].Value);

            Kitap kt = new Kitap();
            kt.Id = a;
            _kitapVT.BookDelete(kt);
            ListeGuncelle();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Kitap kt = new Kitap();
            kt.AD = txtUpdateKitapAd.Text.ToString();
            kt.Yazar = txtUpdateYazar.Text.ToString();
            kt.Id = int.Parse(txtUpdateId.Text);
            _kitapVT.BookUpdate(kt);

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            txtUpdateId.Text = (selectedRow.Cells["id"].Value).ToString() ;
            txtUpdateKitapAd.Text = (selectedRow.Cells["AD"].Value).ToString() ;
            txtUpdateYazar.Text = (selectedRow.Cells["Yazar"].Value).ToString() ;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).Rows.Clear();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
