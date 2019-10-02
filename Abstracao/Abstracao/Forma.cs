using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracao {
    public abstract class Forma {
        public abstract double CalcArea();
        public abstract double CalcPerimetro();

        public virtual void Menssagem() {
            Console.Write("\nAgora eu vou calcular o ");
        }
    }
}
