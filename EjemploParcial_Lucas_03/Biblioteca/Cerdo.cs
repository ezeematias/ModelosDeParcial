﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cerdo : Animal
    {
        public Cerdo (string nombre, int kilosAlimento) : base(kilosAlimento, nombre)
        {

        }
        public override bool ComeBalanceado
        {
            get { return true; }
        }

        public override bool ComePasto
        {
            get { return false; }
        }


    }
}