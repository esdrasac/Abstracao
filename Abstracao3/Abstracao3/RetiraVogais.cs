using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracao3 {
    class RetiraVogais:Operacao {
        public override string Execute(string txt) {
            string TextoConsoantes = "";
            TextoConsoantes = txt.Replace("A", "");
            TextoConsoantes = TextoConsoantes.Replace("a", "");
            TextoConsoantes = TextoConsoantes.Replace("E", "");
            TextoConsoantes = TextoConsoantes.Replace("e", "");
            TextoConsoantes = TextoConsoantes.Replace("I", "");
            TextoConsoantes = TextoConsoantes.Replace("i", "");
            TextoConsoantes = TextoConsoantes.Replace("O", "");
            TextoConsoantes = TextoConsoantes.Replace("o", "");
            TextoConsoantes = TextoConsoantes.Replace("U", "");
            TextoConsoantes = TextoConsoantes.Replace("u", "");
            return TextoConsoantes;
        }
    }
}
