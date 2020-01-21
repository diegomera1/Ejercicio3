using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Clases
{
    public class Factura
    {
        //Constructor
        public Factura(string observacion, int idcliente, DateTime fecha, int total)
        {
            Observacion = observacion;
            Fecha = fecha;
            Total = total;
            ID = idcliente;
        }

        //Propiedades
        #region
        private string observacion;  
        public string Observacion
        {
            get { return observacion; }
            set { observacion = value; }
        }

        private int idcliente;

        public int ID
        {
            get { return idcliente; }
            set { idcliente = value; }
        }

        private DateTime fecha;
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private int total;

        public int Total
        {
            get { return total; }
            set { total = value; }
        }

        #endregion
    }
}
