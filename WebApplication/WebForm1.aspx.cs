using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicaNegocio;

namespace WebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        BL bl = new BL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = bl.VerProfesores();
            GridView1.DataBind();
        }
    }
}