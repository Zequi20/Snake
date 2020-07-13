using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SnakeGame
{
    public partial class Menu : Form
    {
        Form1 v = new Form1();
        Tabla tablero = new Tabla();
        bool showDif = false;
        //Se obtiene la direccion del proyecto
        static string dir = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
        public static string directorio = Directory.GetParent(dir).ToString();
        string[] DatosPerfil = new string[5];
        public Menu()
        {
            InitializeComponent();
            //Se establece el directorio del cual se obtendran los datos guardados de los jugadores
            openProfile.InitialDirectory = @directorio + @"\Perfiles\";
            openProfile.Filter= "(*.txt)| *.txt";
            string Defecto=directorio;
            /*Se obtiene el ultimo archivo con datos de jugador cargado anteriormente
             por medio de otro archivo*/
            using (StreamReader CargarPerfil = new StreamReader(@directorio+@"\Defecto.txt"))
            {
                Defecto = directorio + "\\Perfiles\\" + CargarPerfil.ReadLine().Trim() + ".txt";
            }
            //Obtiene los datos del archivo cargado
            using (StreamReader CargarPerfil = new StreamReader(@Defecto))
            {
                string lectura = CargarPerfil.ReadLine();
                for (int i = 0; i < DatosPerfil.Length; i++)
                {
                    DatosPerfil = lectura.Split(',');
                }
            }

            ActualizarDatos();

        }

        /*Se asignan a sus respectivos labels los valores estadisticos contenidos en el archivo,
         tambien se escribe el nombre del jugador en el archivo que almacena el perfil cargado*/
        void ActualizarDatos()
        {
            nPerfil.Text = DatosPerfil[0];
            pPerfil.Text = DatosPerfil[1];
            tPerfil.Text = DatosPerfil[2];
            mPerfil.Text = DatosPerfil[3];
            npPerfil.Text = DatosPerfil[4];
            v.Jugador.Text = nPerfil.Text;
            using (StreamWriter Actualizar = File.CreateText(@directorio + @"\Defecto.txt"))
            {
                Actualizar.WriteLine(nPerfil.Text);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_MouseHover(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            v.Show();
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label3_MouseHover(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        void mostrarLbl()
        {
            lblDificultad.Visible = true;
            nDifi.Visible = true;
            showDif = true;
            label10.Visible = true;
            label11.Visible = true;
            checkBox1.Visible = true;
        }

        void ocultarLbl()
        {
            showDif = false;
            lblDificultad.Visible = false;
            nDifi.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            checkBox1.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (showDif == false)
            {
                mostrarLbl();
            }
            else
            {
                ocultarLbl();
            }
        }

        /*Eventos de los labels de menu que establecen los valores que definen el
         obstaculo a cargar para el juego*/
        private void label4_Click(object sender, EventArgs e)
        {
            v.dif.Text = "1";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            v.dif.Text = "2";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            v.dif.Text = "3";
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Ayuda n = new Ayuda();
            n.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (label11.Text == "<1>")
            {
                label11.Text = "<2>";
                v.nZona.Text = "2";
            }
            else if (label11.Text == "<2>")
            {
                label11.Text = "<3>";
                v.nZona.Text = "3";
            }
            else if (label11.Text == "<3>")
            {
                label11.Text = "<1>";
                v.nZona.Text = "1";
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (tabControlPerfiles.Visible == true)
            {
                tabControlPerfiles.Visible = false;
            }
            else if (tabControlPerfiles.Visible == false)
            {
                tabControlPerfiles.Visible = true;
            }
        }

        private void txtJugador_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (v.cuadricula == false)
            {
                v.cuadricula = true;
            }
            else
            {
                v.cuadricula = false;
            }
        }

        private void nDifi_Click(object sender, EventArgs e)
        {
            if (nDifi.Text == "<1>")
            {
                v.dif.Text = "2";
                nDifi.Text = "<2>";
            }
            else if (nDifi.Text == "<2>")
            {
                v.dif.Text = "3";
                nDifi.Text = "<3>";
            }
            else if (nDifi.Text == "<3>")
            {
                v.dif.Text = "1";
                nDifi.Text = "<1>";
            }
        }

        /*Crea un nuevo archivo con el nombre del jugador que almacena las estadisticas
        de modo a que se pueda cargar luego*/
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbCrearPerfil.Text.Trim() != "")
            {
                using (StreamWriter Crea = File.CreateText(@directorio + @"\Perfiles\" + tbCrearPerfil.Text.Trim() + ".txt"))
                {
                    Crea.WriteLine("" + tbCrearPerfil.Text.Trim() + ",0,0:0,0:0,0");
                    MessageBox.Show("Perfil " + tbCrearPerfil.Text.Trim() + " creado, acceda al mismo\ndesde la pestaña \"Cargar Perfil => ExplorarPerfiles\"", "Perfil Creado");
                    tbCrearPerfil.Text = "";
                }
            }
        }

        /*Permite al usuario elegir el archivo de perfil a cargar mediante un open file dialog
         luego se obtienen los datos del mismo*/
        private void button2_Click(object sender, EventArgs e)
        {
            if(openProfile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    lblDirectorio.Text = openProfile.FileName;
                    using (StreamReader CargarPerfil = new StreamReader(@lblDirectorio.Text))
                    {
                        string lectura = CargarPerfil.ReadLine();
                        for(int i=0;i<DatosPerfil.Length;i++)
                        {
                            DatosPerfil = lectura.Split(',');
                        }
                        ActualizarDatos();
                        MessageBox.Show("Perfil "+DatosPerfil[0]+" cargado","Carga exitosa");
                    }
                }
                catch(Exception)
                {
                    throw;
                }
            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            tablero.Show();
        }
    }
}