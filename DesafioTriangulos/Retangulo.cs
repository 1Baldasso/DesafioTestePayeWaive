using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTriangulos
{
    public class Retangulo : FormaGeometrica
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public override void Desenhar()
        {
            DesenharRetangulo(Base,Altura);
        }

        public static void DesenharRetangulo(int @base, int altura)
        {
            DesenharContorno(@base, altura);
        }

        private static void DesenharContorno(int @base, int altura)
        {
            DesenharLinha(@base);
            DesenharLado(@base, altura);
            DesenharLinha(@base);
        }

        private static void DesenharLinha(int @base)
        {
            for(int coluna=0;coluna<@base*2-1;coluna++)
            {
                if (coluna % 2 == 0)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }

        private static void DesenharLado(int @base, int altura)
        {
            int limite = @base % 2 == 1 ? @base*2 - 1 : @base * 2 -2;
            for (int linha = 0; linha < altura - 2; linha++)
            {
                Console.Write("*");
                for (int coluna = 0; coluna < limite-1; coluna++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
        }
    }
}
