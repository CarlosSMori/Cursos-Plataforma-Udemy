using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogico {
        public static void Executar() {

            // Caso False , False
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            Console.WriteLine("Caso 1º");
            bool comprouTV50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou a TV 50? {0}", comprouTV50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            var comprouTV32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou a TV32? {0}", comprouTV32);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);


            // Case True , False.
            var executouTrabalho1B = false;
            var executouTrabalho2B = true;

            Console.WriteLine("Caso 2º");

            bool comprouTV50B = executouTrabalho1B && executouTrabalho2B;
            Console.WriteLine("Comprou a TV 50? {0}", comprouTV50B);

            var comprouSorveteB = executouTrabalho1B || executouTrabalho2B;
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorveteB);

            var comprouTV32B = executouTrabalho1B ^ executouTrabalho2B;
            Console.WriteLine("Comprou a TV32? {0}", comprouTV32B);

            Console.WriteLine("Mais saudável? {0}", !comprouSorveteB);

            // Case False , True.
            var executouTrabalho1C = false;
            var executouTrabalho2C = false;

            Console.WriteLine("Caso 3º");

            bool comprouTV50C = executouTrabalho1C && executouTrabalho2C;
            Console.WriteLine("Comprou a TV 50? {0}", comprouTV50C);

            var comprouSorveteC = executouTrabalho1C || executouTrabalho2C;
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorveteC);

            var comprou2TV32C = executouTrabalho1C ^ executouTrabalho2C;
            Console.WriteLine("Comprou a TV32? {0}", comprou2TV32C);

            Console.WriteLine("Mais saudável? {0}", !comprouSorveteC);

            // Case True ,True.
            var executouTrabalho1D = true;
            var executouTrabalho2D = true;

            Console.WriteLine("Caso 4º");

            bool comprouTV50D = executouTrabalho1D && executouTrabalho2D;
            Console.WriteLine("Comprou a TV 50? {0}", comprouTV50D);

            var comprouSorveteD = executouTrabalho1D || executouTrabalho2D;
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorveteD);

            var comprouTV32D = executouTrabalho1 ^ executouTrabalho2D;
            Console.WriteLine("Comprou a TV32? {0}", comprouTV32D);

            Console.WriteLine("Mais saudável? {0}", !comprouSorveteD);
        }
    }
}
