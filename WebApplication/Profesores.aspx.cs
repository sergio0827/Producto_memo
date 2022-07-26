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


            //F_EdoCivil.Items.Clear();

            //F_EdoCivil.Items.Add(new ListItem()
            //{
            //    Text = "Soltero",
            //    Value = "12",
            //});
            //F_EdoCivil.Items.Add(new ListItem()
            //{
            //    Text = "Casado",
            //    Value = "2",
            //});
            //F_EdoCivil.Items.Add(new ListItem()
            //{
            //    Text = "Divorciado",
            //    Value = "4",
            //});
            //F_EdoCivil.Items.Add(new ListItem()
            //{
            //    Text = "Union Libre",
            //    Value = "5",
            //});
            //F_EdoCivil.Items.Add(new ListItem()
            //{
            //    Text = "Viudo",
            //    Value = "6",
            //});
            //F_EdoCivil.Items.Add(new ListItem()
            //{
            //    Text = "raro",
            //    Value = "12",
            //});


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = bl.VerProfesores();
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write(F_EdoCivil.SelectedValue);

            int drop = Convert.ToInt32(F_EdoCivil.SelectedValue);

            Label1.Text = bl.InsertarProfesor(new Entidades.Profesor()
            {
                RegistroEmpleado = Convert.ToInt16(RegistroEmpleado.Text),
                Nombre = Nombre.Text,
                Ap_Pat = Ap_pat.Text,
                Ap_Mat = Ap_Mat.Text,
                Categoria = Categoria.Text,
                Celular = Celular.Text,
                Correo = Correo.Text,
                Genero = Genero.Text,
                F_EdoCivil = drop
            });

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label1.Text = bl.EliminarProfesor(Convert.ToInt16(idEliminar.Text));
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label1.Text = bl.UpdateProfesor(new Entidades.Profesor()
            {
                ID_Profe = Convert.ToInt16(idEditar.Text),
                RegistroEmpleado = Convert.ToInt16(RegistroEmpleado.Text),
                Nombre = Nombre.Text,
                Ap_Pat = Ap_pat.Text,
                Ap_Mat = Ap_Mat.Text,
                F_EdoCivil = Convert.ToInt16(F_EdoCivil.SelectedValue),
                Categoria = Categoria.Text,
                Celular = Celular.Text,
                Correo = Correo.Text,
                Genero = Genero.Text
            });
        }
    }
}