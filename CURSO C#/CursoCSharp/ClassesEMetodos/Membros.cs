﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Carlos S. Mori";
            sicrano.Idade = 38;
            Console.WriteLine($"{ sicrano.Nome} tem { sicrano.Idade} anos.");
        }

    }
}
