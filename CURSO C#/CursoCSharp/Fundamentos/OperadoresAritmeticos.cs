using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritmeticos {
        public static void Executar() {

            // preço com desconto.
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var TotalComDesconto = total - (total * desconto);
            Console.WriteLine("O preço final é {0}", TotalComDesconto.ToString("C"));

            // IMC
            double peso = 75.5;
            double altura = 1.70;
            double imc = peso / (altura * altura);
            Console.WriteLine("O IMC é : {0}", imc.ToString("F1"));
            double imc2 = peso / Math.Pow(altura, 2);
            Console.WriteLine($"O IMC é : {imc2}.");

            // Número par / Impar.
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par , par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);

        }
    }
}
