
namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdeMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        /// <summary>
        /// Peça com sua posição no tabuleiro com respectiva cor
        /// </summary>
        /// <param name="posicao">Posição de linha e coluna da peça</param>
        /// <param name="tab">Tabuleiro criado para  o jogo</param>
        /// <param name="cor">Cor da peça</param>
        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qtdeMovimentos = 0;
        }

        public void incrementarQtdeMovimentos()
        {
            qtdeMovimentos++;
        }

        public void decrementarQtdeMovimentos()
        {
            qtdeMovimentos--;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i =0; i < tab.colunas; i++)
            {
                for (int j =0; j < tab.colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossiveis();

    }
}
