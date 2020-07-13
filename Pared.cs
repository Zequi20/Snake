using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace SnakeGame
{
    public class Pared:Object
    {
        //Se obtiene la direccion del proyecto
        static string dir = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
        public static string directorio = Directory.GetParent(dir).ToString();
        //Imagen del obstaculo
        Image bloque = Image.FromFile(@directorio+@"\muro.png");
        public Pared(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        //Dibuja el obstaculo en un contexto grafico
        public void dibujar(Graphics g)
        {
            g.DrawImage(bloque, x, y);
        }

    }
}
