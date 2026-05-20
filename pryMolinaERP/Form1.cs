using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static pryMolinaERP.clsConexion;

namespace pryMolinaERP
{
    public partial class Form1 : Form
    {
        private readonly UsuarioInfo _usuario;
        
        // Constructor principal: recibe los datos del usuario autenticado
        public Form1(UsuarioInfo usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ── 1. Mostrar bienvenida con datos reales de la BD ───────────────
            if (_usuario != null)
            {
                lblBienvenida.Text =
                    $"Bienvenido: {_usuario.NombreCompleto}   |   " +
                    $"Perfil: {_usuario.Perfil}   |   " +
                    $"Ingreso: {_usuario.FechaIngreso:dd/MM/yyyy HH:mm:ss}";
            }

            // ── 2. Probar conexión con animación de ProgressBar ───────────────
            IniciarProgresoConexion();
        }

        private void IniciarProgresoConexion()
        {
            toolStripStatusLabel1.Text = "Conectando a la base de datos...";
            toolStripStatusLabel1.ForeColor = Color.DarkGoldenrod;
            toolStripStatusLabel1.BackColor = Color.Transparent;
            progressBarConexion.Visible = true;
            progressBarConexion.Value = 0;

            Thread hilo = new Thread(() =>
            {
                // Animación 0 → 80
                for (int i = 0; i <= 80; i += 10)
                {
                    Thread.Sleep(80);
                    int valor = i;
                    this.Invoke((MethodInvoker)(() => progressBarConexion.Value = valor));
                }

                // Prueba real de conexión
                clsConexion conexion = new clsConexion();
                bool conectado = conexion.ProbarConexion();

                this.Invoke((MethodInvoker)(() =>
                {
                    progressBarConexion.Value = 100;

                    if (conectado)
                    {
                        toolStripStatusLabel1.Text = "● Conectado a la base de datos";
                        toolStripStatusLabel1.ForeColor = Color.White;
                        toolStripStatusLabel1.BackColor = Color.Green;
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "● Sin conexión a la base de datos";
                        toolStripStatusLabel1.ForeColor = Color.White;
                        toolStripStatusLabel1.BackColor = Color.Red;
                    }

                    progressBarConexion.Visible = false;
                }));
            });

            hilo.IsBackground = true;
            hilo.Start();
        }

        // Clic en el label de estado → reconectar manualmente
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            IniciarProgresoConexion();
        }
    }
}
