namespace UrunDoldur
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_UrunDoldur = new System.Windows.Forms.Button();
            this.btn_UrunGetir = new System.Windows.Forms.Button();
            this.btn_KategoriDoldur = new System.Windows.Forms.Button();
            this.btn_KategoriGetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(620, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_UrunDoldur
            // 
            this.btn_UrunDoldur.Location = new System.Drawing.Point(38, 14);
            this.btn_UrunDoldur.Name = "btn_UrunDoldur";
            this.btn_UrunDoldur.Size = new System.Drawing.Size(216, 43);
            this.btn_UrunDoldur.TabIndex = 1;
            this.btn_UrunDoldur.Text = "Ürünleri Doldur";
            this.btn_UrunDoldur.UseVisualStyleBackColor = true;
            this.btn_UrunDoldur.Click += new System.EventHandler(this.btn_UrunDoldur_Click);
            // 
            // btn_UrunGetir
            // 
            this.btn_UrunGetir.Location = new System.Drawing.Point(38, 81);
            this.btn_UrunGetir.Name = "btn_UrunGetir";
            this.btn_UrunGetir.Size = new System.Drawing.Size(216, 42);
            this.btn_UrunGetir.TabIndex = 2;
            this.btn_UrunGetir.Text = "Ürün Getir";
            this.btn_UrunGetir.UseVisualStyleBackColor = true;
            this.btn_UrunGetir.Click += new System.EventHandler(this.btn_UrunGetir_Click);
            // 
            // btn_KategoriDoldur
            // 
            this.btn_KategoriDoldur.Location = new System.Drawing.Point(442, 14);
            this.btn_KategoriDoldur.Name = "btn_KategoriDoldur";
            this.btn_KategoriDoldur.Size = new System.Drawing.Size(216, 41);
            this.btn_KategoriDoldur.TabIndex = 3;
            this.btn_KategoriDoldur.Text = "Kategorileri Doldur";
            this.btn_KategoriDoldur.UseVisualStyleBackColor = true;
            this.btn_KategoriDoldur.Click += new System.EventHandler(this.btn_KategoriDoldur_Click);
            // 
            // btn_KategoriGetir
            // 
            this.btn_KategoriGetir.Location = new System.Drawing.Point(442, 81);
            this.btn_KategoriGetir.Name = "btn_KategoriGetir";
            this.btn_KategoriGetir.Size = new System.Drawing.Size(216, 42);
            this.btn_KategoriGetir.TabIndex = 4;
            this.btn_KategoriGetir.Text = "Kategori Getir";
            this.btn_KategoriGetir.UseVisualStyleBackColor = true;
            this.btn_KategoriGetir.Click += new System.EventHandler(this.btn_KategoriGetir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_KategoriGetir);
            this.Controls.Add(this.btn_KategoriDoldur);
            this.Controls.Add(this.btn_UrunGetir);
            this.Controls.Add(this.btn_UrunDoldur);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_UrunDoldur;
        private System.Windows.Forms.Button btn_UrunGetir;
        private System.Windows.Forms.Button btn_KategoriDoldur;
        private System.Windows.Forms.Button btn_KategoriGetir;
    }
}

