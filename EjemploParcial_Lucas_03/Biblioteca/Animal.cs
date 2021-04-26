using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Animal
    {
        private int kilosAlimento;
        private string nombre;

        public Animal(int kilosAlimento, string nombre)
        {
            this.kilosAlimento = kilosAlimento;
            this.nombre = nombre;
        }

        public abstract bool ComeBalanceado { get; }
        public abstract bool ComePasto { get; }

        public int KilosAlimento
        {
            get { return this.kilosAlimento; }
        }

        public virtual string Datos()
        {
            string auxComerPasto = "SI";
            string auxComerBalanceado = "SI";
            if (this.ComeBalanceado == false)
                auxComerBalanceado = "NO";
            if (this.ComePasto == false)
                auxComerPasto = "NO";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("{0} come {1}", this.nombre, this.KilosAlimento));
            sb.AppendLine($"Consume balanceado: {auxComerBalanceado}");             
            sb.AppendLine($"Consume pasto: {auxComerPasto}");
            return sb.ToString();
        }






    }


}
