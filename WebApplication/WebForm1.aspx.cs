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

        private BL bl = new BL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = bl.VerProfesores();
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = bl.InsertarProfesor(new Entidades.Profesor()
            {
                RegistroEmpleado = 3123,
                Nombre = "Juan",
                Ap_Pat = "Perez",
                Ap_Mat = "Perez",
                Categoria = "Profesor",
                Celular = "123456789",
                Correo = "dmwikdmw@gmail.com",
                Genero = "M",
                F_EdoCivil = 1
            });


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label1.Text = bl.EliminarProfesor(2014);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label1.Text = bl.UpdateProfesor(new Entidades.Profesor()
            {
                ID_Profe = 2016,
                Nombre = "Juan 2",
                Ap_Pat = "Perez 2",
                Ap_Mat = "Perez 2",
                Categoria = "Profesor 2",
                Celular = "123456789",
                Correo = "dmwikdmw@gmail.com 2",
                Genero = "M 2",
                F_EdoCivil = 2
            });
        }
    }
}