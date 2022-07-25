using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Configuration;
using System.Data.SqlClient;
using Entidades;

namespace LogicaNegocio
{
    public class BL
    {
        private AccesoDatos DAL = new AccesoDatos(ConfigurationManager.ConnectionStrings["cadena"].ConnectionString);

        public SqlDataReader VerProfesores()
        {
            string mensaje = "";
            List<SqlParameter> listaParametros = new List<SqlParameter>();

            return DAL.ConsultarReaderconParametros("SELECT * FROM Profesor", ref mensaje, listaParametros);
        }

        public Boolean InsertarProfesor(Profesor nuevo)
        {
            string mensaje = "";
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@registo", nuevo.RegistroEmpleado));
            listaParametros.Add(new SqlParameter("@nombre", nuevo.Nombre));
            listaParametros.Add(new SqlParameter("@pat", nuevo.Ap_Pat));
            listaParametros.Add(new SqlParameter("@mat", nuevo.Ap_Mat));
            listaParametros.Add(new SqlParameter("@gen", nuevo.Genero));
            listaParametros.Add(new SqlParameter("@cat", nuevo.Categoria));
            listaParametros.Add(new SqlParameter("@corr", nuevo.Correo));
            listaParametros.Add(new SqlParameter("@celular", nuevo.Celular));
            listaParametros.Add(new SqlParameter("@civil", nuevo.F_EdoCivil));
            return DAL.modificacionSegura("INSERT INTO Profesor VALUES(@registo,@nombre,@pat,@mat,@gen,@cat,@corr,@celular, @civil )", ref mensaje, listaParametros);
        }










    }
