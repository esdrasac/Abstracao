using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracao2 {
    abstract class Professores {
        public enum Mes { Janeiro, Fevereiro, Março, Abril, Maio, Junho, Julho, Agosto, Setembro, Outubro, Novembro, Dezembro }
        public string Nome { get; set; }
        public string Disciplina { get; set; }
        public string DataNascimento { get; set; }

        public abstract void MostraDados();
        public virtual void MostraDiaAniversario() {
            Console.WriteLine($"\n O(A) professor(a) nasceu no dia {DataNascimento.Substring(0, 2)}");
        }
    }
}
