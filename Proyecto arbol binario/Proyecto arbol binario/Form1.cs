using System;
using System.Windows.Forms;

namespace Proyecto_arbol_binario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exprecionAArbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirPanel(new Ventanas.PanelExprecionArbol());
            label2.Visible = false;
        }

        private void abrirPanel(Object frame)
        {
            if (panelCambio.Controls.Count > 0)
            {
                panelCambio.Controls.RemoveAt(0);
            }

            Form fh = frame as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            panelCambio.Controls.Add(fh);
            panelCambio.Tag = fh;
            fh.Show();

        }

        private void arbolBinarioExprecionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirPanel(new Prueba1_Arbol_A_Exprecion.Form1());
            label2.Visible = false;
        }
    }
}
