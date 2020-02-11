using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoCalculoNumerico
{
    public partial class Form1 : Form
    {
        int segundos, puntos, solucion, segundero;
        Random aleatorio = new Random();
        MySqlConnection conexion = new MySqlConnection();
        public Form1()
        {
            InitializeComponent();
            segundos = 30;
            puntos = 0;
            btnIniciar.Focus();

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //La partida empieza al pulsar espacio
            if (e.KeyChar == (char)Keys.Space)
            {
                groupBox1.Enabled = true;
                tbRespuesta.Visible = true;
                tbRespuesta.Enabled = true;
                tbRespuesta.Focus();
                lbRespuesta.Visible = true;
                timer1.Enabled = true;
                generarPartida();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Programacion de cuenta atrás
            segundos--;
            lbTiempo.Text = Convert.ToString(segundos);
            if (segundos == 0)
            {
                timer1.Enabled = false;
                tbRespuesta.Enabled = false;
                lbJugador.Visible = true;
                tbJugador.Visible = true;
                tbJugador.Enabled = true;
                tbJugador.Focus();
                
            }

            //Operación nueva cada 5 segundos si el checkbox esta activo
            if (cbRegenerar.Checked)
            {
                segundero++;
                if (segundero == 5)
                {
                    generarPartida();
                    segundero = 0;
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Conexion a base de datos
            conexion.ConnectionString = "Server=remotemysql.com;Database=Pr1mdxAdrh;Uid=Pr1mdxAdrh;pwd=fNBUrxid1O";
        }

        private void tbJugador_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Introducir puntuacion en BD al pulsar intro
                conexion.Open();
                String cadenasql = "insert into ranking values(Npartidas,?nombre, ?fecha, ?puntos)";
                MySqlCommand comando = new MySqlCommand(cadenasql, conexion);
                comando.Parameters.Add("?nombre", MySqlDbType.String).Value=tbJugador.Text;
                comando.Parameters.Add("?fecha", MySqlDbType.DateTime).Value = DateTime.Now;
                comando.Parameters.Add("?puntos", MySqlDbType.Int32).Value = puntos;
                comando.ExecuteNonQuery();
                conexion.Close();

                groupBox2.Enabled = true;
                groupBox1.Enabled = false;
                lbJugador.Visible = false;
                tbJugador.Enabled = false;
                tbJugador.Visible = false;
                btnIniciar.Focus();

            }

            //Salir al menu al pulsar Escape
            if (e.KeyCode == Keys.Escape)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                timer1.Enabled = false;
                segundos = 30;
                segundero = 0;
                puntos = 0;
                lbNumUno.Text = "0";
                lbNumDos.Text = "0";
                lbOperador.Text = "+";
                lbPuntos.Text = "0";
                lbTiempo.Text = "30";
                lbJugador.Visible = false;
                tbJugador.Enabled = false;
                tbJugador.Visible = false;
                btnIniciar.Focus();
            }

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Iniciar partida al clickar sobre boton
            groupBox1.Enabled = true;
            tbRespuesta.Visible = true;
            tbRespuesta.Enabled = true;
            tbRespuesta.Focus();
            lbRespuesta.Visible = true;
            timer1.Enabled = true;
            generarPartida();
        }

        private void tbSolucion_KeyUp(object sender, KeyEventArgs e)
        {
            //Recoger respuesta del textbox al pulsar intro y comprobar si es correcta
            if(e.KeyCode == Keys.Enter)
            {
                int miNumero = Convert.ToInt32(tbRespuesta.Text);
                if (solucion == miNumero)
                {
                    puntos++;
                    lbPuntos.Text = Convert.ToString(puntos);
                    puntosSumanRestan(miNumero);
                    generarPartida();
                }else
                {
                    puntos--;
                    lbPuntos.Text = Convert.ToString(puntos);
                    puntosSumanRestan(miNumero);
                    generarPartida();
                }
                
                tbRespuesta.Text = "";
                colorearPuntacion();
            }
            //Salir al menu al pulsar Escape
            if(e.KeyCode == Keys.Escape)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                timer1.Enabled = false;
                segundos = 30;
                segundero = 0;
                puntos = 0;
                lbNumUno.Text = "0";
                lbNumDos.Text = "0";
                lbOperador.Text = "+";
                lbPuntos.Text = "0";
                lbTiempo.Text = "30";
                lbJugador.Visible = false;
                tbJugador.Enabled = false;
                tbJugador.Visible = false;
                btnIniciar.Focus();
            }
        }

        private void generarPartida()
        {
            //Generar datos de partida (numeros y operaciones)
            groupBox2.Enabled = false;

            int operador = aleatorio.Next(3);

            int numUno = aleatorio.Next(Convert.ToInt32(numericValores.Value));
            int numDos = aleatorio.Next(Convert.ToInt32(numericValores.Value));
            lbNumUno.Text = Convert.ToString(numUno);
            lbNumDos.Text = Convert.ToString(numDos);
            //Cambiar operador en funcion de los radiobutton
            if (rbSuma.Checked)
            {
                solucion = numUno + numDos;
                lbOperador.Text = "+";
            }else if(rbTodas.Checked){

                switch (operador)
                {
                    case 0:
                        solucion = numUno + numDos;
                        lbOperador.Text = "+";
                        break;
                    case 1:
                        solucion = numUno * numDos;
                        lbOperador.Text = "x";
                        break;
                    case 2:
                        solucion = numUno - numDos;
                        lbOperador.Text = "-";
                        break;
                }

            }


        }

        private void colorearPuntacion()
        {
            //Cambiar color de cuadro de puntos en función de puntuación
            if (puntos < 0)
            {
                lbPuntos.BackColor = Color.Red;
            }else if(puntos == 0)
            {
                lbPuntos.BackColor = Color.White;
            }else
            {
                lbPuntos.BackColor = Color.LawnGreen;
            }
        }

        private void puntosSumanRestan(int miNumero)
        {
            //Sumar y restar al contador si el checkbox esta seleccionado
            if (cbTiempo.Checked)
            {
                if (solucion == miNumero)
                {
                    segundos += 5;
                }
                else
                {
                    segundos -= 2;
                }
            }
            
        }
    }
}
