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
    }
}
