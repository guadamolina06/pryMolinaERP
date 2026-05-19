using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMolinaERP
{
    public partial class Form1 : Form
    {
        StatusStrip barraEstado = new StatusStrip();
        ToolStripStatusLabel textoEstado = new ToolStripStatusLabel();
        public Form1()
        {
            InitializeComponent();
            textoEstado.Text = "Programa iniciado";

            // Agregar texto a la barra
            barraEstado.Items.Add(textoEstado);

            // Agregar barra al formulario
            this.Controls.Add(barraEstado);
            
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            clsConexion objectoConeccionBaseDatos = new clsConexion();
            objectoConeccionBaseDatos.ConectarBaseDatos();

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
