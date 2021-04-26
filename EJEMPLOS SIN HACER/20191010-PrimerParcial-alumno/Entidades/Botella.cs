using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        protected Botella(int capacidadML, int contenidoML, string marca)
        {
            this.capacidadML = capacidadML;
            this.marca = marca;
            if (capacidadML < contenidoML)
                this.contenidoML = capacidadML;
            else
                this.contenidoML = contenidoML;
        }

        protected string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Marca:{marca}\n");
            sb.Append($"Capacidad en ML:{capacidadML}\n");
            sb.Append($"Contenido en ML:{contenidoML}\n");
            return sb.ToString();
        }

        public abstract int ServirMedida();


        public override string ToString()
        {
            return GenerarInforme();
        }

        public enum Tipo
        {
            Plastico,
            Vidrio
        };


        public int CapacidadLitros
        {
            get
            {
                return this.capacidadML/1000;
            }
        }

        public int Contenido
        {
            get
            {
                return this.contenidoML;
            }
            set
            {
                this.contenidoML = value;
            }
        }

        public float PorcentajContenido
        {
            get
            {
                return this.contenidoML / this.capacidadML * 100;
            }
        }

        



    }
}
