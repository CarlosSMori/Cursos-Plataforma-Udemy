using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            // F1 Usado para arredondar o Valor.
            Console.WriteLine(valor.ToString("F1"));

            // C Usado para valor Monetário.
            Console.WriteLine(valor.ToString("C"));

            // Usado para formatar em Porcentagem.
            Console.WriteLine(valor.ToString("P"));


            Console.WriteLine(valor.ToString("#.##"));

        }
    }
}
