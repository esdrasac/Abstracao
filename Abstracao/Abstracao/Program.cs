using System;

namespace Abstracao {
    class Program {
        static void Main(string[] args) {
            Quadrado MeuQuadrado = new Quadrado();
            MeuQuadrado.Lado = 2;
            MeuQuadrado.Menssagem();
            Console.WriteLine($"Área do quadrado.....: {MeuQuadrado.CalcArea():F2}");
            Console.WriteLine($"Perímetro do quadrado: {MeuQuadrado.CalcPerimetro():F2}");
            Console.ReadKey();

            Circulo MeuCirculo = new Circulo();
            MeuCirculo.Raio = 3;
            MeuCirculo.Menssagem();
            Console.WriteLine($"Área do círculo.....: {MeuCirculo.CalcArea():F2}");
            Console.WriteLine($"Perímetro do círculo: {MeuCirculo.CalcPerimetro():F2}");
            Console.ReadKey();

        }
    }
}
