using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Campo
    {
        private int alimentoDisponible;
        private List<Animal> animales;
        private static Tipo servicio;
        private Campo ()
        {
            animales = new List<Animal>();
        }

        static Campo ()
        {
            servicio = Tipo.Engorde;
        }

        public Campo (int alimento) :this()
        {
            this.alimentoDisponible = alimento;
        }

        public Tipo TipoServicio
        {
            set { servicio = value; }

        }

        private int AlimentoComprometido()
        {
            int consumo = 0;
            foreach (Animal item in animales)
            {
                consumo += item.KilosAlimento;
            }            
            return consumo;
        }
        private int AlimentoComprometido(Animal animal)
        {           
            return AlimentoComprometido() + animal.KilosAlimento;
        }

        public static bool operator + (Campo campo, Animal animal)
        {
            bool output = false;
            if(campo.AlimentoComprometido(animal) <= campo.alimentoDisponible ) 
            {
                campo.animales.Add(animal);
                output = true;
            }
            return output;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Servicio de campo: {servicio}");
            sb.AppendLine($"Alimento comprometio {this.AlimentoComprometido()} de {this.alimentoDisponible}");
            foreach (Animal item in animales)
            {
                sb.AppendLine(item.Datos());
            }
            return sb.ToString();
        }

        public enum Tipo
        {
            Pastoreo,
            Engorde
        }

    }
}
