namespace automataFinitoDeterminista
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.alfabetoBtn = new System.Windows.Forms.TextBox();
            this.EstadoInicialBtn = new System.Windows.Forms.TextBox();
            this.estadosNoFinalesBtn = new System.Windows.Forms.TextBox();
            this.EstadosFinalesBtn = new System.Windows.Forms.TextBox();
            this.InicialEsFinal = new System.Windows.Forms.CheckBox();
            this.deltaBtn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GenerarButon = new System.Windows.Forms.Button();
            this.palabraTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comprobarBTn = new System.Windows.Forms.Button();
            this.Respuesta = new System.Windows.Forms.Label();
            this.tableControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tablero = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.AlfabetoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.tableControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablero)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese alfabeto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingrese estados no finales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ingrese estados finales";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ingrese estado inicial";
            // 
            // alfabetoBtn
            // 
            this.alfabetoBtn.Location = new System.Drawing.Point(256, 32);
            this.alfabetoBtn.Name = "alfabetoBtn";
            this.alfabetoBtn.Size = new System.Drawing.Size(168, 20);
            this.alfabetoBtn.TabIndex = 2;
            this.alfabetoBtn.Text = "1234";
            this.alfabetoBtn.TextChanged += new System.EventHandler(this.alfabetoBtn_TextChanged);
            // 
            // EstadoInicialBtn
            // 
            this.EstadoInicialBtn.Location = new System.Drawing.Point(256, 64);
            this.EstadoInicialBtn.Name = "EstadoInicialBtn";
            this.EstadoInicialBtn.Size = new System.Drawing.Size(168, 20);
            this.EstadoInicialBtn.TabIndex = 2;
            this.EstadoInicialBtn.Text = "a";
            // 
            // estadosNoFinalesBtn
            // 
            this.estadosNoFinalesBtn.Location = new System.Drawing.Point(256, 96);
            this.estadosNoFinalesBtn.Name = "estadosNoFinalesBtn";
            this.estadosNoFinalesBtn.Size = new System.Drawing.Size(168, 20);
            this.estadosNoFinalesBtn.TabIndex = 2;
            this.estadosNoFinalesBtn.Text = "bcdef";
            // 
            // EstadosFinalesBtn
            // 
            this.EstadosFinalesBtn.Location = new System.Drawing.Point(256, 128);
            this.EstadosFinalesBtn.Name = "EstadosFinalesBtn";
            this.EstadosFinalesBtn.Size = new System.Drawing.Size(168, 20);
            this.EstadosFinalesBtn.TabIndex = 2;
            this.EstadosFinalesBtn.Text = "hig";
            // 
            // InicialEsFinal
            // 
            this.InicialEsFinal.AutoSize = true;
            this.InicialEsFinal.Location = new System.Drawing.Point(447, 66);
            this.InicialEsFinal.Name = "InicialEsFinal";
            this.InicialEsFinal.Size = new System.Drawing.Size(60, 17);
            this.InicialEsFinal.TabIndex = 3;
            this.InicialEsFinal.Text = "Es final";
            this.InicialEsFinal.UseVisualStyleBackColor = true;
            // 
            // deltaBtn
            // 
            this.deltaBtn.Location = new System.Drawing.Point(256, 164);
            this.deltaBtn.Name = "deltaBtn";
            this.deltaBtn.Size = new System.Drawing.Size(168, 20);
            this.deltaBtn.TabIndex = 4;
            this.deltaBtn.Text = "a1b,a2c,b2c,c3d,d4g";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ingrese deltas";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // GenerarButon
            // 
            this.GenerarButon.Location = new System.Drawing.Point(177, 250);
            this.GenerarButon.Name = "GenerarButon";
            this.GenerarButon.Size = new System.Drawing.Size(127, 23);
            this.GenerarButon.TabIndex = 5;
            this.GenerarButon.Text = "Generar Automata";
            this.GenerarButon.UseVisualStyleBackColor = true;
            this.GenerarButon.Click += new System.EventHandler(this.button1_Click);
            // 
            // palabraTb
            // 
            this.palabraTb.Location = new System.Drawing.Point(256, 327);
            this.palabraTb.Name = "palabraTb";
            this.palabraTb.Size = new System.Drawing.Size(168, 20);
            this.palabraTb.TabIndex = 6;
            this.palabraTb.Text = "1234";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ingrese cadena";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(458, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "s.a.s,";
            // 
            // comprobarBTn
            // 
            this.comprobarBTn.Location = new System.Drawing.Point(378, 370);
            this.comprobarBTn.Name = "comprobarBTn";
            this.comprobarBTn.Size = new System.Drawing.Size(103, 62);
            this.comprobarBTn.TabIndex = 9;
            this.comprobarBTn.Text = "Comprobar";
            this.comprobarBTn.UseVisualStyleBackColor = true;
            this.comprobarBTn.Click += new System.EventHandler(this.comprobarBTn_Click);
            // 
            // Respuesta
            // 
            this.Respuesta.AutoSize = true;
            this.Respuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Respuesta.Location = new System.Drawing.Point(137, 386);
            this.Respuesta.Name = "Respuesta";
            this.Respuesta.Size = new System.Drawing.Size(0, 25);
            this.Respuesta.TabIndex = 10;
            // 
            // tableControl1
            // 
            this.tableControl1.Controls.Add(this.tabPage1);
            this.tableControl1.Controls.Add(this.tabPage2);
            this.tableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableControl1.Location = new System.Drawing.Point(0, 0);
            this.tableControl1.Name = "tableControl1";
            this.tableControl1.SelectedIndex = 0;
            this.tableControl1.Size = new System.Drawing.Size(1232, 527);
            this.tableControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Respuesta);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comprobarBTn);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.palabraTb);
            this.tabPage1.Controls.Add(this.alfabetoBtn);
            this.tabPage1.Controls.Add(this.GenerarButon);
            this.tabPage1.Controls.Add(this.EstadoInicialBtn);
            this.tabPage1.Controls.Add(this.deltaBtn);
            this.tabPage1.Controls.Add(this.estadosNoFinalesBtn);
            this.tabPage1.Controls.Add(this.InicialEsFinal);
            this.tabPage1.Controls.Add(this.EstadosFinalesBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1224, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.tablero);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1224, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grafico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 19);
            this.button1.TabIndex = 5;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tablero
            // 
            this.tablero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablero.Location = new System.Drawing.Point(3, 28);
            this.tablero.Name = "tablero";
            this.tablero.Size = new System.Drawing.Size(1218, 470);
            this.tablero.TabIndex = 4;
            this.tablero.TabStop = false;
            this.tablero.Click += new System.EventHandler(this.tablero_Click);
            this.tablero.DoubleClick += new System.EventHandler(this.tablero_DoubleClick);
            this.tablero.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tablero_MouseDown);
            this.tablero.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.tablero.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tablero_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.AlfabetoToolStripTextBox,
            this.toolStripLabel2,
            this.toolStripTextBox2,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1218, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(52, 22);
            this.toolStripLabel1.Text = "Alfabeto";
            // 
            // AlfabetoToolStripTextBox
            // 
            this.AlfabetoToolStripTextBox.Name = "AlfabetoToolStripTextBox";
            this.AlfabetoToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            this.AlfabetoToolStripTextBox.Click += new System.EventHandler(this.AlfabetoToolStripTextBox_Click);
            this.AlfabetoToolStripTextBox.TextChanged += new System.EventHandler(this.AlfabetoToolStripTextBox_TextChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(46, 22);
            this.toolStripLabel2.Text = "palabra";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(0, 22);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1141, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 6;
            this.button2.Text = "borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 527);
            this.Controls.Add(this.tableControl1);
            this.Name = "Form1";
            this.Text = "Frank Orozco Automata Finito Determinista ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablero)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox alfabetoBtn;
        private System.Windows.Forms.TextBox EstadoInicialBtn;
        private System.Windows.Forms.TextBox estadosNoFinalesBtn;
        private System.Windows.Forms.TextBox EstadosFinalesBtn;
        private System.Windows.Forms.CheckBox InicialEsFinal;
        private System.Windows.Forms.TextBox deltaBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GenerarButon;
        private System.Windows.Forms.TextBox palabraTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button comprobarBTn;
        private System.Windows.Forms.Label Respuesta;
        private System.Windows.Forms.TabControl tableControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox tablero;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox AlfabetoToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.Button button2;
    }
}

