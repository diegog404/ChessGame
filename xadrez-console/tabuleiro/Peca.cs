using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console.tabuleiro
{
    internal class Peca
    {
        //Uma peça tem posicão, cor, movimentos e faz parte do tabuleiro
        public Posicao Posicao { get; set; }
        public Cor Cor { get; set; }
        public int QtdeMovimentos { get; set; }
        public Tabuleiro Tab { get; set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {
            Posicao = posicao;
            Cor = cor;
            Tab = tab;
            QtdeMovimentos = 0;
        }
    }
}
