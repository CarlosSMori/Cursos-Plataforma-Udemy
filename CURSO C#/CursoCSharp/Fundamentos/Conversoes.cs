using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {

            // Usando Conversão de Valores Implicíto.
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            // Usando Conversão de Valores Explicito.
            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            // Usando a Classe Parse.
            Console.WriteLine("Digite Sua Idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            // Usando a Classe Convert.ToInt32.
            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            // Usando a Classe TryParse.
            Console.Write("Digite O Primeiro Número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Resultado 1: {0}", numero1);

            // Usando a Classe TryParse.
            Console.Write("Digite O Segundo Número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}", numero2);
        }
    }
}
