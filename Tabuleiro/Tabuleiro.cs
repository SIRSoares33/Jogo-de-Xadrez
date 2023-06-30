namespace tabuleiro
{
    public class Tabuleiro
    {
        public int Linhas { get; protected set; }
        public int Colunas { get; protected set; }
        
        private Peca[,]? _pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            _pecas = new Peca[linhas, colunas];
        }

        public Peca GetPecas(int linha, int coluna)
        {
            
            return _pecas[linha, coluna];
        }

        public void AdicionarPeca(Peca peca, Posicao posicao)
        {
            _pecas[posicao.Linha, posicao.Coluna] = peca;
            
            peca.posicao = posicao;
        }
    }
}