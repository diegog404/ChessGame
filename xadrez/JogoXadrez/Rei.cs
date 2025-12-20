using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez.Tabuleiro;

namespace xadrez.JogoXadrez
{
    internal class Rei : Peca
    {
        public Rei(Cor cor, TabuleiroPecas tab) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
