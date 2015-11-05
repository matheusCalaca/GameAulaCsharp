using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Objetos
{
    class Jogador : Circulo
    {

        private int vida = 5;

        public int Vida
        {
            get
            {
                return vida;
            }

            set
            {
                vida = value;
            }
        }

        public bool verificaColisao(int posXInimigo, int posYInimigo, int raioInimigo)
        {
            double espaco;
            espaco = Math.Sqrt( Math.Pow( (posXInimigo - PosX), 2) + Math.Pow( (posYInimigo - PosY),2) );//distancia entre os pontos para achar a colisao

            if(espaco < (raioInimigo/2 + Raio/2))
            {
                vida--;
                return true;
            }

            return false;
        }

    }
}
