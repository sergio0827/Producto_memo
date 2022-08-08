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

        public string InsertarProfesor(Entidades.Profesor nuevo)
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
            DAL.modificacionSegura("INSERT INTO Profesor VALUES(@registo,@nombre,@pat,@mat,@gen,@cat,@corr,@celular, @civil )", ref mensaje, listaParametros);
            return mensaje;
        }


        public string EliminarProfesor(int registro)
        {
            string mensaje = "";
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("@id", registro));
            DAL.modificacionSegura("DELETE FROM Profesor WHERE RegistroEmpleado = @id", ref mensaje, listaParametros);
            return mensaje;
        }
        public string UpdateProfesor(Entidades.Profesor nuevo)
        {
            string mensaje = "";
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("registro", nuevo.RegistroEmpleado));
            listaParametros.Add(new SqlParameter("nombre", nuevo.Nombre));
            listaParametros.Add(new SqlParameter("pat", nuevo.Ap_Pat));
            listaParametros.Add(new SqlParameter("mat", nuevo.Ap_Mat));
            listaParametros.Add(new SqlParameter("gen", nuevo.Genero));
            listaParametros.Add(new SqlParameter("cat", nuevo.Categoria));
            listaParametros.Add(new SqlParameter("corr", nuevo.Correo));
            listaParametros.Add(new SqlParameter("celular", nuevo.Celular));
            listaParametros.Add(new SqlParameter("civil", nuevo.F_EdoCivil));
            DAL.modificacionSegura("UPDATE Profesor SET Nombre = @nombre, Ap_Pat = @pat, Ap_Mat = @mat, Genero = @gen, Categoria = @cat, Correo = @corr, Celular = @celular, F_EdoCivil = @civil WHERE RegistroEmpleado = @registro", ref mensaje, listaParametros);
            return mensaje;
        }

        public SqlDataReader VerAlumnos()
        {
            string mensaje = "";
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            return DAL.ConsultarReaderconParametros("SELECT * FROM Alumno", ref mensaje, listaParametros);
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
            listaParametros.Add(new SqlParameter("id", nuevo.ID_Alumno));
            DAL.modificacionSegura("UPDATE Alumno SET Matricula = matricula, Nombre = @nombre, Ap_pat = @pat, Ap_mat = @mat, Genero = @gen, Correo = @corr, Celular = @celular, F_EdoCivil = @civil WHERE ID_Alumno = @id", ref mensaje, listaParametros);
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
            DAL.modificacionSegura("INSERT INTO Alumno (Matricula, Nombre, Ap_pat, Ap_mat, Genero, Correo, Celular, F_EdoCivil) VALUES (@matricula, @nombre, @pat, @mat, @gen, @corr, @celular, @civil)", ref mensaje, listaParametros);
            return mensaje;
        }















        public SqlDataReader VerEstadoCivil()
        {
            string mensaje = "";
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            return DAL.ConsultarReaderconParametros("SELECT * FROM EstadoCivil", ref mensaje, listaParametros);
        }
        public SqlDataReader VerCuatrimestres(int id)
        {
            string mensaje = "";
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("id", id));
            return DAL.ConsultarReaderconParametros("SELECT * FROM Cuatrimestre WHERE id_Cuatrimestre = @id", ref mensaje, listaParametros);
        }

        public SqlDataReader VerCuatrimestre()
        {
            string mensaje = "";
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            return DAL.ConsultarReaderconParametros("SELECT * FROM Cuatrimestre", ref mensaje, listaParametros);
        }

        public string CrearCuatrimestre(Entidades.Cuatrimestre nuevo)
        {
            string mensaje = "";
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("periodo", nuevo.Periodo));
            listaParametros.Add(new SqlParameter("anio", nuevo.Anio));
            listaParametros.Add(new SqlParameter("inicio", nuevo.Inicio));
            listaParametros.Add(new SqlParameter("fin", nuevo.Fin));
            listaParametros.Add(new SqlParameter("extra", nuevo.Extra));
            DAL.modificacionSegura("INSERT INTO Cuatrimestre (Periodo, Anio, Inicio, Fin, Extra) VALUES (@periodo, @anio, @inicio, @fin, @extra)", ref mensaje, listaParametros);
            return mensaje;
        }
        public string EliminarCuatrimestre(int id)
        {
            string mensaje = "";
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("id", id));
            DAL.modificacionSegura("DELETE FROM Cuatrimestre WHERE id_Cuatrimestre = @id", ref mensaje, listaParametros);
            return mensaje;
        }

        public string UpdateCuatrimestre(Entidades.Cuatrimestre nuevo)
        {
            string mensaje = "";
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            listaParametros.Add(new SqlParameter("periodo", nuevo.Periodo));
            listaParametros.Add(new SqlParameter("anio", nuevo.Anio));
            listaParametros.Add(new SqlParameter("inicio", nuevo.Inicio));
            listaParametros.Add(new SqlParameter("fin", nuevo.Fin));
            listaParametros.Add(new SqlParameter("extra", nuevo.Extra));
            listaParametros.Add(new SqlParameter("id", nuevo.id_Cuatrimestre));
            DAL.modificacionSegura("UPDATE Cuatrimestre SET Periodo = @periodo, Anio = @anio, Inicio = @inicio, Fin = @fin, Extra = @extra WHERE id_Cuatrimestre = @id", ref mensaje, listaParametros);
            return mensaje;
        }

        public SqlDataReader VergrupoCuatrimestre()
        {
            string mensaje = "";
            List<SqlParameter> listaParametros = new List<SqlParameter>();
            return DAL.ConsultarReaderconParametros("SELECT * FROM GrupoCuatrimestre", ref mensaje, listaParametros);
        }


    }
}