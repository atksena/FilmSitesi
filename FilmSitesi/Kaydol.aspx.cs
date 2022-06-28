using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace FilmSitesi
{
    public partial class Kaydol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDurum.Visible = false;
        }

        protected void btnKayit_Click(object sender, EventArgs e)
        {
            string kullaniciAdi= txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            if(kullaniciAdi.Contains(" ")==true | sifre.Contains(" ") == true)
            {
                lblSonuc.Text = "Kullanıcı adı veya şifre içinde boşluk olamaz.";
            }
            else
            {
                if (txtKullaniciAdi.Text != "" && txtSifre.Text != "")
                {
                    SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings[0].ConnectionString);

                    string sorgu = "Insert into Kullanicilar (KullaniciAdi, Sifre) values (@kullaniciadi,@sifre)";

                    SqlCommand cmd = new SqlCommand(sorgu, cnn);
                    cnn.Open();

                    try
                    {
                        cmd.Parameters.AddWithValue("@kullaniciadi", txtKullaniciAdi.Text);
                        cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);

                        cmd.ExecuteNonQuery();
                        cnn.Close();

                        pnlKayit.Visible = false; 
                        pnlDurum.Visible = true;

                        Session.Add("kullaniciadi", txtKullaniciAdi.Text);

                        lblDurum.Text= "Kayıt olundu.";
                    }
                    catch (Exception)
                    {
                        lblSonuc.Text = "Kayıt yapılamadı.";
                    }
                }
                else
                {
                    lblSonuc.Text = "Boş alanları doldurun.";
                }
            }

        }
    }
    }
