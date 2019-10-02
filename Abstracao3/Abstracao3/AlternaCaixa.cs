using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracao3 {
    class AlternaCaixa:Operacao {
        public override string Execute(string txt) {
            string TextoAlterado = "";
            int Tam = txt.Length;
            for(int i = 0; i < Tam; i++) {
                if(txt[i].ToString().ToUpper() == txt[i].ToString())
                    TextoAlterado += txt[i].ToString().ToLower();
                else
                    TextoAlterado += txt[i].ToString().ToUpper();
            }
            return TextoAlterado;
        }
    }
}
