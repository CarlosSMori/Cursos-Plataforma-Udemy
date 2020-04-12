using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresUnarios {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            // Valor Pós-Fixado
            numero1++;
            Console.WriteLine(numero1);

            // Valor Pré-Fixado
            --numero1;
            Console.WriteLine(numero1);

            // Ele Decrementa Do Número2 Depois Comparara Com Número1 E Só Depois Incrementara Número1
            Console.WriteLine(numero1++ == --numero2);
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
