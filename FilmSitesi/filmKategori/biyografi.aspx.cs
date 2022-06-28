using System;
using System.Linq;
using System.Web.UI;

namespace FilmSitesi
{
    public partial class biyografi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("/filmEkranlari/filmEkrani9.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("/filmEkranlari/filmEkrani10.aspx");
        }
    }
}