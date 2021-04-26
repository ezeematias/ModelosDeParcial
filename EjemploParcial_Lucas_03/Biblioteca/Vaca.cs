using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Vaca : Animal
    {
        Clasificacion clasificacion;

        public Vaca (string nombre, int kilosAlimento):base(kilosAlimento,nombre)
        {

        }

        public Vaca(string nombre, int kilosAlimento, Clasificacion clasificacion) : this(nombre,kilosAlimento)
        {
            this.clasificacion = clasificacion;
        }

        public override bool ComeBalanceado
        {
            get { return true; }
        }

        public override bool ComePasto
        {
            get { return true; }
        }

        public override string Datos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Datos());
            sb.AppendLine($"Clasificada como: {this.clasificacion}");
            return sb.ToString();

        }

        public enum Clasificacion
        {
            Lechera,
            Normando,
            Pasiega,
            HolandoArgentina,
            Tudanca
        }
    }
}
