using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaNominaJoscar.Class
{
    public class CEmpleadoPorComision : Empleado
    {
        public double ventasBrutas { get; set; }
        public double tarifaComision { get; set; }

        public CEmpleadoPorComision(string nombre, string apellido, string nss, double tarifaComision, double ventasBrutas)
            :base (nombre, apellido,nss)
        {
            this.ventasBrutas = ventasBrutas;
            this.tarifaComision = tarifaComision;
        }

        public double GetVentasBrutas()
        {
            return this.ventasBrutas;
        }

        public double GetTarifaComision()
        {
            return this.tarifaComision;
        }

        public double GetSalarioSemanal()
        {
            double pagoCorrespondiente = 0;
            double ventasBrutas = GetVentasBrutas();
            double tarifaComision = GetTarifaComision();

            pagoCorrespondiente = ventasBrutas * tarifaComision;

            return pagoCorrespondiente;

        }
    }
}
