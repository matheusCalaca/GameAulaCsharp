using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Objetos
{
    class Circulo
    {
        private int posX, posY, raio = 20, tipo;
        private Color cor;
        
        

        public int PosX
        {
            get
            {
                return posX;
            }

            set
            {
                posX = value;
            }
        }

        public int PosY
        {
            get
            {
                return posY;
            }

            set
            {
                posY = value;
            }
        }

        public Color Cor
        {
            get
            {
                return cor;
            }

            set
            {
                cor = value;
            }
        }

        public int Raio
        {
            get
            {
                return raio;
            }

            set
            {
                raio = value;
            }
        }

        public int Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }
    }
}
