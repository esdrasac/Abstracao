using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracao {
    public class Quadrado:Forma {
        public double Lado { get; set; }


        public override double CalcArea() {
            return Lado * Lado;
        }

        public override double CalcPerimetro() {
            return 4 * Lado;
        }
        public override void Menssagem() {
            base.Menssagem();
            Console.WriteLine("Quadrado!\n");
        }
    }
}
