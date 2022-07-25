using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
        public int Nombre { get; set; }
        public string Ap_pat { get; set; }
        public string Ap_mat { get; set; }
        public string Genero { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public int F_EdoCivil { get; set; }
        public int F_Nivel { get; set; }
    }


}
