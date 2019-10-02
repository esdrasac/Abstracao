using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracao3 {
    class InverteTexto:Operacao {
        public override string Execute(string txt) {
            string TextoInvertido = "";
            int Tam = txt.Length;
            for(int i = Tam - 1; i >= 0; i--)
                TextoInvertido += txt[i];
            return TextoInvertido;
        }
    }
}
