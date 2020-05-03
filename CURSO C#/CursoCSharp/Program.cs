using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                // Fundamentos
                { "Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                { "Comentarios - Fundamentos", Comentarios.Executar},
                { "Variaveis e Constantes - Fundamentos", VariaveisEConstates.Executar},
                { "Inferencia - Fundamentos", Inferencia.Executar},
                { "Interpolação - Fundamentos", Interpolacao.Executar},
                { "Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                { "Lendos Dados do Console - Fundamentos", LendoDados.Executar},
                { "Formatando Números - Fundamentos", FormatandoNumero.Executar},
                { "Conversões - Fundamentos", Conversoes.Executar },
                { "Operadores Aritimeticos - Fundamentos", OperadoresAritmeticos.Executar},
                { "Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                { "Operadores Lógicos - Fundamentos", OperadoresLogico.Executar},
                { "Operadores de Atrbuição- Fundamentos", OperadoresAtribuicao.Executar},
                { "Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                { "Operadores Terciários - Fundamentos",OperadoresTernarios.Executar},
                
                // Estrutura de Controle
                { "Estrutura IF - Estrutura De Controle", EstruturaIf.Executar},
                { "Estrutura IF/ELSE - Estutura De Controle",EstruturaIfElse.Executar},
                { "Estrutura IF/ELSE/IF - Estrutura De Controle",EstruturaIfElseIf.Executar},
                { "Estrutura Switch - Estrutura De Controle",EstruturaSwitch.Executar},
                { "Estrutura While - Estrutura De Controle",EstruturaWhile.Executar},
                { "Estrutura Do While - Estrutura De Controle", EstruturaDoWhile.Executar},
                { "Estrutura For - Estrutura De Controle", EstruturaFor.Executar},
                { "Estrutura ForEach - Estrutura De Controle",EstruturaForEach.Executar},
                { "Usando Break - Estrutura De Controle", UsandoBreak.Executar},
                { "Usando Continue - Estrutura De Controle", UsandoContinue.Executar},

                // Classes E Métodos
                { "Membros - Classes E Métodos", Membros.Executar},
                { "Construtores - Classes E Métodos",Construtores.Executar},
                { "Métodos Com Retorno - Classes E Métodos",MetodosComRetorno.Executar},
                { "Métodos Estáticos - Classes E Métodos", MetodoEstaticos.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}