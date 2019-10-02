using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracao {
    public class Circulo:Forma {
        public double Raio { get; set; }


        public override double CalcArea() {
            return Math.PI * Math.Pow(Raio, 2);
        }
        public override double CalcPerimetro() {
            return 2 * Math.PI * Raio;
        }

        public override void Menssagem() {
            base.Menssagem();
            Console.WriteLine("Círculo!\n");
        }
    }
}
