namespace tabuleiro
{
    public class Peca
    {
        public Posicao? posicao { get; protected set; }
        public Cor cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }    
        public Tabuleiro? tabuleiro { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tabuleiro)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.QtdMovimentos = 0;
            this.tabuleiro = tabuleiro;
        }
    }
}