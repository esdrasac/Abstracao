using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracao2 {
    class Contratado:Professores {
        public string DataAdmissao { get; set; }
        public override void MostraDados() {
            Console.WriteLine($"\n{Nome} - Disciplina: {Disciplina}");
            Console.WriteLine($"Data de nascimento...: {DataNascimento}");
            Console.WriteLine($"Data de admissão.....: {DataAdmissao}");
            Console.ReadKey();
        }

        public override void MostraDiaAniversario() {
            base.MostraDiaAniversario();
            int MesNascimento;
            MesNascimento = int.Parse(DataNascimento.Substring(3, 2));
            Mes MesAniversario;
            MesAniversario = Mes.Janeiro;
            MesAniversario += MesNascimento - 1;
            Console.WriteLine($"O mês de seu aniversário é {MesAniversario}");
            Console.ReadKey();
        }
    }
}
