using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstates {
        public static void Executar() {
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area é :" + area);

            //Exemplo de variavel Booleana.
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo :" + estaChovendo);


            byte idade = 38;
            Console.WriteLine("A idade é:" + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols é: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("O sálario é: " + salario);
        }
    }
}
