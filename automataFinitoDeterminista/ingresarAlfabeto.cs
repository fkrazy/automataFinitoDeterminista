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
    public partial class ingresarAlfabeto : Form
    {
        public static List<char> alfabeto;
        public ingresarAlfabeto(List<char> letras)
        {
            InitializeComponent();
            alfabeto.AddRange(letras);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] letrasDelCamino = textBox1.Text.ToCharArray();
            if (alfabeto.Count < 0)
                alfabeto.AddRange(letrasDelCamino);
            else
                foreach (char letra in letrasDelCamino)
                {
                    bool existe = false;
                    foreach (char letraAlfabeto in alfabeto)
                    {
                        if (letra == letraAlfabeto)
                        {
                            existe = true;
                            break;
                        }
                        if (!existe)
                            alfabeto.Add(letra);
                    }
                }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void ingresarAlfabeto_Load(object sender, EventArgs e)
        {

        }
    }
}
