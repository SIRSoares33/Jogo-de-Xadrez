using System;
using tabuleiro;
using xadrez;

namespace Jogo_de_xadrez;

class Program
{
    static void Main(string[] args)
    {
        Tabuleiro tab = new Tabuleiro(8, 8);

        tab.AdicionarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
        
        Tela.imprimeTabuleiro(tab);
        Console.ReadKey();
    }
}
