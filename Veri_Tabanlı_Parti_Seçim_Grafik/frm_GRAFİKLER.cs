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

namespace Veri_Tabanlı_Parti_Seçim_Grafik
{
    public partial class frm_GRAFİKLER : Form
    {
        public frm_GRAFİKLER()
        {
            InitializeComponent();
        }
        SqlConnection bağlanti = new SqlConnection("Data Source=MONSTER;Initial Catalog=Db_Seçim_Proje;Integrated Security=True");
        private void frm_GRAFİKLER_Load(object sender, EventArgs e)
        {
            //Form Yüklendiğinde İlçe Adları Combobox'a gelsin
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("select ILCEAD from Tbl_İLÇE", bağlanti);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                cmb_İLCE_SECİMİ.Items.Add(dr[0]);
            }
            bağlanti.Close();

            //Form Yüklendiğinde Charta Veriler Gelsin
            bağlanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(AKPARTİSİ),sum(ZAFERPARTİSİ),sum(CUMHURİYETHALKPARTİSİ),sum(MİLLİYETÇİHAREKETPARTİSİ),sum(YENİDENREFAHPARTİSİ) from Tbl_İLÇE", bağlanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("AKP", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("ZP", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("CHP", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("MHP", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("YRP", dr2[4]);
            }
            bağlanti.Close();
        }

        private void cmb_İLCE_SECİMİ_SelectedIndexChanged(object sender, EventArgs e)
        {   //İlçe Seçildikten Sonra Oy Sayılarına Göre Progressbar Verielrin gelmesi
            bağlanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_İLÇE where ILCEAD=@p1", bağlanti);//ilçeada göre gelecek
            komut.Parameters.AddWithValue("@p1",cmb_İLCE_SECİMİ.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {  //progressbara veri cekme
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());

                //labellara oyları yazma
                lbl_AKP.Text = dr[2].ToString();
                lbl_ZP.Text = dr[3].ToString();
                lbl_CHP.Text = dr[4].ToString();
                lbl_MHP.Text = dr[5].ToString();
                lbl_YRP.Text = dr[6].ToString();
            }
            bağlanti.Close();
        }
    }
}
