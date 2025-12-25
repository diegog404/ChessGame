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

        //Construtor que instancia um tabuleiro, baseado numa matriz de peças
        public TabuleiroPecas(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[Linhas, Colunas];
        }

        //Metodo usado para imprimir as peças do tabuleiro na tela, de acordo com uma matriz;
        public Peca Peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        //acessa uma peça recebendo uma posição
        //Este metodo serve para referenciar uma peça do tabuleiro, em uma determinada posição.
        public Peca Peca(Posicao pos)
        {
            return Pecas[pos.Linha, pos.Coluna];
        }

        //Esse metodo serve para verificar se existe uma peça em uma determinada posição
        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return Peca(pos) != null;
        }

        //metodo para colocar uma peça no tabuleiro, recebe um tipo de peça, e a posição em que será colocada
        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }

            Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }

        //retira uma peca da posição em que ela está
        public Peca RetirarPeca(Posicao pos) 
        { 
            if(Peca(pos) == null)
            {
                return null;
            }
            Peca aux = Peca(pos);
            aux.Posicao = null;
            Pecas[pos.Linha, pos.Coluna] = null;
            return aux;
        }

        //verifica se a posição escolhida é válida, baseado na matriz do tabuleiro
        public bool PosicaoValida(Posicao pos)
        {
            if(pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }
            return true;
        }

        //valida se uma posição escolhida é válida para a jogada
        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}
