namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        /// <summary>
        /// Função tabuleiro onde cria o tabuleiro de xadrez
        /// </summary>
        /// <param name="linhas">quantidade de linhas</param>
        /// <param name="colunas">quantidade de colunas</param>
        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        /// <summary>
        /// Função peças, onde cada peça é inserida em sua posição de linha e coluna
        /// </summary>
        /// <param name="linha">Posição em qual linha</param>
        /// <param name="coluna">Posição em qual coluna</param>
        /// <returns></returns>
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public bool existePeca(Posicao pos)
        {
            validadePosicao(pos);
            return peca(pos) != null;
        }

        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna <0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        public void validadePosicao (Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida");
            }
        }

    }
}
