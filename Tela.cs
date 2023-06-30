using tabuleiro;

namespace Jogo_de_xadrez
{
    public class Tela
    {
        public static void imprimeTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++) 
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if(tab.GetPecas(i, j) == null)
                        Console.Write("- ");
                    else
                        Console.Write(tab.GetPecas(i, j).ToString() + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
