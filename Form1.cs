using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        //Obtiene directorio del proyecto
        static string dir = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
        public static string directorio = Directory.GetParent(dir).ToString();
        //Se instancias los objetos que se usaran como contexto grafico
        Graphics pantalla;
        Graphics buffer;
        Bitmap pantallaAux;
        //Se construyen los objetos en su posicion inicial
        Cola cabeza = new Cola(300, 190);
        Comida comida = new Comida(250, 190);
        //Listas enlazadas que serviran para almacenar obstaculos y cuerpo de la serpiente
        List<Cola> cuerpo = new List<Cola>();
        List<Pared> muro = new List<Pared>();
        //Array que contendra los datos del jugador
        string[] DatosPerfil = new string[5];
        //Variables auxiliares para identificar posicion, pausa, fin de juego y opciones del menu
        int dirx = 0, diry = 0, puntaje = 0;
        bool pause = false;
        bool bm = true;
        public bool cuadricula = false;
        bool gameOver = false;
        int i = 0, j = 0;
        public int head = 0;
        //Matriz que sirve como guia para la ubicacion de obstaculos en el tablero de juego
        int[,] mapa = new int[62, 39];
        //Valores del cronometro del juego
        int segundos = 0, minutos = 0;
        //Imagen de la cuadricula del juego
        Image cuadro = Image.FromFile(@directorio + @"\cuadro.png");
        
        public Form1()
        {
            InitializeComponent();
            /*Se construyen los contextos graficos, el auxiliar para evitar
            el parpadeo en las actualizaciones de dibujo y el que sera mostrado al jugador*/
            pantalla = screen.CreateGraphics();
            pantallaAux = new Bitmap(Convert.ToInt32(screen.Width), Convert.ToInt32(screen.Height));
            buffer = Graphics.FromImage(pantallaAux);
            //Se agregan elementos al cuerpo
            cuerpo.Add(new Cola(-10, -10));
            cuerpo.Add(new Cola(-10, -10));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Carga el mapa y dificultad dependiendo de los valores que se establecen en el menu
            if (nZona.Text == "1")
            {
                cargarMapa1();
            }
            if (nZona.Text == "2")
            {
                cargarMapa2();
            }
            if (nZona.Text == "3")
            {
                cargarMapa3();
            }
            if (dif.Text == "1")
            {
                time.Interval = 75;
            }
            else if (dif.Text == "2")
            {
                time.Interval = 50;
            }
            else if (dif.Text == "3")
            {
                time.Interval = 40;
                MessageBox.Show("Esta dificultad no es ni lo mas remotamente justa", "Advertencia");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            comer();
            buffer.Clear(Color.Black);
            dibujarCuadros();
            dibujarMapa();
            dibujarCuerpo();
            cabeza.dibujarCabeza(buffer, head);
            comida.dibujar(buffer);
            limGameOver();
            pantalla.DrawImageUnscaled(pantallaAux, new Point(0, 0));
            mover();
            chocar();
            //Desbloquea el control al final de cada iteracion del juego
            bm = true;
        }

        //Dibuja la cuadricula en el tablero de juego si esta fue marcada
        void dibujarCuadros()
        {
            if (cuadricula == true)
            {
                for (i = 0; i < 62; i++)
                {
                    for (j = 0; j < 39; j++)
                    {
                        buffer.DrawImage(cuadro, i * 10, j * 10);
                    }
                }
            }
        }

        //Coloca los obstaculos en el mapa
        void cargarMapa1()
        {
            for (i = 0; i < 62; i++)
            {
                for (j = 0; j < 39; j++)
                {
                    if (j > 5 && j < 14)
                    {
                        mapa[i, j] = 1;
                    }
                    if (j > 24 && j < 33)
                    {
                        mapa[i, j] = 1;
                    }
                    if (i > 1 && i < 10)
                    {
                        mapa[i, j] = 0;
                    }
                    if (i > 51 && i < 60)
                    {
                        mapa[i, j] = 0;
                    }

                    if (i < 2 || i > 59)
                    {
                        mapa[i, j] = 1;
                    }
                    if (j < 2 || j > 36)
                    {
                        mapa[i, j] = 1;
                    }
                    if (j > 13 && j < 25)
                    {
                        mapa[i, j] = 0;
                    }
                }
            }
            for (i = 0; i < 62; i++)
            {
                for (j = 0; j < 39; j++)
                {
                    if (mapa[i, j] == 1)
                    {
                        muro.Add(new Pared(i * 10, j * 10));
                    }
                }
            }
        }

        void cargarMapa2()
        {
            for (i = 0; i < 62; i++)
            {
                for (j = 0; j < 39; j++)
                {
                    if (j > 21 && j < 27)
                    {
                        mapa[i, j] = 1;
                    }
                    if (i > 32 && i < 39)
                    {
                        mapa[i, j] = 1;
                        mapa[i, j] = 1;
                    }
                }
            }
            for (i = 0; i < 62; i++)
            {
                for (j = 0; j < 39; j++)
                {
                    if (mapa[i, j] == 1)
                    {
                        muro.Add(new Pared(i * 10, j * 10));
                    }
                }
            }
        }

        //Recorre cada elemento de la lista enlazada que contiene el cuerpo y los dibuja
        void dibujarCuerpo()
        {
            for (i = 0; i < cuerpo.Count; i++)
            {
                if (i == cuerpo.Count - 1)
                {
                    cuerpo[i].dibujarF(buffer);
                }
                else
                {
                    cuerpo[i].dibujar(buffer);
                }
            }

        }

        void cargarMapa3()
        {
            for (i = 0; i < 62; i++)
            {
                for (j = 0; j < 39; j++)
                {
                    if (i > 4 && i < 24)
                    {
                        mapa[i, j] = 1;
                    }
                    if (i > 36 && i < 57)
                    {
                        mapa[i, j] = 1;
                    }
                    if (j > 1 && j < 5)
                    {
                        mapa[i, j] = 0;
                    }
                    if (j > 33 && j < 37)
                    {
                        mapa[i, j] = 0;
                    }
                    if (j > 15 && j < 23)
                    {
                        mapa[i, j] = 0;
                    }
                    if (i < 2 || i > 59)
                    {
                        mapa[i, j] = 1;
                    }
                    if (j < 2 || j > 36)
                    {
                        mapa[i, j] = 1;
                    }
                }
            }
            for (i = 0; i < 62; i++)
            {
                for (j = 0; j < 39; j++)
                {
                    if (mapa[i, j] == 1)
                    {
                        muro.Add(new Pared(i * 10, j * 10));
                    }
                }
            }
        }

        /*Mantiene en movimiento de la cabeza de la serpiente en la direccion que corresponda
        y hace que los demas elementos tomen su posicion anterior*/
        public void mover()
        {
            cabeza.setxy(cabeza.x + dirx, cabeza.y + diry);
            for (i = 0; i < cuerpo.Count; i++)
            {
                if (i == 0)
                {
                    cuerpo[i].setxy(cabeza.ax, cabeza.ay);
                }
                else if (i > 0)
                {
                    cuerpo[i].setxy(cuerpo[i - 1].ax, cuerpo[i - 1].ay);
                }
            }
        }

        private void gamOver()
        {
            //Repreoduce el sonido de game over
            SoundPlayer c = new SoundPlayer();
            c.SoundLocation = @directorio + @"\Die.wav";
            c.Load();
            c.Play();
            //Se detiene el juego y cronometro
            time.Enabled = false;
            tJuego.Enabled = false;
            gameOver = true;
            //Muestra un mensaje, puntaje y tiempo de juego
            lbl_over.Visible = true;
            puntos.Text = "Puntaje: " + puntaje.ToString();
            puntos.Visible = true;
            pMenu.Visible = true;
            pSalir.Visible = true;
            lblT.Visible = true;
            lblT.Text = TimeShow.Text;
            //Vacia las lista con los elementos del tablero
            muro.Clear();
            cuerpo.Clear();
            cabeza.x = 0;
            cabeza.y = 0;
            //Obtiene los datos del perfil actual
            using (StreamReader CargarPerfil = new StreamReader(@directorio + @"\Perfiles\" + Jugador.Text + ".txt"))
            {
                string lectura = CargarPerfil.ReadLine();
                for (int i = 0; i < DatosPerfil.Length; i++)
                {
                    DatosPerfil = lectura.Split(',');
                }
            }
            using (StreamWriter Actualizar = File.CreateText(@directorio + @"\Perfiles\" + Jugador.Text + ".txt"))
            {
                int n, m;
                //Obtiene las estadisticas de tiempo y puntaje del archivo
                n = Convert.ToInt32(DatosPerfil[4]);
                m = Convert.ToInt32(DatosPerfil[1]);
                n++;
                DatosPerfil[4] = n.ToString();
                //Se realizan las comparaciones necesarias para identificar el mejor marcador
                if (puntaje > m)
                {
                    DatosPerfil[1] = puntaje.ToString();
                }
                if (CompararTiempo(TimeShow.Text, DatosPerfil[2]) == 1)
                {
                    DatosPerfil[2] = TimeShow.Text.Trim();
                }
                if (DatosPerfil[3] != "0:0")
                {
                    if (CompararTiempo(TimeShow.Text, DatosPerfil[3]) == 2)
                    {
                        DatosPerfil[3] = TimeShow.Text.Trim();
                    }
                }
                else
                {
                    DatosPerfil[3] = TimeShow.Text.Trim();
                }
                //Se actualiza el archivo de estadisticas
                Actualizar.WriteLine(DatosPerfil[0] + "," + DatosPerfil[1] +
                "," + DatosPerfil[2] + "," + DatosPerfil[3] + "," + DatosPerfil[4]);
            }
            VerificarPuntaje();
        }

        //Verifica las colisiones con el cuerpo y cola
        private void chocar()
        {
            for (i = 3; i < cuerpo.Count; i++)
            {
                if (cuerpo[i].colision(cabeza) == true)
                {
                    gamOver();
                }
            }
            for (i = 0; i < muro.Count; i++)
            {
                if (muro[i].colision(cabeza) == true)
                {
                    gamOver();
                }
            }
        }

        //Eventos de controles del juego, pausa y movimiento
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P || e.KeyCode == Keys.Escape)
            {
                if (pause == false)
                {
                    if (gameOver == false)
                    {
                        time.Enabled = false;
                        tJuego.Enabled = false;
                        pause = true;
                        lbl_pausa.Visible = true;
                        pMenu.Visible = true;
                        pSalir.Visible = true;
                        Help.Visible = true;
                        puntos.Visible = true;
                        lblT.Visible = true;
                    }
                }
                else if (pause == true)
                {
                    if (gameOver == false)
                    {
                        time.Enabled = true;
                        tJuego.Enabled = true;
                        pause = false;
                        lbl_pausa.Visible = false;
                        pMenu.Visible = false;
                        pSalir.Visible = false;
                        Help.Visible = false;
                        puntos.Visible = false;
                        lblT.Visible = false;
                    }
                }
            }

            if (bm == true)
            {
                if (gameOver == false)
                {
                    if (e.KeyCode == Keys.Up && cabeza.flechas != 3)
                    {
                        tJuego.Enabled = true;
                        dirx = 0;
                        diry = -cabeza.ancho;
                        head = 1;
                        cabeza.flechas = 1;
                        bm = false;
                    }
                    else if (e.KeyCode == Keys.Down && cabeza.flechas != 1)
                    {
                        tJuego.Enabled = true;
                        dirx = 0;
                        diry = cabeza.ancho;
                        head = 2;
                        cabeza.flechas = 3;
                        bm = false;
                    }
                    else if (e.KeyCode == Keys.Left && cabeza.flechas != 4)
                    {
                        tJuego.Enabled = true;
                        diry = 0;
                        dirx = -cabeza.ancho;
                        head = 3;
                        cabeza.flechas = 2;
                        bm = false;
                    }
                    else if (e.KeyCode == Keys.Right && cabeza.flechas != 2)
                    {
                        tJuego.Enabled = true;
                        diry = 0;
                        dirx = +cabeza.ancho;
                        head = 4;
                        cabeza.flechas = 4;
                        bm = false;
                    }
                }
            }
        }

        //Verifica la colison con la comida y suma puntos
        private void comer()
        {
            if (comida.colision(cabeza) == true)
            {
                ubicarComida();
                cuerpo.Add(new Cola(-10, -10));
                SoundPlayer n = new SoundPlayer();
                n.SoundLocation = @directorio + @"\eat.wav";
                n.Load();
                n.Play();
                puntaje++;
                score.Text = puntaje.ToString();
            }
        }

        //Hace que la serpiente vuelva por el lado contrario del tablero si se sale de este
        private void limites()
        {
            if (cabeza.x > 618)
            {
                cabeza.x=0;
            }
            if (cabeza.x < 0)
            {
                cabeza.x=618;
            }
            if (cabeza.y > 388)
            {
                cabeza.y=0;
            }
            if (cabeza.y < 0)
            {
                cabeza.y=388;
            }
        }

        //Hace que el juego termine si la serpiente sale del tablero
        void limGameOver()
        {
            /*Verifica si las coordenadas de posicion de la cabeza de la serpiente
             no se encuentran en una posicion visible en el contexto grafico
            que hace de tablero, en caso de que su posicion no pertenezca al tablero se ejecuta
            el metodo que finaliza el juego*/
            if (cabeza.x > 618)
            {
                gamOver();
            }
            if (cabeza.x < 0)
            {
                gamOver();
            }
            if (cabeza.y > 388)
            {
                gamOver();
            }
            if (cabeza.y < 0)
            {
                gamOver();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Dibuja los obstaculos en el contexto grafico
        void dibujarMapa()
        {
            for (i = 0; i < muro.Count; i++)
            {
                muro[i].dibujar(buffer);
            }
        }

        //Ubica la comida y vuelve a reubicarla si esta aparece en un lugar no vacio
        private void ubicarComida()
        {
            comida.ubicar();
            for (i = 0; i < muro.Count; i++)
            {
                if (comida.colision(muro[i]) == true)
                {
                    ubicarComida();
                }
                if (comida.colision(cabeza) == true)
                {
                    ubicarComida();
                }
            }
            for (i = 0; i < cuerpo.Count; i++)
            {
                if (comida.colision(cuerpo[i]) == true)
                {
                    ubicarComida();
                }
            }
        }

        private void lbl_over_Click(object sender, EventArgs e)
        {

        }

        private void puntos_Click(object sender, EventArgs e)
        {

        }

        //Cronometro del juego
        private void tJuego_Tick(object sender, EventArgs e)
        {
            if (pause == false)
            {
                segundos++;
                if (segundos == 60)
                {
                    segundos = 0;
                    minutos++;
                }
                TimeShow.Text = minutos.ToString() + ":" + segundos.ToString();
                lblT.Text = TimeShow.Text;
                TiempoL.Text = minutos.ToString() + ":" + segundos.ToString();
            }
        }


        //Compara dos tiempos y devuelve cual de ellos es el mayor
        int CompararTiempo(string tiempo1, string tiempo2)
        {
            int m1 = 0, s1 = 0, m2 = 0, s2 = 0;
            String[] t1 = tiempo1.Split(':');
            String[] t2 = tiempo2.Split(':');
            m1 = Int32.Parse(t1[0]);
            s1 = Int32.Parse(t1[1]);
            m2 = Int32.Parse(t2[0]);
            s2 = Int32.Parse(t2[1]);
            if(m1>m2)
            {
                return 1;
            }
            else if(m2>m1)
            {
                return 2;
            }
            else if(m1==m2)
            {
                if (s1 > s2)
                {
                    return 1;
                }
                else if (s2 > s1)
                {
                    return 2;
                }
            }
            return 0;
        }

        //Verifica si un puntaje supera a alguno de la lista de los mejores
        private void VerificarPuntaje()
        {
            string[] datos = new string[10];
            int[] puntajes=new int[10];
            using (StreamReader verificar = new StreamReader(@directorio + @"\Historial.txt"))
            {
                datos = verificar.ReadLine().Split(',');
            }
            
            for (i=0;i<10;i++)
            {
                //Realiza la comparacion con cada elemento del archivo de la lista
                if (puntaje > 0)
                {
                    puntajes[i] = Int32.Parse(datos[i].Split(':')[1]);
                    if (puntaje > puntajes[i])
                    {
                        //Toma la posicion del puesto superado en el top
                        datos[i] = Jugador.Text + ":" + puntaje.ToString();
                        puntaje = 0;
                        MessageBox.Show("Puntaje registrado en tablero","Aviso");
                    }
                    
                }
                else
                {
                    //En caso de haber superado a un jugador se rompe el ciclo
                    break;
                }
            }
            //Se escribe en el archivo con la lista del top con los puntajes actualizados
            using (StreamWriter Actualizar = File.CreateText(@directorio + @"\Historial.txt"))
            {
                Actualizar.WriteLine(datos[0]+","+ datos[1] + "," + datos[2] + "," + datos[3] + "," +
                datos[4] + "," + datos[5] + "," + datos[6] + "," + datos[7] + "," + datos[8] + "," +
                datos[9]);
            }
        }

        private void lblT_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Ayuda n = new Ayuda();
            n.Show();
        }

        private void TimeShow_Click(object sender, EventArgs e)
        {

        }

        private void screen_Click(object sender, EventArgs e)
        {

        }

        private void Jugador_Click(object sender, EventArgs e)
        {

        }

        private void pSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pMenu_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
