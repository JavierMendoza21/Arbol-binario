using Proyecto_arbol_binario.Configuracion;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_arbol_binario.Ventanas
{
    public partial class PanelExprecionArbol : Form
    {
        Nodo raiz;

        public PanelExprecionArbol()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String termino = txtExprecion.Text;
            termino = termino.Replace(" ", "");
            Proyecto_arbol_binario.Logica.SepararTerminos primerPaso = new Proyecto_arbol_binario.Logica.SepararTerminos(termino);

            Configuracion.Adaptador segundoPaso = new Configuracion.Adaptador(primerPaso.getPilaTerminos());

            raiz = segundoPaso.getRaiz();
            panelDibujo.Refresh();
        }
        //int cont = 0;
        private void panelDibujo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int ancho = panelDibujo.Width / 2;


            if (raiz != null)
            {
                //txtMensage.Text = "se pinto : " + cont++;
                dibujarNodo(g, raiz, ancho, 20, 20);
            }
            else
                return;

        }

        private void dibujarNodo(Graphics g, Nodo n, int x, int y, int ancho)
        {
            //(((1*(3-3))+((2*5)-5))*((3-4)/(3*7)))

            if (n != null)
            {
                //Console.Beep();
                int extra = n.nodosCompletos(n) * (30);
                //int extra = 0;
                g.DrawEllipse(Pens.Black, x, y, ancho, ancho);
                g.DrawString(n.ToString(), new Font(FontFamily.GenericSansSerif, 12), Brushes.Black, new PointF(x + 5, y));
                //izquierda
                if (n.izq != null)
                {
                    g.DrawLine(Pens.Red, x + 10, y + 20, (x - 50 - extra + 10), y + 30);
                    panelDibujo.Width += 50;
                    dibujarNodo(g, n.izq, (x - 50 - extra), y + 30, ancho);

                }
                //derecha                
                if (n.Der != null)
                {
                    g.DrawLine(Pens.Blue, (x + 10), y + 20, x + 50 + extra + 10, y + 30);
                    panelDibujo.Width += 50;
                    dibujarNodo(g, n.Der, (x + 50 + extra), y + 30, ancho);
                }
                //n = null;
                raiz = null;
                //MessageBox.Show("Termino de dibujarse");
            }
            else
            {
                return;
            }
        }
    }
}
