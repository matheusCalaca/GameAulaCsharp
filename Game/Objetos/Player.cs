using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Objetos
{
    class Player
    {
        string nome= "";
        public List<Pontuacao> pontuacoes = new List<Pontuacao>();

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }
    }
}
