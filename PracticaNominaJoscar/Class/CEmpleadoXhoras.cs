using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaNominaJoscar.Class
{
    public class CEmpleadoXhoras : Empleado
    {
        public double sueldoPorHora { get; set; }
        public double horasTrabajadas { get; set; }

        public CEmpleadoXhoras(string nombre, string apellido, string nss, double sueldoPorHora, double horasTrabajadas)
            :base (nombre, apellido, nss)
        {
            this.sueldoPorHora = sueldoPorHora;
            this.horasTrabajadas = horasTrabajadas;
        }

        public double GetSueldo()
        {
            return sueldoPorHora;
        }

        public double GetHorasTrabajadas()
        {
            return horasTrabajadas;
        }

        public double GetSalarioSemanal()
        {
            double sueldo = GetSueldo();
            double horasTrabajadas = GetHorasTrabajadas();
            double pagoCorrespondiente = 0;

            if (this.horasTrabajadas > 40)
                pagoCorrespondiente = (sueldo * horasTrabajadas) + (sueldo * 1.5 * (horasTrabajadas - 40));
            else
                pagoCorrespondiente = sueldo * horasTrabajadas;

            return pagoCorrespondiente;
        }
    }
}
