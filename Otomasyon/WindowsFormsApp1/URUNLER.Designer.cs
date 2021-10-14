
namespace WindowsFormsApp1
{
    partial class URUNLER
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(URUNLER));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Urun_Ad = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Richtxt_Aciklama = new System.Windows.Forms.RichTextBox();
            this.chck_Kritiklik_Durumu = new DevExpress.XtraEditors.CheckEdit();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cmb_Kategori = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.Txt_Marka = new System.Windows.Forms.TextBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chck_Kritiklik_Durumu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Kategori.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(566, 426);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(11, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "İD";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 87);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Urun Adı";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 113);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Marka";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 139);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Model";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 248);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Açıklama";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(16, 165);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(40, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Kategori";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(15, 191);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(47, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Stok Adet";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(15, 217);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(31, 13);
            this.labelControl8.TabIndex = 14;
            this.labelControl8.Text = "Durum";
            this.labelControl8.Click += new System.EventHandler(this.labelControl8_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 457);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(135, 44);
            this.simpleButton1.TabIndex = 18;
            this.simpleButton1.Text = "Kaydet";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txt_Urun_Ad
            // 
            this.txt_Urun_Ad.Location = new System.Drawing.Point(84, 79);
            this.txt_Urun_Ad.Name = "txt_Urun_Ad";
            this.txt_Urun_Ad.Size = new System.Drawing.Size(165, 21);
            this.txt_Urun_Ad.TabIndex = 19;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Richtxt_Aciklama);
            this.groupControl1.Controls.Add(this.chck_Kritiklik_Durumu);
            this.groupControl1.Controls.Add(this.numericUpDown1);
            this.groupControl1.Controls.Add(this.cmb_Kategori);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.txt_Model);
            this.groupControl1.Controls.Add(this.Txt_Marka);
            this.groupControl1.Controls.Add(this.txt_Urun_Ad);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(617, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(264, 489);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // Richtxt_Aciklama
            // 
            this.Richtxt_Aciklama.Location = new System.Drawing.Point(15, 280);
            this.Richtxt_Aciklama.Name = "Richtxt_Aciklama";
            this.Richtxt_Aciklama.Size = new System.Drawing.Size(239, 204);
            this.Richtxt_Aciklama.TabIndex = 27;
            this.Richtxt_Aciklama.Text = "";
            // 
            // chck_Kritiklik_Durumu
            // 
            this.chck_Kritiklik_Durumu.Location = new System.Drawing.Point(84, 219);
            this.chck_Kritiklik_Durumu.Name = "chck_Kritiklik_Durumu";
            this.chck_Kritiklik_Durumu.Properties.Caption = "Kritik Seviyede Mi ?";
            this.chck_Kritiklik_Durumu.Size = new System.Drawing.Size(122, 20);
            this.chck_Kritiklik_Durumu.TabIndex = 26;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(84, 192);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(165, 21);
            this.numericUpDown1.TabIndex = 25;
            // 
            // cmb_Kategori
            // 
            this.cmb_Kategori.Location = new System.Drawing.Point(84, 165);
            this.cmb_Kategori.Name = "cmb_Kategori";
            this.cmb_Kategori.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Kategori.Size = new System.Drawing.Size(165, 20);
            this.cmb_Kategori.TabIndex = 24;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(84, 52);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(165, 21);
            this.txtID.TabIndex = 23;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(84, 139);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(165, 21);
            this.txt_Model.TabIndex = 21;
            // 
            // Txt_Marka
            // 
            this.Txt_Marka.Location = new System.Drawing.Point(84, 110);
            this.Txt_Marka.Name = "Txt_Marka";
            this.Txt_Marka.Size = new System.Drawing.Size(165, 21);
            this.Txt_Marka.TabIndex = 20;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(153, 457);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(135, 44);
            this.simpleButton2.TabIndex = 22;
            this.simpleButton2.Text = "Güncelle";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(294, 457);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(134, 44);
            this.simpleButton3.TabIndex = 23;
            this.simpleButton3.Text = "Sil";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(434, 457);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(135, 44);
            this.simpleButton4.TabIndex = 24;
            this.simpleButton4.Text = "Ara";
            // 
            // URUNLER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 513);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton2);
            this.Name = "URUNLER";
            this.Text = "URUNLER";
            this.Load += new System.EventHandler(this.URUNLER_Load);
            this.Click += new System.EventHandler(this.URUNLER_Click);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chck_Kritiklik_Durumu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Kategori.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox txt_Urun_Ad;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.TextBox Txt_Marka;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.RichTextBox Richtxt_Aciklama;
        private DevExpress.XtraEditors.CheckEdit chck_Kritiklik_Durumu;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_Kategori;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
    }
}