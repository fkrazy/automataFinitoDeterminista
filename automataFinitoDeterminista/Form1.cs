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
        Dictionary<PreTrancisionTipo,char> Transiciones;
        char EstadoInicial;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alfabeto= alfabetoBtn.Text.ToCharArray().ToList();
            Estados= new Dictionary<char, bool>();
            EstadoInicial = EstadoInicialBtn.Text.ToCharArray()[0];
            if (InicialEsFinal.Checked)
            {
                Estados.Add(EstadoInicial,true);
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
                if (partes.Length==3)
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
            char[]cadenas=palabraTb.Text.ToCharArray();
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

        Bitmap DrawArea;
        Dictionary<string, bool> estadosGraficos;
        public Form1()
        {
            InitializeComponent();
            DrawArea = new Bitmap(estadoInicialGrafico.Size.Width, estadoInicialGrafico.Size.Height);
            Graphics g;
            g = Graphics.FromImage(DrawArea);
            Pen mypen = new Pen(Brushes.Black);
            g.DrawEllipse(mypen, 0, 0, 50, 50);
            estadoInicialGrafico.Image = DrawArea;
            g.Dispose();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            estadosGraficos = new Dictionary<string, bool>();
            Graphics g;
            Bitmap imagen = (Bitmap) DrawArea.Clone();
            g = Graphics.FromImage(imagen);

            Pen mypen = new Pen(Brushes.Black);
            g.DrawEllipse(mypen, 0, 0, 50, 50);
            g.DrawString( "q0", new Font("Verdana",15), Brushes.Black, 10, 10);
            estadoInicialGrafico.Image = imagen;
            estadosGraficos.Add("q0", false);
            g.Dispose();
        }

        private void estadoInicialGrafico_DoubleClick(object sender, EventArgs e)
        {
            Graphics g;
            Bitmap imagen = (Bitmap)DrawArea.Clone();
            g = Graphics.FromImage(imagen);
            Pen mypen = new Pen(Brushes.Black);
            if (estadosGraficos["q0"])
            {
                g.Clear(Color.White);
                g.DrawEllipse(mypen, 0, 0, 50, 50);
                g.DrawString("q0", new Font("Verdana", 15), Brushes.Black, 10, 10);
                estadosGraficos["q0"] = false;
            }
            else
            {
                g.DrawEllipse(mypen, 5, 5, 40, 40);
                estadosGraficos["q0"] = true;
            }         
            estadoInicialGrafico.Image = imagen;
            g.Dispose();
        }

        private void alfabetoGrafico_TextChanged(object sender, EventArgs e)
        {

        }
        private string estadoTocado="";
        private void estadoInicialGrafico_MouseDown(object sender, MouseEventArgs e)
        {
            estadoTocado = "q0";
            alfabetoGrafico.Text = "down";
        }

        private void tabPage2_MouseUp(object sender, MouseEventArgs e)
        {          
            if (estadoTocado != "" && (e.X> estadoInicialGrafico.Location.X+60)
                 ^ (e.Y<estadoInicialGrafico.Location.Y-250|| e.Y > estadoInicialGrafico.Location.Y - 140))
            {
                var picture = new PictureBox
                {
                    Name = "q2",
                    Size = new Size(56, 56),
                    Location = new Point(e.X, e.Y+200),
                    Image = (Image)DrawArea.Clone(),
                };
                tabPage2.Controls.Add(picture);
                alfabetoGrafico.Text = "up";
            }
        }
    }
}
