using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            // F1 Usado para o Valor com uma casa decimal.
            Console.WriteLine(valor.ToString("F1"));

            // C Usado para valor Monetário.
            Console.WriteLine(valor.ToString("C"));

            // Usado para formatar em Porcentagem.
            Console.WriteLine(valor.ToString("P"));

            // Usado para formatar em número determinado de casa décimal.
            Console.WriteLine(valor.ToString("#.###"));

            // Usado para formatar em moeda Brasileira.
            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C3", cultura));
           
            // Usado para formatar em moeda Américana
            CultureInfo culture = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C3", culture));

            // Usado para completar com zeros á esquerda sendo o numero, número da casas.
            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
