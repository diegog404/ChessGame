using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez.Tabuleiro;

namespace xadrez.JogoXadrez
{
    internal class Torre : Peca
    {
        public Torre(Cor cor, TabuleiroPecas tab) : base(cor, tab)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
