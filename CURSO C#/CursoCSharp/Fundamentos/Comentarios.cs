using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Comentarios {
        public static void Executar() {

            //cuidado com comentarios desnecessários
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


            Console.WriteLine("Comando CRT + k , CRT + C comenta seleção");
            Console.WriteLine("Comando CRT + k , CRT + u descomenta seleção");
        }
    }
}
