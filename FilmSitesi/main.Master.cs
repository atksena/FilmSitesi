using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilmSitesi
{
    public partial class main : System.Web.UI.MasterPage
    {
        SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            HaberleriGetir();


            object kullanici = Session["kullaniciadi"];
            if(kullanici != null)
            {
                pnlGiris.Visible = false;
                pnlKullanici.Visible = true;
                lblKullaniciAdi.Text = kullanici.ToString();
            }
            else
            {
                pnlKullanici.Visible = false;
                pnlGiris.Visible = true;
            }
        }
        private void HaberleriGetir()
        {
           

            string sorgu = "Select*From Haberler order by Tarih desc";

            SqlCommand cmd = new SqlCommand(sorgu, cnn);
            cnn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            lstHaber.DataSource = dr;
            lstHaber.DataBind();

            cnn.Close();
        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            string sorgu = "Select*from Kullanicilar Where KullaniciAdi = @kullaniciadi AND Sifre = @sifre";
            SqlCommand cmd=new SqlCommand(sorgu, cnn);
            cmd.Parameters.AddWithValue("@kullaniciadi", txtKullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);

            cnn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Session.Timeout = 300;
                Session.Add("kullaniciadi", dr["kullaniciAdi"].ToString());
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                lblSonuc.Text = "Kullanıcı girişi sağlanamadı.";
            }

            cnn.Close();
        }

        protected void btnCikis_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect(Request.RawUrl);
        }

    
    }
}