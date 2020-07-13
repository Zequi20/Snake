using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SnakeGame
{
    public class Object
    {
        //En esta clase se crean las variables y metodos que tendran en comun todas las demas clases
        public int x=5;
        public int y=5;
        public int ax = 0;
        public int ay = 0;
        public int ancho=10;
        public Random r = new Random();
        public bool colision(Object objeto)
        {
            /*En esta funcion se verifica si existe una coincidencia en las coordenadas
            entre el mismo objeto y otro cualquiera del juego que se introduza en el parametro
            de la misma y luego retorna un booleano correspondiente*/
            int px = Math.Abs(this.x - objeto.x);
            int py = Math.Abs(this.y - objeto.y);
            if(px >=0 && px < ancho && py >= 0 && py < ancho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
