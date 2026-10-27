using System;
using System.Windows.Forms;

// Yariela Padilla Badilla 
// Proyecto de Juego de Aritmetica
namespace ProyectoJuego0
{
    public partial class Form1 : Form
    {
        // 1. DECLARACIÓN DE VARIABLES Y ARREGLOS
        float a = 0, b = 0, rresultado = 0;
        int opee = 0, Limite = 11;
        char operador = ' ';

        // Control de turnos (false para el Jugador 1, true para el Jugador 2)
        bool jugador = false;

        // Arreglos estáticos requeridos para la persistencia y tabla de clasificación (Punto 4)
        const int MAX = 5;
        string[] nombresArr = new string[MAX];
        int[] puntajesArr = new int[MAX];
        int totalRegistrados = 0;

        // Temporizador para el límite de 10 segundos por turno
        System.Windows.Forms.Timer temporizadorTurno = new System.Windows.Forms.Timer();
        int segundosRestantes = 10;

        public Form1()
        {
            InitializeComponent();
            ConfigurarTemporizador();
        }

        // 2. CONFIGURACIÓN DEL TEMPORIZADOR
        private void ConfigurarTemporizador()
        {
            temporizadorTurno.Interval = 1000;
            temporizadorTurno.Tick += TemporizadorTurno_Tick;
        }

        private void TemporizadorTurno_Tick(object sender, EventArgs e)
        {
            segundosRestantes--;

            if (segundosRestantes <= 0)
            {
                temporizadorTurno.Stop();
                MessageBox.Show("¡Se acabó el tiempo para responder!", "Tiempo Agotado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                bool dosJugadores = radioButton2.Checked;

                if (jugador == false)
                {
                    int err1 = int.Parse(lerrores.Text) + 1;
                    lerrores.Text = err1.ToString();

                    if (err1 >= 3)
                    {
                        MessageBox.Show("¡Juego Terminado para Jugador 1!", "Fin del Juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GuardarPuntaje("Jugador 1", int.Parse(laciertos.Text));
                        ReiniciarPartida();
                        return;
                    }

                    if (dosJugadores) jugador = true;
                }
                else
                {
                    int err2 = int.Parse(lerrores2.Text) + 1;
                    lerrores2.Text = err2.ToString();

                    if (err2 >= 3)
                    {
                        MessageBox.Show("¡Juego Terminado para Jugador 2!", "Fin del Juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GuardarPuntaje("Jugador 2", int.Parse(laciertos2.Text));
                        ReiniciarPartida();
                        return;
                    }

                    if (dosJugadores) jugador = false;
                }

                tresultado.Clear();
                Seleccion_Operacion();
            }
        }

        // 3. EVENTO DE CARGA DEL FORMULARIO
        private void Form1_Load(object sender, EventArgs e)
        {
            Seleccion_Operacion();
        }

        // 4. MÓDULO MATEMÁTICO, ESCALABILIDAD DINÁMICA Y TIMER
        private void Seleccion_Operacion()
        {
            // Requerimiento 2: Escalabilidad de Complejidad Dinámica en función del progreso
            int aciertosTotales = int.Parse(laciertos.Text) + int.Parse(laciertos2.Text);
            if (aciertosTotales >= 6)
            {
                Limite = 101; // Nivel avanzado
            }
            else if (aciertosTotales >= 3)
            {
                Limite = 51;  // Nivel intermedio
            }
            else
            {
                Limite = 11;  // Nivel inicial
            }

            a = Random.Shared.Next(1, Limite);
            b = Random.Shared.Next(1, Limite);
            opee = Random.Shared.Next(1, 5);

            switch (opee)
            {
                case 1:
                    operador = '+';
                    rresultado = a + b;
                    break;
                case 2:
                    operador = '-';
                    rresultado = a - b;
                    break;
                case 3:
                    operador = '*';
                    rresultado = a * b;
                    break;
                case 4:
                    operador = '/';
                    rresultado = a / b;
                    break;
            }

            num1.Text = a.ToString();
            num2.Text = b.ToString();
            op.Text = operador.ToString();

            segundosRestantes = 10;
            temporizadorTurno.Start();
        }

        // 5. EVENTO DEL BOTÓN ACEPTAR
        private void baceptar_Click(object sender, EventArgs e)
        {
            temporizadorTurno.Stop();

            if (string.IsNullOrWhiteSpace(tresultado.Text))
            {
                MessageBox.Show("Por favor ingresa un resultado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                temporizadorTurno.Start();
                return;
            }

            if (!float.TryParse(tresultado.Text, out float resUsuario))
            {
                MessageBox.Show("Por favor ingresa solo números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tresultado.Clear();
                temporizadorTurno.Start();
                return;
            }

            bool dosJugadores = radioButton2.Checked;

            if (Math.Abs(resUsuario - rresultado) < 0.01f)
            {
                MessageBox.Show("¡Correcto!");

                if (jugador == false)
                {
                    laciertos.Text = (int.Parse(laciertos.Text) + 1).ToString();
                    if (dosJugadores) jugador = true;
                }
                else
                {
                    laciertos2.Text = (int.Parse(laciertos2.Text) + 1).ToString();
                    if (dosJugadores) jugador = false;
                }
            }
            else
            {
                MessageBox.Show("Incorrecto");

                if (jugador == false)
                {
                    int err1 = int.Parse(lerrores.Text) + 1;
                    lerrores.Text = err1.ToString();

                    if (err1 >= 3)
                    {
                        MessageBox.Show("¡Juego Terminado! Límite de errores alcanzado.", "Fin del Juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GuardarPuntaje("Jugador 1", int.Parse(laciertos.Text));
                        ReiniciarPartida();
                        return;
                    }

                    if (dosJugadores) jugador = true;
                }
                else
                {
                    int err2 = int.Parse(lerrores2.Text) + 1;
                    lerrores2.Text = err2.ToString();

                    if (err2 >= 3)
                    {
                        MessageBox.Show("¡Juego Terminado! Límite de errores alcanzado.", "Fin del Juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GuardarPuntaje("Jugador 2", int.Parse(laciertos2.Text));
                        ReiniciarPartida();
                        return;
                    }

                    if (dosJugadores) jugador = false;
                }
            }

            tresultado.Clear();
            Seleccion_Operacion();
        }

        // 6. MÉTODOS PARA ARREGLOS Y ORDENAMIENTO (Requerimiento 4)
        private void GuardarPuntaje(string nombre, int puntaje)
        {
            if (totalRegistrados < MAX)
            {
                nombresArr[totalRegistrados] = nombre;
                puntajesArr[totalRegistrados] = puntaje;
                totalRegistrados++;
            }
            else
            {
                if (puntaje > puntajesArr[MAX - 1])
                {
                    nombresArr[MAX - 1] = nombre;
                    puntajesArr[MAX - 1] = puntaje;
                }
            }

            OrdenarBubbleSort();
            ActualizarTablaVisual();
        }

        private void OrdenarBubbleSort()
        {
            for (int i = 0; i < totalRegistrados - 1; i++)
            {
                for (int j = 0; j < totalRegistrados - i - 1; j++)
                {
                    if (puntajesArr[j] < puntajesArr[j + 1])
                    {
                        int tempP = puntajesArr[j];
                        puntajesArr[j] = puntajesArr[j + 1];
                        puntajesArr[j + 1] = tempP;

                        string tempN = nombresArr[j];
                        nombresArr[j] = nombresArr[j + 1];
                        nombresArr[j + 1] = tempN;
                    }
                }
            }
        }

        private void ActualizarTablaVisual()
        {
            // Nota: Si deseas mostrarlo visualmente, agrega un ListBox en tu Formulario llamado 'lstClasificacion'
            if (Controls.ContainsKey("lstClasificacion"))
            {
                ListBox lst = (ListBox)Controls["lstClasificacion"];
                lst.Items.Clear();
                for (int i = 0; i < totalRegistrados; i++)
                {
                    lst.Items.Add($"{i + 1}. {nombresArr[i]} - Aciertos: {puntajesArr[i]}");
                }
            }
        }

        private void ReiniciarPartida()
        {
            laciertos.Text = "0";
            lerrores.Text = "0";
            laciertos2.Text = "0";
            lerrores2.Text = "0";
            jugador = false;
            Limite = 11;
        }
    }
}