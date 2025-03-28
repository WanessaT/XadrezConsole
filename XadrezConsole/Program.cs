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
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(Cor.Branca, tab), new Posicao(9,0));
                tab.colocarPeca(new Torre(Cor.Branca, tab), new Posicao(1, 3));
                tab.colocarPeca(new Rei(Cor.Preta, tab), new Posicao(0, 2));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroExcessao e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}