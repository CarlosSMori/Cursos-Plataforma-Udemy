using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public class CalculadoraEstatica{

        public  int Somar(int a, int b) {
            return a + b;
        }

        public static int Multilicar(int a, int b) {
            return a * b;
        }

        public static int Subtrair(int a, int b) {
            return a - b;
        }
    }
    class MetodoEstaticos {
        public static void Executar() {
            var resultado = CalculadoraEstatica.Multilicar(2,2);
            Console.WriteLine("Resultado da Multiplicação é: {0}",resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine("Resultado da Soma é: " + calc.Somar(4, 2));

            Console.WriteLine("Resultado da Subtração é: " + CalculadoraEstatica.Subtrair(12,10));
           
        
        }
    }
}
