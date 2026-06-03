using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaNominaJoscar.Class
{
    public class CEmpleadoAsalariado : Empleado
    {
        public double salarioSemanal{ get; set; }

        public CEmpleadoAsalariado(string nombre, string apellido, string nss, double salarioSemanal)
        : base (nombre, apellido, nss)
        {
            this.salarioSemanal = salarioSemanal;
        }

        public double SalarioSemanal()
        {
            return this.salarioSemanal;
        }
    }
}
