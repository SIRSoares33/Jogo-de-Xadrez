namespace tabuleiro
{
    public class Peca
    {
        public Posicao? posicao { get;  set; }
        public Cor cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }    
        public Tabuleiro? tabuleiro { get; protected set; }

        public Peca(Cor cor, Tabuleiro tabuleiro)
        {
            this.posicao = null;
            this.cor = cor;
            this.QtdMovimentos = 0;
            this.tabuleiro = tabuleiro;
        }
    }
}