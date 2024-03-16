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

namespace Veri_Tabanlı_Parti_Seçim_Grafik
{
    public partial class Frm_OY_GİRİŞ : Form
    {
        public Frm_OY_GİRİŞ()
        {
            InitializeComponent();
        }
        SqlConnection bağlanti = new SqlConnection("Data Source=MONSTER;Initial Catalog=Db_Seçim_Proje;Integrated Security=True");
        private void btn_OY_GİRİŞİ_Click(object sender, EventArgs e)
        {   //Oy Girişi Yapma
            try
            {
                bağlanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Tbl_İLÇE (ILCEAD,AKPARTİSİ,ZAFERPARTİSİ,CUMHURİYETHALKPARTİSİ,MİLLİYETÇİHAREKETPARTİSİ,YENİDENREFAHPARTİSİ)VALUES(@P1,@P2,@P3,@P4,@P5,@P6)", bağlanti);
                komut.Parameters.AddWithValue("@p1", txt_İLÇE_AD.Text);
                komut.Parameters.AddWithValue("@p2", txt_AKP.Text);
                komut.Parameters.AddWithValue("@p3", txt_ZP.Text);
                komut.Parameters.AddWithValue("@p4", txt_CHP.Text);
                komut.Parameters.AddWithValue("@p5", txt_MHP.Text);
                komut.Parameters.AddWithValue("@p6", txt_YRP.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Oy Girişi Yapılmıştır" , " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message,  "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bağlanti.Close();
            }
              
        }

        private void btn_GRAFİKLER_Click(object sender, EventArgs e)
        {
            frm_GRAFİKLER fr = new frm_GRAFİKLER();
            fr.Show();
        }

        private void btn_ÇIKIŞ_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
