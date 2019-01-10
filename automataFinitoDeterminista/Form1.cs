using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automataFinitoDeterminista
{
    public partial class Form1 : Form
    {


        #region METODO MANUAL
        List<char> Alfabeto = new List<char>();
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

        Point posicionActual = new Point();
        Bitmap DrawArea;
        Dictionary<string, bool> estadosGraficos;
        Dictionary<Point, string> posicionesGraficas;
        struct PreEstadoGrafico
        {
            public string estadoInicio;
            public char letra;
        }
        Dictionary<PreEstadoGrafico, string> TransicionGrafica = new Dictionary<PreEstadoGrafico, string>();
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
            if (!(posicionActual.X == x && posicionActual.Y == y))
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
            Point posicionAnterior = posicionActual;
            posicionActual.X = e.X / 100;
            posicionActual.Y = e.Y / 100;
            if (!posicionesGraficas.ContainsKey(posicionAnterior))
                g.DrawEllipse(eraser, posicionAnterior.X * 100, posicionAnterior.Y * 100, 50, 50);
            if (!posicionesGraficas.ContainsKey(new Point(posicionActual.X, posicionActual.Y)))
                g.DrawEllipse(mypen, posicionActual.X * 100, posicionActual.Y * 100, 50, 50);
            tablero.Image = imagen;
            g.Dispose();
        }

        private void tablero_Click(object sender, EventArgs e)
        {
            if (!posicionesGraficas.ContainsKey(posicionActual) && !ponerEtiqueta)
                ingresarEstado();
        }

        private void ingresarEstado()
        {
            string estadoCreado = "q" + estadoSiguienteAgraficar.ToString();
            estadosGraficos.Add(estadoCreado, false);
            posicionesGraficas.Add(posicionActual, estadoCreado);

            estadoSiguienteAgraficar++;
            Graphics g;
            Bitmap imagen = (Bitmap)tablero.Image.Clone();
            g = Graphics.FromImage(imagen);
            g.DrawString(estadoCreado, new Font("Verdana", 15), Brushes.Black, posicionActual.X * 100 + 7, posicionActual.Y * 100 + 10);
            tablero.Image = imagen;
            g.Dispose();
        }

        private void tablero_DoubleClick(object sender, EventArgs e)
        {
            Graphics g;
            Bitmap imagen = (Bitmap)tablero.Image.Clone();
            g = Graphics.FromImage(imagen);
            if (posicionesGraficas.ContainsKey(posicionActual))
            {
                if (!estadosGraficos[posicionesGraficas[posicionActual]])
                {
                    Pen mypen = new Pen(Brushes.Black);
                    g.DrawEllipse(mypen, posicionActual.X * 100 + 5, posicionActual.Y * 100 + 5, 40, 40);
                    estadosGraficos[posicionesGraficas[posicionActual]] = true;
                }
                else
                {
                    Pen mypen = new Pen(Brushes.White);
                    g.DrawEllipse(mypen, posicionActual.X * 100 + 5, posicionActual.Y * 100 + 5, 40, 40);
                    estadosGraficos[posicionesGraficas[posicionActual]] = false;
                }
            }
            tablero.Image = imagen;
            g.Dispose();
        }


        private Point posicionInicialLinea = new Point();
        private bool hacerLinea = false;
        private bool ponerEtiqueta = false;
        private List<char> letrasEtiqueta = new List<char>();
        private void tablero_MouseDown(object sender, MouseEventArgs e)
        {
            if (ponerEtiqueta)
            {
                Graphics g;
                Bitmap imagen = (Bitmap)tablero.Image.Clone();
                g = Graphics.FromImage(imagen);
                string letras = string.Join(",", letrasEtiqueta.ToArray());
                g.DrawString(letras, new Font("Verdana", 10), Brushes.Black, e.X, e.Y);
                tablero.Image = imagen;
                g.Dispose();
            }
            else
            {
                if (posicionesGraficas.ContainsKey(posicionActual) && e.Button == MouseButtons.Right)
                {
                    posicionInicialLinea = posicionActual;
                    hacerLinea = true;
                }
            }
        }

        private void tablero_MouseUp(object sender, MouseEventArgs e)
        {
            if (ponerEtiqueta)
            {
                ponerEtiqueta = false;
            }
            if (hacerLinea && e.Button == MouseButtons.Right)
            {
                ingresarAlfabeto ingreso = new ingresarAlfabeto(Alfabeto);
                ingreso.ShowDialog();
                if (ingreso.DialogResult == DialogResult.OK)
                {
                    Alfabeto = ingreso.alfabeto;
                    ponerEtiqueta = true;
                    int posicion = 0;
                    letrasEtiqueta = ingreso.agregar.ToList();
                    foreach (char letra in ingreso.agregar)
                    {
                        try
                        {
                            PreEstadoGrafico preEstado = new PreEstadoGrafico();
                            preEstado.estadoInicio = posicionesGraficas[posicionInicialLinea];
                            preEstado.letra = letra;
                            TransicionGrafica.Add(preEstado, posicionesGraficas[posicionActual]);
                        }
                        catch (Exception)
                        {
                            letrasEtiqueta.RemoveAt(posicion);
                        }
                        posicion++;
                    }
                    AlfabetoToolStripTextBox.Clear();
                    foreach (char letra in Alfabeto)
                    {
                        AlfabetoToolStripTextBox.Text += letra;
                    }
                    dibujarLinea();
                }
                hacerLinea = false;
            }
        }

        private void dibujarLinea()
        {
            Graphics g;
            Bitmap imagen = (Bitmap)tablero.Image.Clone();
            g = Graphics.FromImage(imagen);
            Pen pen = new Pen(Color.Black, 3);
            pen.StartCap = LineCap.RoundAnchor;
            pen.EndCap = LineCap.ArrowAnchor;
            Point aumentoInicio = new Point(0, 25);
            Point aumentoFinal = new Point(50, 25);
            if (posicionInicialLinea.X < posicionActual.X)
            {
                aumentoInicio.X = 50;
                aumentoFinal.X = 0;
            }
            else if (posicionInicialLinea.X == posicionActual.X)
            {
                aumentoInicio.X = 25;
                aumentoFinal.X = 25;
                if (posicionInicialLinea.Y < posicionActual.Y)
                {
                    aumentoInicio.Y = 50;
                    aumentoFinal.Y = 0;
                }
                else
                {
                    aumentoInicio.Y = 0;
                    aumentoFinal.Y = 50;
                }
            }
            g.DrawLine(pen, posicionInicialLinea.X * 100 + aumentoInicio.X,
                            posicionInicialLinea.Y * 100 + aumentoInicio.Y,
                            posicionActual.X * 100 + aumentoFinal.X,
                            posicionActual.Y * 100 + aumentoFinal.Y);
            tablero.Image = imagen;
            g.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            char[] cadenas = toolStripTextBox2.Text.ToCharArray();
            string estadoActual = "q0";
            foreach (char letra in cadenas)
            {
                PreEstadoGrafico preTransicion = new PreEstadoGrafico();
                preTransicion.estadoInicio = estadoActual;
                preTransicion.letra = letra;
                try
                {
                    estadoActual = TransicionGrafica[preTransicion];
                }
                catch (KeyNotFoundException)
                {

                    continue;
                }
            }
            if (estadosGraficos[estadoActual])
            {
                toolStripLabel3.BackColor = Color.Green;
                toolStripLabel3.Text = "APROBADA";
            }
            else
            {
                toolStripLabel3.BackColor = Color.Red;
                toolStripLabel3.Text = "REPROBADA";
            }
        }

        private void AlfabetoToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void AlfabetoToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            char[] letras = AlfabetoToolStripTextBox.Text.ToCharArray();
            Graphics g;
            Bitmap imagen = (Bitmap)tablero.Image.Clone();
            g = Graphics.FromImage(imagen);
            Pen pen = new Pen(Color.Black, 2);
            pen.StartCap = LineCap.RoundAnchor;
            pen.EndCap = LineCap.ArrowAnchor;
            Point[] points = new Point[4];
            foreach (var estado in estadosGraficos.ToArray())
            {

                TransicionGrafica.Where(x => x.Key.estadoInicio == estado.Key);
                List<char> letrasEtiquetaParcial = new List<char>();
                foreach (char letra in letras)
                {
                    PreEstadoGrafico temp = new PreEstadoGrafico();
                    temp.estadoInicio = estado.Key;
                    temp.letra = letra;
                    try
                    {
                        if (TransicionGrafica[temp] == estado.Key)
                        {
                            letrasEtiquetaParcial.Add(temp.letra);
                        }
                    }
                    catch (KeyNotFoundException)
                    {
                        letrasEtiquetaParcial.Add(temp.letra);
                    }

                }
                if (letrasEtiquetaParcial.Count>0)
                {
                    points[0] = new Point(posicionesGraficas.FirstOrDefault(x => x.Value == estado.Key).Key.X * 100,
                                                   posicionesGraficas.FirstOrDefault(x => x.Value == estado.Key).Key.Y * 100 + 25);
                    points[3] = new Point(points[0].X + 50, points[0].Y);
                    points[1] = new Point(points[0].X, points[0].Y + 50);
                    points[2] = new Point(points[0].X + 50, points[0].Y + 50);
                    g.DrawLines(pen, points);
                    g.DrawString(String.Join(",", letrasEtiquetaParcial.ToArray()),new Font("Verdana",12),Brushes.Black,points[0].X+5,points[0].Y+25);
                }

            }
            tablero.Image = imagen;
            g.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tablero.Image = new Bitmap(tablero.Width, tablero.Height);
            estadosGraficos = new Dictionary<string, bool>();
            posicionesGraficas = new Dictionary<Point, string>();
            Alfabeto = new List<char>();
            TransicionGrafica = new Dictionary<PreEstadoGrafico, string>();
            estadoSiguienteAgraficar = 0;
    }
    }
}
