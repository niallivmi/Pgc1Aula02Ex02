//@niallivmi
using System;

namespace Pgc1Aula02Ex02

{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4;

            Console.Write("Digite a nota do primeiro bimestre: ");
            n1 = float.Parse(Console.ReadLine());

            Console.Write("Digite a nota do segundo bimestre: ");
            n2 = float.Parse(Console.ReadLine());

            Console.Write("Digite a nota do terceiro bimestre: ");
            n3 = float.Parse(Console.ReadLine());

            Console.Write("Digite a nota do quarto bimestre: ");
            n4 = float.Parse(Console.ReadLine());

            Console.WriteLine("A nota do estudante é: " + ((n1 + n2+n3+n4) / 4));
        }
    }
}
