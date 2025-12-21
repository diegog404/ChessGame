using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace xadrez.Tabuleiro
{
    internal class Peca
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
    }
}
