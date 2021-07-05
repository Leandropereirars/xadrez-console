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
    }
}
