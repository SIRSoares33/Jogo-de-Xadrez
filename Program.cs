using System;
using Tabuleiro;

namespace Jogo_de_xadrez;

class Program
{
    static void Main(string[] args)
    {
        Posicao posicao = new Posicao(2, 3);
        
        Console.WriteLine(posicao);
        Console.ReadKey();
    }
}
