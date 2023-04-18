using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTriangulos
{
    public class Triangulo : FormaGeometrica
    {
        public int Altura { get; set; }
        public override void Desenhar()
        {
            DesenharTriangulo(Altura);
        }
        public static void DesenharTriangulo(int tamanho)
        {
            ImprimirContorno(tamanho);
        }

        private static void ImprimirUltimaLinha(int tamanho)
        {
            for (int coluna = 0; coluna < tamanho * 2 - 1; coluna++)
            {
                if (coluna % 2 == 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("*");
                }
            }
        }
        private static void ImprimirContorno(int tamanho)
        {
            for (int linha = 0; linha < tamanho; linha++)
            {
                for (int coluna = 0; coluna < tamanho * 2 - 1; coluna++)
                {
                    bool ultimaLinha = linha == tamanho - 1;
                    // Imprime asterisco apenas nas bordas do triângulo
                    if (coluna == tamanho - 1 - linha)
                    {
                        Console.Write("*");
                        if (ultimaLinha)
                        {
                            ImprimirUltimaLinha(tamanho);
                        }
                    }
                    else if (!ultimaLinha && coluna == tamanho - 1 + linha)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
