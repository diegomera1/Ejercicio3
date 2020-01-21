using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    public class Metodos
    {
        //Propiedad 
        #region
        private int numero;

        public Metodos(int numero)
        {
            Numero = numero;
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        #endregion

        //Metodo para hayar números primos
        #region
        public int NumerosPrimos()
        {
            int contador = 0;
            for (int i = 1; i <= this.Numero; i++)
            {
                int mod = this.Numero % i;
                if (mod == 0)
                    contador++;
            }
            return contador;
        }
        #endregion

        //Generar una nueva lista con el cuadrado de los números.
        #region
        public int Cuadrados()
        {
            int cuadrado = 0;
            cuadrado = this.Numero * this.Numero;
            return cuadrado;
        }
        #endregion

        //Contar en la lista la cantidad de números pares e impares. 
        //Este problema debe resolverse en una sentencia o en una sola consulta.
        #region
        public int NumerosPares()
        {
            int par = 0;
            int mod = this.Numero % 2;
            if (mod == 0)
            {
                par++;
            }
            return par;
        }
        #endregion

    }
}




