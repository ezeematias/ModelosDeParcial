using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        private const int MEDIDA = 330;
        private Tipo tipo;

        public Cerveza(int capacidadML, string marca, int contenidoML) : base(capacidadML, contenidoML, marca)
        {

        }

        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML) : this(capacidadML, marca, contenidoML)
        {

        }

        protected new string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Marca:{marca}\n");
            sb.Append($"Capacidad en ML:{capacidadML}\n");
            sb.Append($"Contenido en ML:{contenidoML}\n");
            return sb.ToString();
        }

        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return Tipo.Vidrio;
        }

        public override int ServirMedida()
        {
            return 0;
        }

    }
}
