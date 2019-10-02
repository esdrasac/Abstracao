using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracao2 {
    class Temporario:Professores {
        public string DataInicioContrato { get; set; }
        public string DataFimContrato { get; set; }


        public override void MostraDados() {
            Console.WriteLine($"\n{Nome} - Disciplina: {Disciplina}");
            Console.WriteLine($"Data de nascimento: {DataNascimento}");
            Console.WriteLine($"Contrato válido de {DataInicioContrato} até {DataFimContrato}");
            Console.ReadKey();
        }
        public override void MostraDiaAniversario() {
            base.MostraDiaAniversario();

        }
    }
}
