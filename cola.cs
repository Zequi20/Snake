using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public class Cola : Object
    {
        //Esta clase contiene la mayoria de los metodos de la "serpiente" heredando la clase objeto
        //Se obtiene la direccion actual del proyecto
        static string dir = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
        public static string directorio = Directory.GetParent(dir).ToString();
        //Imagenes correspodientes a distintas partes del cuerpo de la serpiente
        Image s = Image.FromFile(@directorio+@"\snake1.png");
        Image m = Image.FromFile(@directorio+@"\m.gif");
        Image t = Image.FromFile(@directorio+@"\tail.png");
        Image Arrows = Image.FromFile(@directorio+@"\arr.gif");
        Image headUp = Image.FromFile(@directorio+@"\HeadUp.gif");
        Image headDown = Image.FromFile(@directorio+@"\HeadDown.gif");
        Image headRight = Image.FromFile(@directorio + @"\HeadLeft.gif");
        Image headLeft = Image.FromFile(@directorio + @"\HeadRight.gif");
        //Booleano que indica si dicha instancia de la clase es la guia o cabeza
        public bool cabeza = false;
        //Bandera que indica la direccion de movimiento
        public int flechas = 0;
        //Dibuja el cuerpo de la serpiente en un contexto grafico
        public void dibujar(Graphics g)
        {
            g.DrawImage(s, x, y);
        }
        //Dibuja la cola de la serpiente en un contexto grafico
        public void dibujarF(Graphics g)
        {
            g.DrawImage(t, x, y);
        }
        public void dibujarCabeza(Graphics g,int n)
        {
            //Dibuja la cabeza en la direccion de movimiento que corresponde al de la serpiente
                if (n == 0)
                {
                    g.DrawImage(Arrows, x, y);
                }
                else if (n == 1)
                {
                    g.DrawImage(headUp, x, y);
                }
                else if (n == 2)
                {
                    g.DrawImage(headDown, x, y);
                }
                else if (n == 4)
                {
                    g.DrawImage(headLeft, x, y);
                }
                else if (n == 3)
                {
                    g.DrawImage(headRight, x, y);
                }
        }
        /*Establece las coordenadas de la serpiente, guardando en una variable auxiliar su posicion 
         ara su posterior uso*/
        public void setxy(int xx, int yy)
        {
            ax = x;
            ay = y;
            this.x = xx;
            this.y = yy;
        }

        public Cola(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }
}
