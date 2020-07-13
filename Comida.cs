using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SnakeGame
{
    public class Comida : Object
    {
        //Obtiene direccion del proyecto
        static string dir = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
        public static string directorio = Directory.GetParent(dir).ToString();
        //Imagen de la comida
        Image c = Image.FromFile(@directorio+@"\egg.png");
        //Dibuja la comida en un contexto grafico
        public void dibujar(Graphics g)
        {
            g.DrawImage(c, x, y);
        }
        //Elige una ubicacion vacia al azar para ubicar la comida
        public void ubicar()
        {
            this.x = r.Next(1, 52) * 10;
            this.y = r.Next(1, 29) * 10;
        }
        //Establece la posicion
        public Comida(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
