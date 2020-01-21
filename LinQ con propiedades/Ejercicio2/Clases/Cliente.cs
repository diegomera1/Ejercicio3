using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Clases
{
    public class Cliente
    {
        //Constructor
        public Cliente(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        //Propiedades
        #region
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        #endregion
    }
}
