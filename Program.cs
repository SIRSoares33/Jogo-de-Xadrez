using System;
using tabuleiro;

namespace Jogo_de_xadrez;

class Program
{
    static void Main(string[] args)
    {
        Tabuleiro tab = new Tabuleiro(8, 8);
        
        Tela.imprimeTabuleiro(tab);
        Console.ReadKey();
    }
}
