using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Objetos
{
    class Pontuacao
    {
        DateTime data;
        long pontos;

        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public long Pontos
        {
            get
            {
                return pontos;
            }

            set
            {
                pontos = value;
            }
        }
    }
}
