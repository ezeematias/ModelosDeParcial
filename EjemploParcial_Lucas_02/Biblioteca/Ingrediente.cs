using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Ingrediente
    {
        private int cantidad;
        private string descripcion;

        public Ingrediente(int cantidad, string descripcion)
        {
            this.cantidad = cantidad;
            this.descripcion = descripcion;
        }

        public int Cantidad
        {
            get { return this.cantidad; }
        }

        public abstract string Proceso { get; }
        public abstract string UnidadDeMedida { get; }


        public virtual string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("{0} en una cantidad de {1} {2}", this.descripcion, this.Cantidad, this.UnidadDeMedida));
            sb.AppendLine($"Procesar {this.Proceso}");
            return sb.ToString();
        }
    }
}
