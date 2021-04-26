using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        private List<Botella> botellas = new List<Botella>();
        private int espaciosTotales;
        private Cantina singleton;

        private Cantina(int espacios)
        {
            this.espaciosTotales = espacios;
        }

        //public Cantina GetCantina(int espacios)
        //{
        //    return Cantina;
        //}

        public static bool operator + (Cantina c, Botella b)
        {
            bool output = true;
            if (c.espaciosTotales > 0)
            {
                output = true;
                c.botellas.Add(b);
            }
            return output;
        }

        public List<Botella> Botellas
        {
            get
            {
                return this.botellas;
            }
        }           

    }
}
