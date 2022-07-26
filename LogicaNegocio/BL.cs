using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Configuration;
using System.Data.SqlClient;

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
        public SqlDataReader VerProfesor(int id)
        {
            string mensaje = "";
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("id", id));
            return DAL.ConsultarReaderconParametros("SELECT * FROM Profesor WHERE ID_Profesor = @id", ref mensaje, listaParametros);
        }
        public string InsertarProfesor(Entidades.Profesor nuevo)
        {
            string mensaje = "";
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("registo", nuevo.RegistroEmpleado));
            listaParametros.Add(new SqlParameter("nombre", nuevo.Nombre));
            listaParametros.Add(new SqlParameter("pat", nuevo.Ap_Pat));
            listaParametros.Add(new SqlParameter("mat", nuevo.Ap_Mat));
            listaParametros.Add(new SqlParameter("gen", nuevo.Genero));
            listaParametros.Add(new SqlParameter("cat", nuevo.Categoria));
            listaParametros.Add(new SqlParameter("corr", nuevo.Correo));
            listaParametros.Add(new SqlParameter("celular", nuevo.Celular));
            listaParametros.Add(new SqlParameter("civil", nuevo.F_EdoCivil));

            DAL.modificacionSegura("INSERT INTO Profesor VALUES(@registo,@nombre,@pat,@mat,@gen,@cat,@corr,@celular, @civil )", ref mensaje, listaParametros);
            return mensaje;
        }


        public string EliminarProfesor(int id)
        {
            string mensaje = "";
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("id", id));
            DAL.modificacionSegura("DELETE FROM Profesor WHERE ID_Profesor = @id", ref mensaje, listaParametros);
            return mensaje;
        }
        public string UpdateProfesor(Entidades.Profesor nuevo)
        {
            string mensaje = "";
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("registo", nuevo.ID_Profe));
            listaParametros.Add(new SqlParameter("nombre", nuevo.Nombre));
            listaParametros.Add(new SqlParameter("pat", nuevo.Ap_Pat));
            listaParametros.Add(new SqlParameter("mat", nuevo.Ap_Mat));
            listaParametros.Add(new SqlParameter("gen", nuevo.Genero));
            listaParametros.Add(new SqlParameter("cat", nuevo.Categoria));
            listaParametros.Add(new SqlParameter("corr", nuevo.Correo));
            listaParametros.Add(new SqlParameter("celular", nuevo.Celular));
            listaParametros.Add(new SqlParameter("civil", nuevo.F_EdoCivil));
            DAL.modificacionSegura("UPDATE Profesor SET Nombre = @nombre, Ap_Pat = @pat, Ap_Mat = @mat, Genero = @gen, Categoria = @cat, Correo = @corr, Celular = @celular, F_EdoCivil = @civil WHERE ID_Profe = @registo", ref mensaje, listaParametros);
            return mensaje;
        }

        public SqlDataReader VerAlumnos()
        {
            string mensaje = "";
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            return DAL.ConsultarReaderconParametros("SELECT * FROM Alumno", ref mensaje, listaParametros);
        }

        public SqlDataReader VerAlumno(int id)
        {
            string mensaje = "";
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("id", id));
            return DAL.ConsultarReaderconParametros("SELECT * FROM Alumno WHERE ID_Alumno = = @id", ref mensaje, listaParametros);
        }

        public string EliminarAlumno(int id)
        {
            string mensaje = "";
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("id", id));
            DAL.modificacionSegura("DELETE FROM Alumno WHERE ID_Alumno = @id", ref mensaje, listaParametros);
            return mensaje;
        }
        public string UpdateAlumno(Entidades.Alumno nuevo)
        {
            string mensaje = "";
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("matricula", nuevo.Matricula));
            listaParametros.Add(new SqlParameter("nombre", nuevo.Nombre));
            listaParametros.Add(new SqlParameter("pat", nuevo.Ap_pat));
            listaParametros.Add(new SqlParameter("mat", nuevo.Ap_mat));
            listaParametros.Add(new SqlParameter("gen", nuevo.Genero));
            listaParametros.Add(new SqlParameter("corr", nuevo.Correo));
            listaParametros.Add(new SqlParameter("celular", nuevo.Celular));
            listaParametros.Add(new SqlParameter("civil", nuevo.F_EdoCivil));
            listaParametros.Add(new SqlParameter("nivel", nuevo.F_Nivel));
            DAL.modificacionSegura("UPDATE Alumno SET Nombre = @nombre, Ap_pat = @pat, Ap_mat = @mat, Genero = @gen, Correo = @corr, Celular = @celular, F_EdoCivil = @civil, F_Nivel = @nivel WHERE Matricula = @matricula", ref mensaje, listaParametros);
            return mensaje;
        }
        public string InsertarAlumno(Entidades.Alumno nuevo)
        {
            string mensaje = "";
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("matricula", nuevo.Matricula));
            listaParametros.Add(new SqlParameter("nombre", nuevo.Nombre));
            listaParametros.Add(new SqlParameter("pat", nuevo.Ap_pat));
            listaParametros.Add(new SqlParameter("mat", nuevo.Ap_mat));
            listaParametros.Add(new SqlParameter("gen", nuevo.Genero));
            listaParametros.Add(new SqlParameter("corr", nuevo.Correo));
            listaParametros.Add(new SqlParameter("celular", nuevo.Celular));
            listaParametros.Add(new SqlParameter("civil", nuevo.F_EdoCivil));
            listaParametros.Add(new SqlParameter("nivel", nuevo.F_Nivel));
            DAL.modificacionSegura("INSERT INTO Alumno (Matricula, Nombre, Ap_pat, Ap_mat, Genero, Correo, Celular, F_EdoCivil, F_Nivel) VALUES (@matricula, @nombre, @pat, @mat, @gen, @corr, @celular, @civil, @nivel)", ref mensaje, listaParametros);
            return mensaje;
        }
        public SqlDataReader VerEstadoCivil()
        {
            string mensaje = "";
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            return DAL.ConsultarReaderconParametros("SELECT * FROM EstadoCivil", ref mensaje, listaParametros);

        }
    }
}
