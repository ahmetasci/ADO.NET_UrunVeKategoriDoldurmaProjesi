using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace UrunDoldur
{
    //Ürünleri Doldur deyince SQL Northwind databaseden Dataset içindeki Ürünler DataTableında, Kategorileri Doldur deyince Dataset içindeki 
    //    Kategoriler DataTableında hafızaya alacak.

    //    Ürün Getir Ve Kategori Doldur deyince hafızadaki ürünleri ekrana getirsin..
    public partial class Form1 : Form
    {
        //DISCONNECTED MİMARİ
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);//app.Configdeki tanımlı bağlantıyı çağırdık
       
        SqlDataAdapter da;
        DataTable dt;
        //Tanımlamalar global
        DataSet ds = new DataSet();
        //Dataset Özellikle dışarıda tanımladık. local tanımlasaydık dataset scopetan çıkınca hafızasını sıfırlıyor.
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_UrunDoldur_Click(object sender, EventArgs e)
        {
            if (ds.Tables.Contains("Ürünler"))//Contains=İçerik
            { //eğer ds datasetinde Ürünler tablosu varsa 
                MessageBox.Show("Ürünler tablosu hafızada mevcut.");
            }
            else
            {
                da = new SqlDataAdapter("SELECT*FROM Products", con);
                dt = new DataTable("Ürünler");

                da.Fill(dt);//dataadapter ile dt(Ürünler) datatable'ını doldur.
                ds.Tables.Add(dt); // dt datatable'ını ds datasetine at.

                MessageBox.Show("ÜRÜNLER BAŞARIYLA EKLENDİ.");
            }
           
          
        }

        private void btn_UrunGetir_Click(object sender, EventArgs e)
        {
            if (ds.Tables.Contains("Ürünler"))
            {
                dataGridView1.DataSource = ds.Tables["Ürünler"];
                //datagridviewın kaynağı ds Datasetindeki Ürünler Datatable'ı
            }
            else
            {
                MessageBox.Show("Henüz hafızaya Ürünlerle ilgili veri girilmedi.");
            }

        }

        private void btn_KategoriDoldur_Click(object sender, EventArgs e)
        {

            if (ds.Tables.Contains("Kategoriler"))
            { //eğer ds datasetinde Kategoriler tablosu varsa 

                MessageBox.Show("Kategoriler tablosu hafızada mevcut.");
            }
            else
            {
                da = new SqlDataAdapter("SELECT*FROM Categories", con);
                dt = new DataTable("Kategoriler");

                da.Fill(dt);
                ds.Tables.Add(dt);

                MessageBox.Show(" KATEGORİLER BAŞARIYLA EKLENDİ.");
            }
           
        }

        private void btn_KategoriGetir_Click(object sender, EventArgs e)
        {
            if (ds.Tables.Contains("Kategoriler"))
            {
                dataGridView1.DataSource = ds.Tables["Kategoriler"];
                //datagridviewın kaynağı ds Datasetindeki kategoriler Datatable'ı
            }
            else
            {
                MessageBox.Show("Henüz hafızaya Kategorilerle ilgili veri girilmedi.");
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
