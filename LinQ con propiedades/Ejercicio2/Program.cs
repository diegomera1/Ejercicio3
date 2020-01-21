using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio2.Clases;
namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar 10 instancias
            #region
            List<Cliente> clientes = new List<Cliente>
            {
                new Cliente(01, "Cristhian Bacusoy"),
                new Cliente(02, "Diego Mera"),
                new Cliente(03, "Guillermo Calvache"),
                new Cliente(04, "Wilber Zelaya"),
                new Cliente(05, "Juan Manuel"),
                new Cliente(06, "Andres Vera"),
                new Cliente(07, "Luis Mera"),
                new Cliente(08, "Carlos Andrade"),
                new Cliente(09, "Sofia Velez"),
                new Cliente(010, "Camila Muñoz"),
            };
            List<Factura> facturas = new List<Factura>
            {
                new Factura("golosinas", 01, new DateTime(2020, 01, 18),240),
                new Factura("comida ", 02, new DateTime(2020, 01, 16), 260),
                new Factura("bebidas energéticas", 03, new DateTime(2019, 01, 14), 26),
                new Factura("Preservativos", 04, new DateTime(2019, 01, 08), 12),
                new Factura("Plato", 05, new DateTime(2020, 01, 11), 19),
                new Factura("Plato", 06, new DateTime(2020, 01, 12), 19),
                new Factura("artículos de limpieza", 07, new DateTime(2020, 04, 16), 150),
                new Factura("pastillas y remedios", 08, new DateTime(2019, 05, 17), 148),
                new Factura("útiles escolares", 09, new DateTime(2019, 01, 22), 167),
                new Factura("Platos sillas y mesas", 10, new DateTime(2016, 07, 21), 179),

            };

            var ClientesFactura =
                from factura in facturas
                join cliente in clientes on
                factura.ID equals cliente.Id
                select new
                {
                    nombre = cliente.Nombre,
                    observacion = factura.Observacion,
                    total = factura.Total,
                    fecha = factura.Fecha
                };
            Console.WriteLine("Lista de clientes y compras realizadas");
            foreach (var item in ClientesFactura)
            {
                Console.WriteLine("Nombre: {0}          Observación: {1}         Total: {2}       Fecha: {3}", item.nombre, item.observacion, item.total, item.fecha);
            }
            Console.WriteLine();
            #endregion
            //Consultar los 3 clientes con mayor números de ventas
            #region
            Console.WriteLine("Los primeros clientes con mayor monto.");
            var mayoresventas =
                from cliente in ClientesFactura
                orderby cliente.total descending
                select cliente;
            foreach (var item in mayoresventas.Take(3))
            {
                Console.WriteLine("Nombre: {0}  Monto: {1}", item.nombre, item.total);
            }
            Console.WriteLine();
            #endregion 
            //Consultar los 3 clientes con menor números de ventas
            #region
            Console.WriteLine("Los primeros clientes con menor monto.");
            foreach (var item in mayoresventas.Skip(7))
            {
                Console.WriteLine("Nombre: {0}  Total: {1}", item.nombre, item.total);
            }
            Console.WriteLine();
            #endregion
            //Consultar el cliente con más ventas realizadas
            #region
            Console.WriteLine("Cliente con mayor ventas realizadas");
            foreach (var item in mayoresventas.Take(1))
            {
                Console.WriteLine("Nombre: {0}          Cantidad de ventas Realizadas: {1}", item.nombre, item.total);
            }
            Console.WriteLine(ClientesFactura.Max(x => x.total)); 
            Console.WriteLine();
            #endregion
            //Cada cliente y su cantidad de ventas realizadas
            #region
            Console.WriteLine("Cada cliente y su cantidad de ventas realizadas");
            foreach (var item in ClientesFactura)
            {
                Console.WriteLine("Nombre: {0}          Cantidad de ventas Realizadas: {1}", item.nombre, item.total);
            }
            Console.WriteLine();
            #endregion
            //Ventas realizadas en el año 2019
            #region
            Console.WriteLine("Ventas realizadas en el 2019");
            var ventas2019 =
                from fecha in ClientesFactura
                where fecha.fecha.Year == 2019
                select fecha;
            foreach (var item in ventas2019)
            {
                Console.WriteLine("Nombre: {0}          Ventas Realizadas:{1}       Fecha: {2}", item.nombre, item.observacion, item.fecha);
            }
            Console.WriteLine();
            #endregion
            //Venta más antigua
            #region
            Console.WriteLine("Venta más antigua");
            var ventaantigua =
                from venta in ClientesFactura
                orderby venta.fecha ascending 
                select venta;
            foreach (var item in ventaantigua.Take(1))
            {
                Console.WriteLine("Nombre: {0}          Ventas Realizadas:{1}       Fecha: {2}", item.nombre, item.observacion, item.fecha);
            }
            Console.WriteLine();
            #endregion
            //Los clientes que tengan una venta cuya observación comience con "Plato"
            #region
            Console.WriteLine("Observación con plato");
            var plato =
                from cliente in ClientesFactura
                where cliente.observacion.ToUpper()[4].Equals("plato".ToUpper()[4])
                select cliente;
            foreach (var item in plato)
            {
                Console.WriteLine("Nombre: {0}         Observación: {1}", item.nombre, item.observacion);
            }
            Console.WriteLine();
            #endregion
            Console.ReadKey();
        }
    }
}
