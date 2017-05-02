using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1___TDA_Basico
{
    class Personaje
    {
        public float experiencia;
        public float vidaMaxima;
        public float vida;
        public float manna;

        public void Curacion()
        {
            if (vida > vidaMaxima)
            {
                vida = vidaMaxima;
            }
            else
            {
                vida++;
            }
        }
    }
}
