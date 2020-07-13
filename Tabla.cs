using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SnakeGame
{
    public partial class Tabla : Form
    {
        //Direccion del proyecto
        static string dir = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
        public static string directorio = Directory.GetParent(dir).ToString();

        public Tabla()
        {
            InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void n1_Click(object sender, EventArgs e)
        {

        }

        private void Tabla_Load(object sender, EventArgs e)
        {
            string[] tablero=new string[10];
            string[] dato = new string[2];
            //Se obtienen los datos de la lista
            using (StreamReader CargarHistorial = new StreamReader(@directorio+@"\Historial.txt"))
            {
                tablero = CargarHistorial.ReadLine().Split(',');
            }
            //Se llena el formulario con los datos de la lista
            dato = tablero[0].Split(':');
            n10.Text = dato[0];
            p10.Text = dato[1];
            dato = tablero[1].Split(':');
            n9.Text = dato[0];
            p9.Text = dato[1];
            dato = tablero[2].Split(':');
            n8.Text = dato[0];
            p8.Text = dato[1];
            dato = tablero[3].Split(':');
            n7.Text = dato[0];
            p7.Text = dato[1];
            dato = tablero[4].Split(':');
            n6.Text = dato[0];
            p6.Text = dato[1];
            dato = tablero[5].Split(':');
            n5.Text = dato[0];
            p5.Text = dato[1];
            dato = tablero[6].Split(':');
            n4.Text = dato[0];
            p4.Text = dato[1];
            dato = tablero[7].Split(':');
            n3.Text = dato[0];
            p3.Text = dato[1];
            dato = tablero[8].Split(':');
            n2.Text = dato[0];
            p2.Text = dato[1];
            dato = tablero[9].Split(':');
            n1.Text = dato[0];
            p1.Text = dato[1];

        }
    }
}
