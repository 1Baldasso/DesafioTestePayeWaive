using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTriangulos
{
    public class Quadrado : FormaGeometrica
    {
        public int Lado { get; set; }
        public override void Desenhar()
        {
            DesenharQuadrado(Lado);
        }
        public static void DesenharQuadrado(int lado)
        {
            DesenharContorno(lado);
        }

        private static void DesenharContorno(int lado)
        {
            DesenharLinha(lado);
            if(lado == 1)
                return;
            DesenharLado(lado);
            DesenharLinha(lado);
        }

        private static void DesenharLinha(int lado)
        {
            for (int coluna = 0; coluna < lado * 2 - 1; coluna++)
            {
                if (coluna % 2 == 0)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }

        private static void DesenharLado(int lado)
        {
            int limite = lado * 2 - 2;
            for (int linha = 0; linha < lado - 2; linha++)
            {
                Console.Write("*");
                for (int coluna = 0; coluna < limite - 1; coluna++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
        }
    }
}
