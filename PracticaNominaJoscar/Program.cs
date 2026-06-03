using PracticaNominaJoscar.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaNominaJoscar
{
    internal class Program
    {

        public static List<CEmpleadoAsalariado> EmpleadoAsalariadoList = new List<CEmpleadoAsalariado>();
        public static List<CEmpleadoXhoras> EmpleadoPorHoraList = new List<CEmpleadoXhoras>();
        public static List<CEmpleadoPorComision> EmpleadoPorComisionList = new List<CEmpleadoPorComision>();
        public static List<CEmpleadoAsalariadoPorComision> EmpleadoAsalariadoPorComisionList = new List<CEmpleadoAsalariadoPorComision>();

        static void Main(string[] args)
        {


            var Empleado1 = new CEmpleadoAsalariado
            (
                "Joscar",
                "Mota",
                "456456",
                25000
            );

            var Empleado2 = new CEmpleadoAsalariado
            (
                "Manuela",
                "Miguelina",
                "564564",
                23000
            );

            var Empleado3 = new CEmpleadoXhoras
            (
                "Lisbeth",
                "Montero",
                "223322",
                450,
                60
            );

            var Empleado4 = new CEmpleadoXhoras
            (
                "Isael",
                "Riveras",
                "898014",
                450,
                60
            );

            var Empleado5 = new CEmpleadoPorComision
            (
                "Francisco",
                "Moderno",
                "610014",
                30,
                235
            );

            var Empleado6 = new CEmpleadoPorComision
            (
                "Juan",
                "Ramirez",
                "736014",
                40,
                240
            );

            var Empleado7 = new CEmpleadoAsalariadoPorComision
            (
                "Tomas",
                "Nuñez",
                "317458",
                18565,
                4200,
                225
                
            );

            var Empleado8 = new CEmpleadoAsalariadoPorComision
            (
                "Timoteo",
                "Mañoso",
                "312936",
                15000,
                38,
                200
            );

            EmpleadoAsalariadoList.Add(Empleado1);
            EmpleadoAsalariadoList.Add(Empleado2);
            EmpleadoPorHoraList.Add(Empleado3);
            EmpleadoPorHoraList.Add(Empleado4);
            EmpleadoPorComisionList.Add(Empleado5);
            EmpleadoPorComisionList.Add(Empleado6);
            EmpleadoAsalariadoPorComisionList.Add(Empleado7);
            EmpleadoAsalariadoPorComisionList.Add(Empleado8);

            int opciones = 0;
            bool MantenerBucle = true;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("==================");
                    Console.WriteLine("======MENU========");
                    Console.WriteLine("==================");
                    Console.WriteLine("1- Agregar empleados");
                    Console.WriteLine("2- Actualizar empleados");
                    Console.WriteLine("3- Obtener reporte de pagos semanales");
                    Console.WriteLine("4- Salir");
                    Console.WriteLine();
                    Console.Write("Ingrese el # de la opcion que desea: ");
                    opciones = Convert.ToInt32(Console.ReadLine());

                    switch (opciones)
                    {
                        case 1:
                            while (AgregarEmpleados()) ;
                            break;
                        case 2:
                            while (ActualizarEmpleados()) ;
                            break;
                        case 3:
                            ObtenerTodosPagoSemanales();
                            break;
                        case 4:
                            MantenerBucle = false;
                            break;
                    }


                }catch( Exception ex) {
                    Console.WriteLine("Ha ocurrido un error: " + ex.Message);
                    Console.WriteLine();
                    Console.WriteLine("Presione enter para continuar...");
                    Console.ReadLine();
                }

            } while (MantenerBucle);


        }

        static bool AgregarEmpleados()
        {
            Console.Clear();
            int opcion, salir;
            string nombre, apellido, nss;
            double sueldo, sueldoHora, horasTrabajadas,tarifa,ventasB;
            Console.WriteLine("¿Que tipo de empleado desea agregar?");
            Console.WriteLine("1- Empleado Asalariado");
            Console.WriteLine("2- Empleado por Horas");
            Console.WriteLine("3- Empleado por Comisión");
            Console.WriteLine("4- Empleado Asalariado por Comisión");
            Console.WriteLine("5- Regresar");
            Console.Write("Ingrese el # de la opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine();
                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Apellido: ");
                    apellido = Console.ReadLine();
                    Console.Write("Num. Seguro social: ");
                    nss = Console.ReadLine();
                    Console.Write("Sueldo Semanal: ");
                    sueldo = Convert.ToDouble(Console.ReadLine());

                    var temp = new CEmpleadoAsalariado(nombre,apellido,nss,sueldo);
                    EmpleadoAsalariadoList.Add(temp);

                    Console.WriteLine();
                    Console.WriteLine("Empleado agregado correctamente :)");
                    break;
                case 2:
                    Console.WriteLine();
                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Apellido: ");
                    apellido = Console.ReadLine();
                    Console.Write("Num. Seguro social: ");
                    nss = Console.ReadLine();
                    Console.Write("Sueldo por hora: ");
                    sueldoHora = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Horas trabajadas: ");
                    horasTrabajadas = Convert.ToDouble(Console.ReadLine());

                    var temp1 = new CEmpleadoXhoras(nombre, apellido, nss, sueldoHora,horasTrabajadas);
                    EmpleadoPorHoraList.Add(temp1);

                    Console.WriteLine();
                    Console.WriteLine("Empleado agregado correctamente :)");
                    break;
                case 3:
                    Console.WriteLine();
                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Apellido: ");
                    apellido = Console.ReadLine();
                    Console.Write("Num. Seguro social: ");
                    nss = Console.ReadLine();
                    Console.Write("Tarifa comision: ");
                    tarifa = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ventas brutas: ");
                    ventasB = Convert.ToDouble(Console.ReadLine());

                    var temp2 = new CEmpleadoPorComision(nombre, apellido, nss, tarifa, ventasB);
                    EmpleadoPorComisionList.Add(temp2);

                    Console.WriteLine();
                    Console.WriteLine("Empleado agregado correctamente :)");
                    break;
                case 4:
                    Console.WriteLine();
                    Console.Write("Nombre: ");
                    nombre = Console.ReadLine();
                    Console.Write("Apellido: ");
                    apellido = Console.ReadLine();
                    Console.Write("Num. Seguro social: ");
                    nss = Console.ReadLine();
                    Console.Write("Sueldo Semanal: ");
                    sueldo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Tarifa comision: ");
                    tarifa = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ventas brutas: ");
                    ventasB = Convert.ToDouble(Console.ReadLine());

                    var temp3 = new CEmpleadoAsalariadoPorComision(nombre, apellido, nss, sueldo, ventasB, tarifa);
                    EmpleadoAsalariadoPorComisionList.Add(temp3);

                    Console.WriteLine();
                    Console.WriteLine("Empleado agregado correctamente :)");
                    break;
                case 5: return false;
                default:
                    Console.WriteLine();
                    Console.WriteLine($"opcion: {opcion} no es compatible con ninguna de las opciones disponibles :/");
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("¿Desea agregar otro empleado? ");
            Console.WriteLine("1- SI");
            Console.WriteLine("2- NO");
            Console.Write("ingrese el # de la opcion que desea: ");
            salir = Convert.ToInt32(Console.ReadLine());

            if (salir == 1)
            {
                Console.Clear();
                return true;
            }
            else
            {
                Console.Clear();
                return false;
            }


        }

        static bool ActualizarEmpleados()
        {
            Console.Clear();
            int opcion, salir, id;
            string nombre, apellido, nss;
            double sueldo, sueldoHora, horasTrabajadas, tarifa, ventasB;
            Console.WriteLine("¿Que tipo de empleado desea actualizar?");
            Console.WriteLine("1- Empleado Asalariado");
            Console.WriteLine("2- Empleado por Horas");
            Console.WriteLine("3- Empleado por Comisión");
            Console.WriteLine("4- Empleado Asalariado por Comisión");
            Console.WriteLine("5- Regresar");
            Console.Write("Ingrese el # de la opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine();
                    Console.Write("Ingrese el id del empleado que desea actualizar: ");
                    id = Convert.ToInt32(Console.ReadLine());

                    if (id >= 0 && id < EmpleadoAsalariadoList.Count())
                    {
                        var EmpEncontrado = EmpleadoAsalariadoList[id];

                        Console.WriteLine();
                        Console.WriteLine("NOTA: Si desea modificar el valor actual ingrese el nuevo valor de lo contrario dejarlo vacio");
                        Console.WriteLine();
                        Console.WriteLine($"Nombre: {EmpEncontrado.GetNombre()}");
                        Console.Write("Ingrese el nuevo valor: ");
                        nombre = Console.ReadLine();

                        if (string.IsNullOrEmpty(nombre))
                        {
                            nombre = EmpEncontrado.GetNombre();
                            Console.WriteLine("No se modifico el valor");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Valor modificado");
                            Console.WriteLine();
                        }

                        Console.WriteLine($"Apellido: {EmpEncontrado.GetApellido()}");
                        Console.Write("Ingrese el nuevo valor: ");
                        apellido = Console.ReadLine();

                        if (string.IsNullOrEmpty(apellido))
                        {
                            apellido = EmpEncontrado.GetApellido();
                            Console.WriteLine("No se modifico el valor");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Valor modificado");
                            Console.WriteLine();
                        }

                        Console.WriteLine($"Num. Seguro social: {EmpEncontrado.GetNss()}");
                        Console.Write("Ingrese el nuevo valor: ");
                        nss = Console.ReadLine();

                        if (string.IsNullOrEmpty(nss))
                        {
                            nss = EmpEncontrado.GetNss();
                            Console.WriteLine("No se modifico el valor");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Valor modificado");
                            Console.WriteLine();
                        }

                        Console.WriteLine($"Sueldo semanal: {EmpEncontrado.SalarioSemanal()}");
                        Console.Write("Ingrese el nuevo valor: ");
                        string sueldoTemp = Console.ReadLine();

                        if (string.IsNullOrEmpty(sueldoTemp))
                        {
                            sueldo = EmpEncontrado.SalarioSemanal();
                            Console.WriteLine("No se modifico el valor");
                            Console.WriteLine();
                        }
                        else
                        {
                            sueldo = Convert.ToDouble(sueldoTemp);
                            Console.WriteLine("Valor modificado");
                            Console.WriteLine();
                        }

                        var temp = new CEmpleadoAsalariado(nombre, apellido, nss, sueldo);

                        EmpleadoAsalariadoList[id] = temp;

                        Console.WriteLine();
                        Console.WriteLine("Empleado actualizado correctamente :)");
                    }
                    else
                    {
                        Console.WriteLine("El id ingresado no contiene ningun empleado");
                    }

                    break;

                case 2:
                    Console.WriteLine();
                    Console.Write("Ingrese el id del empleado que desea actualizar: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    if (id >= 0 && id < EmpleadoPorHoraList.Count())
                    {
                        var EmpEncontrado = EmpleadoPorHoraList[id];

                        Console.WriteLine("NOTA: Si desea modificar el valor actual ingrese el nuevo valor de lo contrario dejarlo vacio");
                        Console.WriteLine();
                        Console.WriteLine($"Nombre: {EmpEncontrado.GetNombre()}");
                        Console.Write("Ingrese el nuevo valor: ");
                        nombre = Console.ReadLine();

                        if (string.IsNullOrEmpty(nombre))
                        {
                            nombre = EmpEncontrado.GetNombre();
                            Console.WriteLine("No se modifico el valor");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Valor modificado");
                            Console.WriteLine();
                        }

                        Console.WriteLine($"Apellido: {EmpEncontrado.GetApellido()}");
                        Console.Write("Ingrese el nuevo valor: ");
                        apellido = Console.ReadLine();

                        if (string.IsNullOrEmpty(apellido))
                        {
                            apellido = EmpEncontrado.GetApellido();
                            Console.WriteLine("No se modifico el valor");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Valor modificado");
                            Console.WriteLine();
                        }

                        Console.WriteLine($"Num. Seguro social: {EmpEncontrado.GetNss()}");
                        Console.Write("Ingrese el nuevo valor: ");
                        nss = Console.ReadLine();

                        if (string.IsNullOrEmpty(nss))
                        {
                            nss = EmpEncontrado.GetNss();
                            Console.WriteLine("No se modifico el valor");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Valor modificado");
                            Console.WriteLine();
                        }

                        Console.WriteLine($"Sueldo por hora: {EmpEncontrado.GetSueldo()}");
                        Console.Write("Ingrese el nuevo valor: ");
                        string sueldoHoraTemp = Console.ReadLine();

                        if (string.IsNullOrEmpty(sueldoHoraTemp))
                        {
                            sueldoHora = EmpEncontrado.GetSueldo();
                            Console.WriteLine("No se modifico el valor");
                            Console.WriteLine();
                        }
                        else
                        {
                            sueldoHora = Convert.ToDouble(sueldoHoraTemp);
                            Console.WriteLine("Valor modificado");
                            Console.WriteLine();
                        }

                        Console.WriteLine($"Horas trabajadas: {EmpEncontrado.GetHorasTrabajadas()}");
                        Console.Write("Ingrese el nuevo valor: ");
                        string horasTemp = Console.ReadLine();

                        if (string.IsNullOrEmpty(horasTemp))
                        {
                            horasTrabajadas = EmpEncontrado.GetHorasTrabajadas();
                            Console.WriteLine("No se modifico el valor");
                            Console.WriteLine();
                        }
                        else
                        {
                            horasTrabajadas = Convert.ToDouble(horasTemp);
                            Console.WriteLine("Valor modificado");
                            Console.WriteLine();
                        }

                        var temp1 = new CEmpleadoXhoras(nombre, apellido, nss, sueldoHora, horasTrabajadas);

                        EmpleadoPorHoraList[id] = temp1;

                        Console.WriteLine();
                        Console.WriteLine("Empleado actualizado correctamente :)");
                    }
                    else
                    {
                        Console.WriteLine("El id ingresado no contiene ningun empleado");
                    }

                    break;

                case 3:
                    Console.WriteLine();
                    Console.Write("Ingrese el id del empleado que desea actualizar: ");
                    id = Convert.ToInt32(Console.ReadLine());

                    if (id >= 0 && id < EmpleadoPorComisionList.Count())
                    {
                        var EmpEncontrado = EmpleadoPorComisionList[id];
                        Console.WriteLine();

                        Console.WriteLine("NOTA: Si desea modificar el valor actual ingrese el nuevo valor de lo contrario dejarlo vacio");
                        Console.WriteLine();
                        Console.WriteLine($"Nombre: {EmpEncontrado.GetNombre()}");
                        Console.Write("Ingrese el nuevo valor: ");
                        nombre = Console.ReadLine();

                        if (string.IsNullOrEmpty(nombre))
                        {
                            nombre = EmpEncontrado.GetNombre();
                            Console.WriteLine("No se modifico el valor");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Valor modificado");
                            Console.WriteLine();
                        }

                        Console.WriteLine($"Apellido: {EmpEncontrado.GetApellido()}");
                        Console.Write("Ingrese el nuevo valor: ");
                        apellido = Console.ReadLine();

                        if (string.IsNullOrEmpty(apellido))
                        {
                            apellido = EmpEncontrado.GetApellido();
                            Console.WriteLine("No se modifico el valor");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Valor modificado");
                            Console.WriteLine();
                        }

                        Console.WriteLine($"Num. Seguro social: {EmpEncontrado.GetNss()}");
                        Console.Write("Ingrese el nuevo valor: ");
                        nss = Console.ReadLine();

                        if (string.IsNullOrEmpty(nss))
                        {
                            nss = EmpEncontrado.GetNss();
                            Console.WriteLine("No se modifico el valor");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Valor modificado");
                            Console.WriteLine();
                        }

                        Console.WriteLine($"Tarifa comision: {EmpEncontrado.GetTarifaComision()}");
                        Console.Write("Ingrese el nuevo valor: ");
                        string tarifaTemp = Console.ReadLine();

                        if (string.IsNullOrEmpty(tarifaTemp))
                        {
                            tarifa = EmpEncontrado.GetTarifaComision();
                            Console.WriteLine("No se modifico el valor");
                            Console.WriteLine();
                        }
                        else
                        {
                            tarifa = Convert.ToDouble(tarifaTemp);
                            Console.WriteLine("Valor modificado");
                            Console.WriteLine();
                        }

                        Console.WriteLine($"Ventas brutas: {EmpEncontrado.GetVentasBrutas()}");
                        Console.Write("Ingrese el nuevo valor: ");
                        string ventasTemp = Console.ReadLine();

                        if (string.IsNullOrEmpty(ventasTemp))
                        {
                            ventasB = EmpEncontrado.GetVentasBrutas();
                            Console.WriteLine("No se modifico el valor");
                            Console.WriteLine();
                        }
                        else
                        {
                            ventasB = Convert.ToDouble(ventasTemp);
                            Console.WriteLine("Valor modificado");
                            Console.WriteLine();
                        }

                        var temp2 = new CEmpleadoPorComision(nombre, apellido, nss, tarifa, ventasB);

                        EmpleadoPorComisionList[id] = temp2;

                        Console.WriteLine();
                        Console.WriteLine("Empleado actualizado correctamente :)");
                    }
                    else
                    {
                        Console.WriteLine("El id ingresado no contiene ningun empleado");
                    }

                    break;

                case 4:
                    Console.WriteLine();
                    Console.Write("Ingrese el id del empleado que desea actualizar: ");
                    id = Convert.ToInt32(Console.ReadLine());

                    if (id >= 0 && id < EmpleadoAsalariadoPorComisionList.Count())
                    {
                        var EmpEncontrado = EmpleadoAsalariadoPorComisionList[id];

                        Console.WriteLine();
                        Console.WriteLine("NOTA: Si desea modificar el valor actual ingrese el nuevo valor de lo contrario dejarlo vacio");
                        Console.WriteLine();
                        Console.WriteLine($"Nombre: {EmpEncontrado.GetNombre()}");
                        Console.Write("Ingrese el nuevo valor: ");
                        nombre = Console.ReadLine();

                        if (string.IsNullOrEmpty(nombre))
                        {
                            nombre = EmpEncontrado.GetNombre();
                            Console.WriteLine("No se modifico el valor");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Valor modificado");
                            Console.WriteLine();
                        }

                        Console.WriteLine($"Apellido: {EmpEncontrado.GetApellido()}");
                        Console.Write("Ingrese el nuevo valor: ");
                        apellido = Console.ReadLine();

                        if (string.IsNullOrEmpty(apellido))
                        {
                            apellido = EmpEncontrado.GetApellido();
                            Console.WriteLine("No se modifico el valor");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Valor modificado");
                            Console.WriteLine();
                        }

                        Console.WriteLine($"Num. Seguro social: {EmpEncontrado.GetNss()}");
                        Console.Write("Ingrese el nuevo valor: ");
                        nss = Console.ReadLine();

                        if (string.IsNullOrEmpty(nss))
                        {
                            nss = EmpEncontrado.GetNss();
                            Console.WriteLine("No se modifico el valor");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Valor modificado");
                            Console.WriteLine();
                        }

                        Console.WriteLine($"Sueldo semanal: {EmpEncontrado.SalarioSemanal()}");
                        Console.Write("Ingrese el nuevo valor: ");
                        string sueldoTemp = Console.ReadLine();

                        if (string.IsNullOrEmpty(sueldoTemp))
                        {
                            sueldo = EmpEncontrado.SalarioSemanal();
                            Console.WriteLine("No se modifico el valor");
                            Console.WriteLine();
                        }
                        else
                        {
                            sueldo = Convert.ToDouble(sueldoTemp);
                            Console.WriteLine("Valor modificado");
                            Console.WriteLine();
                        }

                        Console.WriteLine($"Tarifa comision: {EmpEncontrado.GetTarifaComision()}");
                        Console.Write("Ingrese el nuevo valor: ");
                        string tarifaTemp = Console.ReadLine();

                        if (string.IsNullOrEmpty(tarifaTemp))
                        {
                            tarifa = EmpEncontrado.GetTarifaComision();
                            Console.WriteLine("No se modifico el valor");
                            Console.WriteLine();
                        }
                        else
                        {
                            tarifa = Convert.ToDouble(tarifaTemp);
                            Console.WriteLine("Valor modificado");
                            Console.WriteLine();
                        }

                        Console.WriteLine($"Ventas brutas: {EmpEncontrado.GetVentasBrutas()}");
                        Console.Write("Ingrese el nuevo valor: ");
                        string ventasTemp = Console.ReadLine();

                        if (string.IsNullOrEmpty(ventasTemp))
                        {
                            ventasB = EmpEncontrado.GetVentasBrutas();
                            Console.WriteLine("No se modifico el valor");
                            Console.WriteLine();
                        }
                        else
                        {
                            ventasB = Convert.ToDouble(ventasTemp);
                            Console.WriteLine("Valor modificado");
                            Console.WriteLine();
                        }

                        var temp3 = new CEmpleadoAsalariadoPorComision(nombre, apellido, nss, sueldo, ventasB, tarifa);

                        EmpleadoAsalariadoPorComisionList[id] = temp3;

                        Console.WriteLine();
                        Console.WriteLine("Empleado actualizado correctamente :)");
                    }
                    else
                    {
                        Console.WriteLine("El id ingresado no contiene ningun empleado");
                    }

                    break;
                case 5: return false;
                default:
                    Console.WriteLine($"opcion: {opcion} no es compatible con ninguna de las opciones disponibles :/");
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("¿Desea actualizar otro empleado? ");
            Console.WriteLine("1- SI");
            Console.WriteLine("2- NO");
            Console.Write("Ingrese el # de la opcion que desea: ");
            salir = Convert.ToInt32(Console.ReadLine());

            if (salir == 1)
            {
                Console.Clear();
                return true;
            }
            else
            {
                Console.Clear();
                return false;
            }


        }

        static void ObtenerTodosPagoSemanales()
        {
            Console.Clear();
            int count = 0;
            Console.WriteLine("===========================================");
            Console.WriteLine("LISTA DE EMPLEADOS ASALARIADOS");
            Console.WriteLine("===========================================");
            Console.WriteLine();
            Console.WriteLine("Formula para calcular los pagos semanales:");
            Console.WriteLine("Pago semanal = salarioSemanal");
            Console.WriteLine();
            Console.WriteLine();

            foreach(var item in EmpleadoAsalariadoList)
            {
                Console.WriteLine($"id: {count}");
                Console.WriteLine($"Nombre: {item.GetNombre()}");
                Console.WriteLine($"Apellido: {item.GetApellido()}");
                Console.WriteLine($"Numero Seguro Social: {item.GetNss()}");
                Console.WriteLine($"Salario semanal: {item.SalarioSemanal()}");
                Console.WriteLine();
                count++;
            }
            count = 0;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===========================================");
            Console.WriteLine("LISTA DE EMPLEADOS POR HORA");
            Console.WriteLine("===========================================");
            Console.WriteLine();
            Console.WriteLine("Formula para calcular los pagos semanales:");
            Console.WriteLine("Si horasTrabajadas <= 40");
            Console.WriteLine("Pago = sueldoPorHora * horasTrabajadas");
            Console.WriteLine();
            Console.WriteLine("Si horasTrabajadas > 40");
            Console.WriteLine("Pago = (sueldoPorHora * 40) +");
            Console.WriteLine("(sueldoPorHora * 1.5 * (horasTrabajadas - 40))");
            Console.WriteLine();
            Console.WriteLine();

            foreach (var item in EmpleadoPorHoraList)
            {
                Console.WriteLine($"id: {count}");
                Console.WriteLine($"Nombre: {item.GetNombre()}");
                Console.WriteLine($"Apellido: {item.GetApellido()}");
                Console.WriteLine($"Numero Seguro Social: {item.GetNss()}");
                Console.WriteLine($"Sueldo por hora: {item.GetSueldo()}");
                Console.WriteLine($"Horas trabajadas: {item.GetHorasTrabajadas()}");
                Console.WriteLine($"Salario semanal: {item.GetSalarioSemanal()}");
                Console.WriteLine();
                count++;
            }
            count = 0;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===========================================");
            Console.WriteLine("LISTA DE EMPLEADOS POR COMISION");
            Console.WriteLine("===========================================");
            Console.WriteLine();
            Console.WriteLine("Formula para calcular los pagos semanales:");
            Console.WriteLine("Pago semanal = ventasBrutas * tarifaComision");
            Console.WriteLine();
            Console.WriteLine();

            foreach (var item in EmpleadoPorComisionList)
            {
                Console.WriteLine($"id: {count}");
                Console.WriteLine($"Nombre: {item.GetNombre()}");
                Console.WriteLine($"Apellido: {item.GetApellido()}");
                Console.WriteLine($"Numero Seguro Social: {item.GetNss()}");
                Console.WriteLine($"Ventas brutas: {item.GetVentasBrutas()}");
                Console.WriteLine($"Tarifa de comision: {item.GetTarifaComision()}");
                Console.WriteLine($"Salario semanal: {item.GetSalarioSemanal()}");
                Console.WriteLine();
                count++;
            }
            count = 0;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===========================================");
            Console.WriteLine("LISTA DE EMPLEADOS ASALARIADOS POR COMISION");
            Console.WriteLine("===========================================");
            Console.WriteLine();
            Console.WriteLine("Formula para calcular los pagos semanales:");
            Console.WriteLine("Pago semanal =");
            Console.WriteLine("(ventasBrutas * tarifaComision) +");
            Console.WriteLine("salarioBase +");
            Console.WriteLine("(salarioBase * 0.10)");
            Console.WriteLine();
            Console.WriteLine();

            foreach (var item in EmpleadoAsalariadoPorComisionList)
            {
                Console.WriteLine($"id: {count}");
                Console.WriteLine($"Nombre: {item.GetNombre()}");
                Console.WriteLine($"Apellido: {item.GetApellido()}");
                Console.WriteLine($"Numero Seguro Social: {item.GetNss()}");
                Console.WriteLine($"Ventas brutas: {item.GetVentasBrutas()}");
                Console.WriteLine($"Tarifa de comision: {item.GetTarifaComision()}");
                Console.WriteLine($"Salario semanal: {item.GetSalarioSemanal()}");
                Console.WriteLine();
                count++;
            }
            count = 0;

            Console.WriteLine();
            Console.WriteLine("Presione enter para volver al menu...");
            Console.ReadLine();

        }
    }
}
