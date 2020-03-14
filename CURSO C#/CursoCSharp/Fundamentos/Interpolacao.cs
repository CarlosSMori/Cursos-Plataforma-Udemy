using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Interpolacao {
        public static void Executar() {
            string nome  = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            // Interpolação de forma concatenada.
            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + ".");

            // Interpolação por substituição de índices chaves.
            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco);

            // Interpolação por acrescimo do dolar.
            Console.WriteLine($"A marca {marca} é legal");
            Console.WriteLine($" 1 + 1 = {1+1}!");
        }
    }
}
