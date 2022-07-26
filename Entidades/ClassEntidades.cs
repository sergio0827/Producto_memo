using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class Profesor
    {
        public int ID_Profe { get; set; }
        public int RegistroEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Ap_Pat { get; set; }
        public string Ap_Mat { get; set; }
        public string Genero { get; set; }
        public string Categoria { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public int F_EdoCivil { get; set; }
    }
    public class EstadoCivil
    {
        public int Id_Edo { get; set; }
        public string Estado { get; set; }
        public int Extra { get; set; }
    }
    public class Alumno
    {
        public int ID_Alumno { get; set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Ap_pat { get; set; }
        public string Ap_mat { get; set; }
        public string Genero { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public int F_EdoCivil { get; set; }
    }
    public class Cuatrimestre
    {
        public int id_Cuatrimestre { get; set; }
        public string Periodo { get; set; }
        public string Anio { get; set; }
        public string Inicio { get; set; }
        public string Fin { get; set; }
        public string Extra { get; set; }
    }
    public class grupoCuatrimestre
    {
        public int Id_GruCuat { get; set; }
        public string F_ProgEd { get; set; }
        public string F_Grupo { get; set; }
        public string F_Cuatri { get; set; }
        public string Turno { get; set; }
        public string Modalidad { get; set; }
        public string Extra { get; set; }
    }

    public class AlumnoGRupo
    {
        public int ID_AlumnGru { get; set; }
        public int F_Alumn { get; set; }
        public int F_GruCuat { get; set; }
        public string Extra { get; set; }
        public string Extra2 { get; set; }
    }

    public class ProfeGrupo
    {
        public int ID_ProfeGru { get; set; }
        public int F_Profe { get; set; }
        public int F_GruCuat { get; set; }
        public string Extra { get; set; }
        public string Extra2 { get; set; }
    }
    public class positivoProfe
    {
        public int Id_posProfe { get; set; }
        public string FechaConfirmado { get; set; }
        public string Comprobacion { get; set; }
        public string Antecedentes { get; set; }
        public string Riesgo { get; set; }
        public string Extra { get; set; }
        public int F_Profe { get; set; }
        public string imagen { get; set; }
        public int discpacidad { get; set; }
    }

    public class positivoAlumno
    {
        public int Id_posProfe { get; set; }
        public string FechaConfirmado { get; set; }
        public string Comprobacion { get; set; }
        public string Antecedentes { get; set; }
        public string Riesgo { get; set; }
        public int NumContaio { get; set; }
        public string Extra { get; set; }
        public int F_Profe { get; set; }
        public string imagen { get; set; }
        public string discpacidad { get; set; }
    }






}
