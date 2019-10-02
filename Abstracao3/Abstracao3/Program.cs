using System;

namespace Abstracao3 {
    class Program {
        static void Main(string[] args) {
            string Texto;
            Console.WriteLine("Digite um Texto: ");
            Texto = Console.ReadLine();
            OpcaoExecucao opcaoExecucao = new OpcaoExecucao(new InverteTexto());
            Console.WriteLine($"\nTexto invertido: {opcaoExecucao.ExecutaOpcao(Texto)}");
            
            opcaoExecucao = new OpcaoExecucao(new RetiraVogais());
            Console.WriteLine($"\nTexto sem vogais: {opcaoExecucao.ExecutaOpcao(Texto)}");

            opcaoExecucao = new OpcaoExecucao(new AlternaCaixa());
            Console.WriteLine($"\nTexto com caixa alterada: {opcaoExecucao.ExecutaOpcao(Texto)}");

            Console.ReadKey();



        }
    }
}
