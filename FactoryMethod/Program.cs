﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string [] args)
        {
            BebidaEmbriagante oBebida = Creador.CreadorBebida(Creador.VINO_TINTO);
            Console.WriteLine(oBebida.CuantoMeEmbriagaPorHora());
        }
    }
}
