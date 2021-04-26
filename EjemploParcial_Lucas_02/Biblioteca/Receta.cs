using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Receta
    {

        private int capacidadDelContenedor;
        private List<Ingrediente> ingredientes;
        private static Tipo preparacion;

        public Tipo TipoDePreparacion
        {
            set { preparacion = value; }
        }

        private Receta()
        {
            ingredientes = new List<Ingrediente>();
        }

        static Receta()
        {
            preparacion = Tipo.Clasica;
        }

        public Receta(int capacidad) : this()
        {
            this.capacidadDelContenedor = capacidad;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Receta: {preparacion}");
            sb.AppendLine($"Capacidad libre: {this.CapacidadLibre()}");
            sb.AppendLine($"Capacidad total: {this.capacidadDelContenedor}");
            foreach (Ingrediente item in ingredientes)
            {
                sb.AppendLine(item.Informacion());
            }
            return sb.ToString();
        }

        private int CapacidadLibre()
        {
            int output = this.capacidadDelContenedor;
            foreach (Ingrediente item in ingredientes)
            {
                output -= item.Cantidad;
            }
            return output;
        }
        private int CapacidadLibre(Ingrediente planta)
        {
            return CapacidadLibre() - planta.Cantidad;
        }

        public static bool operator +(Receta receta, Ingrediente ingrediente)
        {
            bool output = false;
            if ( receta.CapacidadLibre(ingrediente) >= 0)
            {
                receta.ingredientes.Add(ingrediente);
                output = true;
            }
            return output;
        }

        public enum Tipo
        {
            Clasica,
            Especial
        }
    }
}
