using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicaNegocio;
using System.Data;


namespace WebApplication
{
    public partial class Cuatrimestre : System.Web.UI.Page
    {

        private BL bl = new BL();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";

            if (!IsPostBack)
            {
                DropDownListCuatri.Items.Clear();
                SqlDataReader cuatri = bl.VerCuatrimestre();
                while (cuatri.Read())
                {
                    DropDownListCuatri.Items.Add(new ListItem()
                    {
                        Text = cuatri[1].ToString(),
                        Value = cuatri[0].ToString(),
                    });
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = bl.VerCuatrimestres();
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Label1.Text = bl.CrearCuatrimestre(new Entidades.Cuatrimestre()
                {
                    Periodo = periodo.Text,
                    Anio = annio.Text,
                    Extra = Extra.Text,
                    Fin = Fin.Text,
                    Inicio = Fin.Text
                });
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                Label1.Text = bl.EliminarCuatrimestre(idEliminar.Text);
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                Label1.Text = bl.UpdateCuatrimestre(new Entidades.Cuatrimestre()
                {
                    Periodo = periodo.Text,
                    Anio = annio.Text,
                    Extra = Extra.Text,
                    Fin = Fin.Text,
                    Inicio = Fin.Text,
                    id_Cuatrimestre = Convert.ToInt32(DropDownListCuatri.SelectedValue)
                });
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }
    }
}