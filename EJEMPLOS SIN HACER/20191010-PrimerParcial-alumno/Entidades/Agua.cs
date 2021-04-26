using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        private const int MEDIDA = 400;

        public Agua(int capacidadML, string marca, int contenidoML) : base (capacidadML, contenidoML, marca)
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
        public int ServirMedida(int medida)
        {
            return ServirMedida();
        }

        
        public override int ServirMedida()
        {
            return 0;
        }
        

    }
}
