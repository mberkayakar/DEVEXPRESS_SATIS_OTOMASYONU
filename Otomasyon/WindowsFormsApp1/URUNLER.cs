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


namespace WindowsFormsApp1
{
    public partial class URUNLER : Form
    {
        public URUNLER()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            try
            {
       

                SqlCommand komut = new SqlCommand("İnsert into Urunler (URUNAD, MARKA, URUNACIKLAMA) values (@p1,@p2,@p3)", baglan.sqlbaglantisi());
                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                komut.Parameters.AddWithValue("@p2", textBox2.Text);
                komut.Parameters.AddWithValue("@p3", textBox3.Text);
                /*      komut.Parameters.AddWithValue("@p4", ritchtxtAciklama.Text);
                      komut.Parameters.AddWithValue("@p5", Convert.ToInt32(txtkategori.Text));
                      komut.Parameters.AddWithValue("@p6", Convert.ToInt32(txtdurum.Text));
                      komut.Parameters.AddWithValue("@p7", Convert.ToInt32(txtdurum.Text)); */
                komut.ExecuteNonQuery();
                baglan.sqlbaglantisi().Close();
                MessageBox.Show("Ürün eklemesi Başarı ile gerçekleşti");
                listele();

            }
            catch (Exception)
            {
                MessageBox.Show("patladı geçmiş olsun");
               
            }
        }

        BAGLANTİ baglan = new BAGLANTİ();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Urunler",baglan.sqlbaglantisi());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

      


        private void URUNLER_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void ritchtxtAciklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            try
            {


                SqlCommand komut = new SqlCommand("delete from Urunler where ID= @p1", baglan.sqlbaglantisi());
                komut.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox1.Text));
                komut.ExecuteNonQuery();
                baglan.sqlbaglantisi().Close();
                MessageBox.Show("Ürün silindi");
                listele();

            }
            catch (Exception)
            {
                MessageBox.Show("patladı geçmiş olsun");

            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            textBox1.Text = dr["URUNAD"].ToString();
        }
    }
}
