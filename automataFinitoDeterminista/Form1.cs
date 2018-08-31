using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automataFinitoDeterminista
{
    public partial class Form1 : Form
    {


        #region METODO MANUAL
        List<char> Alfabeto;
        Dictionary<char, bool> Estados;

        struct PreTrancisionTipo
        {
            public char EstadoInicial;
            public char Alfabeto;
        }
        Dictionary<PreTrancisionTipo, char> Transiciones;
        char EstadoInicial;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alfabeto = alfabetoBtn.Text.ToCharArray().ToList();
            Estados = new Dictionary<char, bool>();
            EstadoInicial = EstadoInicialBtn.Text.ToCharArray()[0];
            if (InicialEsFinal.Checked)
            {
                Estados.Add(EstadoInicial, true);
            }
            else
            {
                Estados.Add(EstadoInicial, false);
            }

            char[] temps = estadosNoFinalesBtn.Text.ToCharArray();
            foreach (char temp in temps)
            {
                Estados.Add(temp, false);
            }
            temps = EstadosFinalesBtn.Text.ToCharArray();
            foreach (char temp in temps)
            {
                Estados.Add(temp, true);
            }
            string[] temps2 = deltaBtn.Text.Split(',');
            Transiciones = new Dictionary<PreTrancisionTipo, char>();
            foreach (string temp in temps2)
            {
                char[] partes = temp.ToCharArray();
                if (partes.Length == 3)
                {

                    PreTrancisionTipo preTransicion = new PreTrancisionTipo();
                    preTransicion.EstadoInicial = partes[0];
                    preTransicion.Alfabeto = partes[1];
                    Transiciones.Add(preTransicion, partes[2]);
                }
            }
        }

        private void comprobarBTn_Click(object sender, EventArgs e)
        {
            char[] cadenas = palabraTb.Text.ToCharArray();
            char estadoActual = EstadoInicial;
            foreach (char letra in cadenas)
            {
                PreTrancisionTipo preTransicion = new PreTrancisionTipo();
                preTransicion.EstadoInicial = estadoActual;
                preTransicion.Alfabeto = letra;
                try
                {

                    estadoActual = Transiciones[preTransicion];
                }
                catch (KeyNotFoundException)
                {

                    continue;
                }
            }
            if (Estados[estadoActual])
            {
                Respuesta.BackColor = Color.Green;
                Respuesta.Text = "APROBADA";
            }
            else
            {
                Respuesta.BackColor = Color.Red;
                Respuesta.Text = "REPROBADA";
            }
        }

        private void alfabetoBtn_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        int[] posicionActual = new int[2];
        Bitmap DrawArea;
        Dictionary<string, bool> estadosGraficos;
        Dictionary<Point, string> posicionesGraficas;
        int estadoSiguienteAgraficar = 0;
        public Form1()
        {
            InitializeComponent();
            DrawArea = new Bitmap(tablero.Width, tablero.Height);
            Graphics g;
            g = Graphics.FromImage(DrawArea);
            tablero.Image = DrawArea;
            g.Dispose();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            estadosGraficos = new Dictionary<string, bool>();
            posicionesGraficas = new Dictionary<Point, string>();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X / 100;
            int y = e.Y / 100;
            if (!(posicionActual[0] == x && posicionActual[1] == y))
            {
                crearCirculo(e);
            }
        }

        private void crearCirculo(MouseEventArgs e)
        {
            Graphics g;
            Bitmap imagen = (Bitmap)tablero.Image.Clone();
            g = Graphics.FromImage(imagen);
            Pen mypen = new Pen(Brushes.Black);
            Pen eraser = new Pen(Brushes.White);
            int[] posicionAnterior = (int[])posicionActual.Clone();
            posicionActual[0] = e.X / 100;
            posicionActual[1] = e.Y / 100;
            if (!posicionesGraficas.ContainsKey(new Point(posicionAnterior[0], posicionAnterior[1])))
                g.DrawEllipse(eraser, posicionAnterior[0] * 100, posicionAnterior[1] * 100, 50, 50);
            if (!posicionesGraficas.ContainsKey(new Point(posicionActual[0], posicionActual[1])))
                g.DrawEllipse(mypen, posicionActual[0] * 100, posicionActual[1] * 100, 50, 50);
            tablero.Image = imagen;
            g.Dispose();
        }

        private void tablero_Click(object sender, EventArgs e)
        {
            string estadoCreado = "q" + estadoSiguienteAgraficar.ToString();
            estadosGraficos.Add(estadoCreado, false);
            posicionesGraficas.Add(new Point(posicionActual[0], posicionActual[1]), estadoCreado);
        }
    }
}
