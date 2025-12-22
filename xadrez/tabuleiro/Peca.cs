using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace xadrez.Tabuleiro
{
    internal abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdeMovimentos { get; protected set; }
        public TabuleiroPecas Tab {  get; protected set; } //referencia ao tabuleiro que vai jogar

        public Peca(Cor cor, TabuleiroPecas tab)
        {
            Posicao = null; // começa sem posição
            Cor = cor;
            Tab = tab;
            QtdeMovimentos = 0; // começa sem movimentos
        }

        public void IncrementarMovimentos()
        {
            QtdeMovimentos++;
        }

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();

            for(int i = 0; i < Tab.Linhas; i++)
            {

                for(int j = 0; j < Tab.Colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool PodeMoverPara(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
