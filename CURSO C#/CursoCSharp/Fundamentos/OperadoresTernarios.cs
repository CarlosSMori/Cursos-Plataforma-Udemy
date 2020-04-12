using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresTernarios {
        public static void Executar() {
            var nota = 9.0;
            bool bomComportamento = true;
            // Nota >= 7.0 && É Primeiro Operador, ? É O Segundo Operando E : Terceiro Operando
            string resultado = nota >= 7.0 && bomComportamento
                ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
