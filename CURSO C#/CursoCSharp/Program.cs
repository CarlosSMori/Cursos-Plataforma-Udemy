using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
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
            });

            central.SelecionarEExecutar();
        }
    }
}