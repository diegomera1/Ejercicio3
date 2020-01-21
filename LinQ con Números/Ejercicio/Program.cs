using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0; int suma = 0;
            //Generar una lista con 50 números aleatorios.
            #region
            List<Metodos> numeros = new List<Metodos>();
            var seed = Environment.TickCount;
            var random = new Random(seed);
            for (int i = 0; i < 50; i++)
            {
                numeros.Add(new Metodos(random.Next(0, 100)));
            }

            Console.WriteLine("Lista de números");
            foreach (var item in numeros)
            {
                Console.WriteLine("{0}", item.Numero);
            }
            Console.WriteLine();
            #endregion

            //Mostrar por consola todos los números primos.
            #region
            IEnumerable<Metodos> listaprimos =
                from numero in numeros
                where numero.NumerosPrimos() <= 2
                select numero;

            Console.WriteLine("Lista de números primos");
            foreach (var nprimos in listaprimos)
            {
                Console.WriteLine("{0}", nprimos.Numero);
            }
            Console.WriteLine();
            #endregion

            //Mostrar por consola la suma de todos los elementos.        
            #region
            Console.WriteLine("Suma de elementos");
            Console.WriteLine(numeros.Sum(x => x.Numero));
            Console.WriteLine();
            #endregion

            //Generar una nueva lista con el cuadrado de los números.
            #region
            Console.WriteLine("Lista del cuadrado de los números");
            foreach (var item in numeros)
            {
                Console.WriteLine("{0}", item.Cuadrados());
            }
            Console.WriteLine();
            #endregion

            //Generar una nueva lista con los números que no son primos.
            #region
            IEnumerable<Metodos> listanoprimos =
                from numero in numeros
                where numero.NumerosPrimos() != 2
                select numero;

            Console.WriteLine("Lista de números no primos");
            foreach (var nnprimos in listanoprimos)
            {
                Console.WriteLine("{0}", nnprimos.Numero);
            }
            Console.WriteLine();
            #endregion

            //Obtener el promedio de todos los números mayores a 50.
            #region
            IEnumerable<Metodos> mayoresa50 = 
                (numeros.Where(x => x.Numero > 50));
               
            Console.WriteLine("Promedio de los números mayores a 50");
            Console.WriteLine(mayoresa50.Average(x => x.Numero));
            Console.WriteLine();
            #endregion

            //Contar en la lista la cantidad de números pares e impares. 
            //Este problema debe resolverse en una sentencia o en una sola consulta.
            #region
            IEnumerable<Metodos> listapar =
                numeros.Where(x => x.Numero % 2 == 0);

            Console.WriteLine("Cantidad de números pares");
            Console.WriteLine(listapar.Count());
            Console.WriteLine();
            Console.WriteLine("Cantidad de números impares");
            Console.WriteLine(numeros.Count() - listapar.Count());
            Console.WriteLine();

            #endregion

            //Mostrar por consola cada elemento y la cantidad de veces que se repite en la lista.
            #region
            Console.WriteLine("Números y cantidad de veces que se repiten");
            foreach (var item in numeros)
            {
                contador = 0;
                for (int i = 0; i < 1; i++)
                {
                    foreach (var num in numeros)
                    {
                        if (item.Numero == num.Numero)
                        {
                            contador++;
                        }
                    }
                }
                Console.WriteLine("{0}", item.Numero+"---"+ contador);
            }
            Console.WriteLine();
            #endregion

            //Mostrar en consola los elementos de forma descendente.
            #region
            IEnumerable<Metodos> ordendescendente =
               from numero in numeros
               orderby numero.Numero descending
               select numero;

            Console.WriteLine("Lista de números en orden descendente");
            foreach (Metodos item in ordendescendente)
            {
                Console.WriteLine("{0}", item.Numero);
            }
            Console.WriteLine();

            #endregion

            //Mostrar en consola los números únicos (no se repiten).
            #region
            Console.WriteLine("Números únicos en la lista");
            foreach (var item in numeros)
            {
                contador = 0;
                for (int i = 0; i < 1; i++)
                {
                    foreach (var num in numeros)
                    {
                        if (item.Numero == num.Numero)
                        {
                            contador++;
                        }
                    }
                    if (contador == 1)
                    {
                        Console.WriteLine("{0}", item.Numero);
                        suma = suma + item.Numero;
                    }
                }
            }
            Console.WriteLine();
            #endregion

            //Sumar todos los números únicos de la lista.
            #region
            Console.WriteLine("Suma de los números únicos en la lista");
            Console.WriteLine(suma);
            Console.WriteLine();

            #endregion


            Console.ReadKey();
        }
    }
}
