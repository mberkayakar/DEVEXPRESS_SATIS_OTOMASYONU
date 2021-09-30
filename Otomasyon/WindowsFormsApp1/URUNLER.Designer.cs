
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit8 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.richTextBox1);
            this.groupControl1.Controls.Add(this.numericUpDown1);
            this.groupControl1.Controls.Add(this.textEdit8);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.textEdit6);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.textEdit4);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.textEdit3);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(575, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(213, 426);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
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
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(95, 61);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(113, 20);
            this.textEdit1.TabIndex = 1;
            this.textEdit1.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(95, 87);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(113, 20);
            this.textEdit2.TabIndex = 3;
            this.textEdit2.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
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
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(95, 113);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(113, 20);
            this.textEdit3.TabIndex = 5;
            this.textEdit3.EditValueChanged += new System.EventHandler(this.textEdit3_EditValueChanged);
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
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(95, 139);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(113, 20);
            this.textEdit4.TabIndex = 7;
            this.textEdit4.EditValueChanged += new System.EventHandler(this.textEdit4_EditValueChanged);
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
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(96, 165);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Size = new System.Drawing.Size(112, 20);
            this.textEdit6.TabIndex = 11;
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
            // textEdit8
            // 
            this.textEdit8.Location = new System.Drawing.Point(95, 217);
            this.textEdit8.Name = "textEdit8";
            this.textEdit8.Size = new System.Drawing.Size(113, 20);
            this.textEdit8.TabIndex = 15;
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(95, 192);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(113, 21);
            this.numericUpDown1.TabIndex = 16;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(95, 248);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(113, 69);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(15, 368);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(191, 44);
            this.simpleButton1.TabIndex = 18;
            this.simpleButton1.Text = "Kaydet";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // URUNLER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 445);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "URUNLER";
            this.Text = "URUNLER";
            this.Load += new System.EventHandler(this.URUNLER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit8;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}