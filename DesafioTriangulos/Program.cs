namespace DesafioTriangulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Desenhando Triângulos");
            //for (int i = 0; i < 10; i++)
            //{
            //    FormaGeometrica t = new Triangulo { Altura = i + 1 };
            //    t.Desenhar();
            //    Thread.Sleep(1000);
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}
            MetasExtendidas();
        }
        static void MetasExtendidas()
        {
            Console.WriteLine("Defina o número de formas a serem desenhadas:");
            var entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out int resultado))
            {
                ErroDeTransformacaoDeNumero();
                MetasExtendidas();
            }
            MenuDeFormas();
            var escolha = Console.ReadLine();
            if (int.TryParse(escolha, out int formaEscolhida))
            {
                if (!DecideForma(formaEscolhida, resultado))
                    MetasExtendidas();
            }
            else
            {
                ErroDeTransformacaoDeNumero();
                MetasExtendidas();
            }
        }

        private static void ErroDeTransformacaoDeNumero()
        {
            Console.Clear();
            Console.WriteLine("Erro ao transformar o número, tente novamente");
        }

        private static void MenuDeFormas()
        {
            Console.WriteLine("Que forma você deseja desenhar?");
            Console.WriteLine("1 - Triângulo");
            Console.WriteLine("2 - Quadrado");
            Console.WriteLine("3 - Retangulo");
        }

        private static void ImprimirRetangulos(int numRetangulos)
        {
            for (int i = 0; i < numRetangulos; i++)
            {
                FormaGeometrica t = new Retangulo { Base = (i+1)*2, Altura = i + 2 };
                t.Desenhar();
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        private static void ImprimirTriangulos(int numTriangulos)
        {
            for (int i = 0; i < numTriangulos; i++)
            {
                FormaGeometrica t = new Triangulo { Altura = i + 1 };
                t.Desenhar();
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        private static void ImprimirQuadrados(int numQuadrados) 
        {
            for (int i = 0; i < numQuadrados; i++)
            {
                FormaGeometrica t = new Quadrado { Lado = i + 1 };
                t.Desenhar();
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        private static bool DecideForma(int forma, int resultado)
        {
            switch (forma)
            {
                case 1:
                    ImprimirTriangulos(resultado);
                    return true;
                case 2:
                    ImprimirQuadrados(resultado);
                    return true;
                case 3:
                    ImprimirRetangulos(resultado);
                    return true;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção Inválida");
                    return false;
            }
        }
    }
}