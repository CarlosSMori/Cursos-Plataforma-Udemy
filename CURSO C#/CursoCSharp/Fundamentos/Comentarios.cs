using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Comentarios {
        public static void Executar() {

            // Cuidado com comentários desnecessários
            Console.WriteLine("Codigo claro é sempre melhor!");

            /// <summary>
            /// 
            /// </summary>
            Console.WriteLine("O C# tem o XML Comments");

            /* 
             * Esse é comentario
             * de multiplas linhas...
             */
            Console.WriteLine("Comentarios de multiplas linhas");


            Console.WriteLine("Comando CRT + K , CRT + C comenta seleção");
            Console.WriteLine("Comando CRT + K , CRT + U descomenta seleção");
        }
    }
}
