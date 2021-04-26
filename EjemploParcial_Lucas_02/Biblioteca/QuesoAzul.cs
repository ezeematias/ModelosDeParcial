using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class QuesoAzul : Ingrediente
    {
        private Procedencia procedencia;

        public QuesoAzul(string descripcion, int cantidad) : base(cantidad, descripcion)
        { 
            
        }

        public QuesoAzul(string descripcion, int cantidad, Procedencia procedencia) : this(descripcion, cantidad)
        {
            this.procedencia = procedencia;
        }

        public override string Proceso
        {
            get { return "desgranar"; }
        }
        public override string UnidadDeMedida
        {
            get { return "gramos"; }
        }

        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Informacion());
            sb.AppendLine($"Procedente de {this.procedencia}");
            return sb.ToString();
        }

        public enum Procedencia
        {
            Francia,
            Argentina,
            Italia
        }
    }

}
