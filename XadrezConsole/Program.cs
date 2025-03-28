using tabuleiro;
using xadrex;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaXadrez partida = new PartidaXadrez();
                Tela.ImprimirTabuleiro(partida.tab);
            }
            catch (TabuleiroExcessao e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}