using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication
{
    public partial class Alumnos : System.Web.UI.Page
    {
        LogicaNegocio.BL bl = new LogicaNegocio.BL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label1.Text = bl.InsertarAlumno(new Entidades.Alumno()
            {
                Ap_pat = "paterno",
                Ap_mat = "materno",
                Celular = "1231223",
                Correo = "ho.com",
                F_EdoCivil = 1,
                Genero = "h",
                Matricula = "2378",
                Nombre = "nombre"
            });
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = bl.UpdateAlumno(new Entidades.Alumno()
            {
                Ap_pat = "paterno 2",
                Ap_mat = "materno 2",
                Celular = "1231223 2",
                Correo = "ho.com ",
                F_EdoCivil = 2,
                Genero = "h 2",
                Matricula = "2378  2",
                Nombre = "nombre 2",
                ID_Alumno = 2
            });
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label1.Text = bl.EliminarAlumno(2);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = bl.VerAlumnos();
            GridView1.DataBind();
        }
    }
}