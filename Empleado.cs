using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarCur
{
    public class Empleado
    {
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get;set; }
        public int Celular { get; set; }
        public int Telefono { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public int NumeroRuc { get; set; }
        public int NumeroINSS { get; set; }
        public int NumeroEmpleado { get; set; }
        public double SalarioBase { get; set; }
        public DateTime Contratacion { get; set; }
        public DateTime CierreContrato { get; set; }
        public string EstadoLaboral { get; set; }

    }
}
