namespace tabuleiro
{
    public class Posicao
    {
        public int Linha { get; protected set; }
        public int Coluna { get; protected set; }

        public Posicao(int linha, int coluna)
        {
            this.Linha = linha;
            this.Coluna = coluna;
        }

        public override string ToString()
        {
            return $"Posição: ({Linha}, {Coluna})";
        }
    }
}