﻿using tabuleiro;
using xadrex;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(Cor.Branca, tab), new Posicao(0, 0));
            tab.colocarPeca(new Torre(Cor.Branca, tab), new Posicao(1, 3));
            tab.colocarPeca(new Rei(Cor.Preta, tab), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(tab);
        }
    }
}