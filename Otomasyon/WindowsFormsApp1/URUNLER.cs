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
       

                SqlCommand komut = new SqlCommand("insert into Urunler values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglan.sqlbaglantisi());
                komut.Parameters.AddWithValue("@p1", txt_Urun_Ad.Text);
                 komut.Parameters.AddWithValue("@p2", Txt_Marka.Text);
                komut.Parameters.AddWithValue("@p3", txt_Model.Text);
                komut.Parameters.AddWithValue("@p4", Richtxt_Aciklama.Text);
                komut.Parameters.AddWithValue("@p5", Convert.ToInt32(cmb_Kategori.SelectedItem));  //
                komut.Parameters.AddWithValue("@p6", Convert.ToInt32(numericUpDown1.Value));
                komut.Parameters.AddWithValue("@p7", Convert.ToBoolean(chck_Kritiklik_Durumu.Checked));
                komut.ExecuteNonQuery();
                baglan.sqlbaglantisi().Close();
                MessageBox.Show("Ürün eklemesi Başarı ile gerçekleşti");
                listele();

            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata ile karşılaşıldı Lütfen hata mesajını sistem yöneticilerine bildirin. ", hata.Message.ToString());
               
            }
        }

        BAGLANTİ baglan = new BAGLANTİ();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("sp_Tum_Urunleri_Listele", baglan.sqlbaglantisi());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

      


        private void URUNLER_Load(object sender, EventArgs e)
        {
            listele();
            txtID.Enabled = false;
            numericUpDown1.Maximum = decimal.MaxValue;
        }

        private void ritchtxtAciklama_TextChanged(object sender, EventArgs e)
        {

        }

        public bool urunsilme(int id)
        {
            try
            {
                SqlCommand komut = new SqlCommand("delete from Urunler where ID= @p1", baglan.sqlbaglantisi());
                komut.Parameters.AddWithValue("@p1", id);
                komut.ExecuteNonQuery();
                baglan.sqlbaglantisi().Close();
                MessageBox.Show("Ürün Silme İşlemi Başarılı");
                listele();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("patladı geçmiş olsun");
                return false;
            }

        }


        private void simpleButton2_Click(object sender, EventArgs e)
        {

           
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Enabled = true;
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txt_Urun_Ad.Text = dr["URUNAD"].ToString();
        }

        private void URUNLER_Click(object sender, EventArgs e)
        {
          
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            txtID.Enabled = true;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            urunsilme(Convert.ToInt32(txtID.Text));
            listele();

        }
    }
}
