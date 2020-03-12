using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstates {
        public static void Executar() {

            // área da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            // fórmula para cálculo da área do círculo
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area é : " + area);

            // Exemplo de váriavel Booleana.
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo é : " + estaChovendo);

            // Exemplo de váriavel do tipo byte.
            byte idade = 38;
            Console.WriteLine("A idade é : " + idade);

            // Exemplo de váriavel do tipo Byte com sinal.
            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols é : " + saldoDeGols);

            // Exemplo de váriavel do tipo Short.
            short salario = short.MaxValue;
            Console.WriteLine("O sálario é : " + salario);

            // Exemplo de váriavel Inteiro mais usado de todos os Inteiros.
            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor int é : " + menorValorInt);
            
            // Exemplo de váriavel do Inteiros sem Sinal.
            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("A População Brasileira é : " + populacaoBrasileira);

            // Exemplo de váriavel Inteiro do tipo Longo.
            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Long é : " + menorValorLong);

            // Exemplo de váriavel Inteiro longo sem sinal.
            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("A população mundial é : " + populacaoMundial);

            // Exemplo de váriavel do tipo Reais com pontos flutuantes.
            float precoComputador = 1229.90f;
            Console.WriteLine("O preço do computador é : " + precoComputador);

            // Exemplo de váriavel do tipo Reais Double do pontos flutuantes Mais usado dos Reais..
            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine("O valor Apple é : " + valorDeMercadoDaApple);

            // Exemplo de váriavel do tipo Decimal.
            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("A Distancia entre Estrelas : " + distanciaEntreEstrelas);

            // Exemplo de váriavel do tipo Caracteres.
            char letra = 'A';
            Console.WriteLine("A letra é " + letra);

            // Exemplo de váriavel do tipo texto.
            string texto = "Seja Bem Vindo!";
            Console.WriteLine(texto);
        }
    }
}
