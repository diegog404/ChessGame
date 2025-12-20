using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez.Tabuleiro
{
    internal class TabuleiroPecas
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] Pecas; //Peças do tabuleiro

        public TabuleiroPecas(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[Linhas, Colunas];
        }

        //metodo de acesso a uma peça do tabuleiro
        public Peca Peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        //metodo para colocar uma peça no tabuleiro, recebe um tipo de peça, e a posição em que será colocada
        public void ColocarPeca(Peca p, Posicao pos)
        {
            Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }
    }
}
