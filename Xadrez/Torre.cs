using tabuleiro;

namespace xadrez
{
    public class Torre : Peca
    {
        public string Name { get; private set; }

        public Torre(Cor cor, Tabuleiro tabuleiro): base(cor, tabuleiro)
        {
            this.Name = "T";
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
