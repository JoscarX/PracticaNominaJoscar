using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaNominaJoscar.Class
{
    public class CEmpleadoAsalariadoPorComision: CEmpleadoAsalariado
    {
        public double ventasBrutas { get; set; }
        public double tarifaComision { get; set; }

        public CEmpleadoAsalariadoPorComision(string nombre, string apellido, string nss, double salario, double ventasBrutas, double tarifaComision)
            : base (nombre, apellido, nss,salario)
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
            double salario = base.SalarioSemanal();
            pagoCorrespondiente = (ventasBrutas * tarifaComision) + salario + (salario * 0.10);

            return pagoCorrespondiente;

        }
    }
}
