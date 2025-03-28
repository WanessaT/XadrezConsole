using tabuleiro;

namespace XadrezConsole
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                for (int col = 0; col < tabuleiro.Colunas; col++)
                {
                    if (tabuleiro.peca(i, col) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tabuleiro.peca(i, col) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
