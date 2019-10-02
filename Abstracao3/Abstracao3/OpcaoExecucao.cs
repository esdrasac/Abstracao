using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracao3 {
    class OpcaoExecucao {
        private Operacao Opcao;
        public OpcaoExecucao(Operacao Op) {
            Opcao = Op;
        }

        public string ExecutaOpcao(string txt) {
            string Resultado;
            Resultado = Opcao.Execute(txt);
            return Resultado;
        }
    }
}
