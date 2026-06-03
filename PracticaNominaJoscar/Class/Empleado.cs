using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaNominaJoscar.Class
{
    public abstract class Empleado
    {
        public string primerNombre { get; set; } 
        public string apellidoPaterno { get; set; } 
        public string numeroSeguroSocial { get; set; } 

        public Empleado(string nombre, string apellido, string nss)
        {
            primerNombre = nombre;
            apellidoPaterno = apellido;
            numeroSeguroSocial = nss;
        }

        public string GetNombre()
        {
            return primerNombre;
        }

        public string GetApellido()
        {
            return apellidoPaterno;
        }

        public string GetNss()
        {
            return numeroSeguroSocial;
        }
    }
}
