using System;

namespace Abstracao2 {
    class Program {
        static void Main(string[] args) {
            Contratado MeuContratado = new Contratado();
            MeuContratado.Nome = "Esdras de Aguilar";
            MeuContratado.Disciplina = "Engenharia de requisitos";
            MeuContratado.DataNascimento = "02/06/1995";
            MeuContratado.DataAdmissao = "02/02/2013";
            MeuContratado.MostraDados();
            MeuContratado.MostraDiaAniversario();

            Temporario MeuTemporario = new Temporario();
            MeuTemporario.Nome = "Nayara Silva dos Anjos";
            MeuTemporario.Disciplina = "Genética";
            MeuTemporario.DataNascimento = "07/06/1995";
            MeuTemporario.DataInicioContrato = "26/02/2017";
            MeuTemporario.DataFimContrato = "20/12/2019";
            MeuTemporario.MostraDados();
            MeuTemporario.MostraDiaAniversario();
            Console.ReadKey();
        }
    }
}
