namespace JuegoCalculoNumerico
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
            this.components = new System.ComponentModel.Container();
            this.lbPuntos = new System.Windows.Forms.Label();
            this.lbTiempo = new System.Windows.Forms.Label();
            this.lbNumUno = new System.Windows.Forms.Label();
            this.lbOperador = new System.Windows.Forms.Label();
            this.lbNumDos = new System.Windows.Forms.Label();
            this.tbRespuesta = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbJugador = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbRespuesta = new System.Windows.Forms.Label();
            this.lbJugador = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericValores = new System.Windows.Forms.NumericUpDown();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.rbSuma = new System.Windows.Forms.RadioButton();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.cbRegenerar = new System.Windows.Forms.CheckBox();
            this.cbTiempo = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericValores)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPuntos
            // 
            this.lbPuntos.AutoSize = true;
            this.lbPuntos.BackColor = System.Drawing.Color.White;
            this.lbPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPuntos.Location = new System.Drawing.Point(23, 67);
            this.lbPuntos.Name = "lbPuntos";
            this.lbPuntos.Size = new System.Drawing.Size(29, 31);
            this.lbPuntos.TabIndex = 0;
            this.lbPuntos.Text = "0";
            // 
            // lbTiempo
            // 
            this.lbTiempo.AutoSize = true;
            this.lbTiempo.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiempo.Location = new System.Drawing.Point(303, 67);
            this.lbTiempo.Name = "lbTiempo";
            this.lbTiempo.Size = new System.Drawing.Size(44, 31);
            this.lbTiempo.TabIndex = 1;
            this.lbTiempo.Text = "30";
            // 
            // lbNumUno
            // 
            this.lbNumUno.AutoSize = true;
            this.lbNumUno.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbNumUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumUno.Location = new System.Drawing.Point(76, 158);
            this.lbNumUno.Name = "lbNumUno";
            this.lbNumUno.Size = new System.Drawing.Size(29, 31);
            this.lbNumUno.TabIndex = 2;
            this.lbNumUno.Text = "0";
            // 
            // lbOperador
            // 
            this.lbOperador.AutoSize = true;
            this.lbOperador.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperador.Location = new System.Drawing.Point(164, 158);
            this.lbOperador.Name = "lbOperador";
            this.lbOperador.Size = new System.Drawing.Size(30, 31);
            this.lbOperador.TabIndex = 3;
            this.lbOperador.Text = "+";
            // 
            // lbNumDos
            // 
            this.lbNumDos.AutoSize = true;
            this.lbNumDos.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbNumDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumDos.Location = new System.Drawing.Point(257, 158);
            this.lbNumDos.Name = "lbNumDos";
            this.lbNumDos.Size = new System.Drawing.Size(29, 31);
            this.lbNumDos.TabIndex = 4;
            this.lbNumDos.Text = "0";
            // 
            // tbRespuesta
            // 
            this.tbRespuesta.Location = new System.Drawing.Point(105, 240);
            this.tbRespuesta.Name = "tbRespuesta";
            this.tbRespuesta.Size = new System.Drawing.Size(146, 26);
            this.tbRespuesta.TabIndex = 5;
            this.tbRespuesta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSolucion_KeyUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbJugador
            // 
            this.tbJugador.Enabled = false;
            this.tbJugador.Location = new System.Drawing.Point(111, 72);
            this.tbJugador.Name = "tbJugador";
            this.tbJugador.Size = new System.Drawing.Size(146, 26);
            this.tbJugador.TabIndex = 6;
            this.tbJugador.Visible = false;
            this.tbJugador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbJugador_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbRespuesta);
            this.groupBox1.Controls.Add(this.lbJugador);
            this.groupBox1.Controls.Add(this.lbTiempo);
            this.groupBox1.Controls.Add(this.tbJugador);
            this.groupBox1.Controls.Add(this.lbPuntos);
            this.groupBox1.Controls.Add(this.tbRespuesta);
            this.groupBox1.Controls.Add(this.lbNumUno);
            this.groupBox1.Controls.Add(this.lbNumDos);
            this.groupBox1.Controls.Add(this.lbOperador);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(446, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 295);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Juego";
            // 
            // lbRespuesta
            // 
            this.lbRespuesta.AutoSize = true;
            this.lbRespuesta.Location = new System.Drawing.Point(107, 217);
            this.lbRespuesta.Name = "lbRespuesta";
            this.lbRespuesta.Size = new System.Drawing.Size(91, 20);
            this.lbRespuesta.TabIndex = 8;
            this.lbRespuesta.Text = "Respuesta:";
            // 
            // lbJugador
            // 
            this.lbJugador.AutoSize = true;
            this.lbJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJugador.Location = new System.Drawing.Point(108, 49);
            this.lbJugador.Name = "lbJugador";
            this.lbJugador.Size = new System.Drawing.Size(71, 20);
            this.lbJugador.TabIndex = 7;
            this.lbJugador.Text = "Jugador:";
            this.lbJugador.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.cbTiempo);
            this.groupBox2.Controls.Add(this.cbRegenerar);
            this.groupBox2.Controls.Add(this.rbTodas);
            this.groupBox2.Controls.Add(this.rbSuma);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericValores);
            this.groupBox2.Controls.Add(this.btnIniciar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 295);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Operaciones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rango numérico:";
            // 
            // numericValores
            // 
            this.numericValores.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericValores.Location = new System.Drawing.Point(23, 56);
            this.numericValores.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericValores.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericValores.Name = "numericValores";
            this.numericValores.Size = new System.Drawing.Size(120, 26);
            this.numericValores.TabIndex = 1;
            this.numericValores.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(135, 228);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(122, 32);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar Partida";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            this.btnIniciar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // rbSuma
            // 
            this.rbSuma.AutoSize = true;
            this.rbSuma.Checked = true;
            this.rbSuma.Location = new System.Drawing.Point(232, 51);
            this.rbSuma.Name = "rbSuma";
            this.rbSuma.Size = new System.Drawing.Size(69, 24);
            this.rbSuma.TabIndex = 6;
            this.rbSuma.TabStop = true;
            this.rbSuma.Text = "Suma";
            this.rbSuma.UseVisualStyleBackColor = true;
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Location = new System.Drawing.Point(232, 75);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(71, 24);
            this.rbTodas.TabIndex = 7;
            this.rbTodas.Text = "Todas";
            this.rbTodas.UseVisualStyleBackColor = true;
            // 
            // cbRegenerar
            // 
            this.cbRegenerar.AutoSize = true;
            this.cbRegenerar.Location = new System.Drawing.Point(23, 131);
            this.cbRegenerar.Name = "cbRegenerar";
            this.cbRegenerar.Size = new System.Drawing.Size(304, 24);
            this.cbRegenerar.TabIndex = 8;
            this.cbRegenerar.Text = "Regenerar operacion cada 5 segundos";
            this.cbRegenerar.UseVisualStyleBackColor = true;
            // 
            // cbTiempo
            // 
            this.cbTiempo.AutoSize = true;
            this.cbTiempo.Location = new System.Drawing.Point(23, 158);
            this.cbTiempo.Name = "cbTiempo";
            this.cbTiempo.Size = new System.Drawing.Size(319, 24);
            this.cbTiempo.TabIndex = 9;
            this.cbTiempo.Text = "Aciertos suman tiempo y Fallos penalizan";
            this.cbTiempo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Puntos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tiempo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(844, 341);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericValores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbPuntos;
        private System.Windows.Forms.Label lbTiempo;
        private System.Windows.Forms.Label lbNumUno;
        private System.Windows.Forms.Label lbOperador;
        private System.Windows.Forms.Label lbNumDos;
        private System.Windows.Forms.TextBox tbRespuesta;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbJugador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.NumericUpDown numericValores;
        private System.Windows.Forms.Label lbJugador;
        private System.Windows.Forms.Label lbRespuesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbTodas;
        private System.Windows.Forms.RadioButton rbSuma;
        private System.Windows.Forms.CheckBox cbRegenerar;
        private System.Windows.Forms.CheckBox cbTiempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

