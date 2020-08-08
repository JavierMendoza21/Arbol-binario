using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace Prueba1_Arbol_A_Exprecion
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            evento();

        }

        private void evento()
        {
            panelLienzo.Controls.OfType<Nodo>().ToList().ForEach(ctr =>
            {
                ctr.MouseDown -= Ctr_MouseDown;
                ctr.MouseUp -= Ctr_MouseUp;
                ctr.MouseMove -= Ctr_MouseMove;

                ctr.MouseDown += Ctr_MouseDown;
                ctr.MouseUp += Ctr_MouseUp;
                ctr.MouseMove += Ctr_MouseMove;

            });

        }
        Nodo Raiz;
        String mayor = "";
        private void calcularRaiz()
        {

            panelLienzo.Controls.OfType<Nodo>().ToList().ForEach(ctr =>
            {
                String str = Nodo.imprimirNodo((Nodo)ctr);
                if (str.Length > mayor.Length)
                {
                    Raiz = ctr;
                    mayor = str;
                }

            });
        }

        bool abajo = false;
        Point inicial;
        bool dibujar = true;
        private void Ctr_MouseMove(object sender, MouseEventArgs e)
        {
            Control ctr = (Control)sender;

            if (abajo && dibujar)
            {
                ctr.Left += -inicial.X + e.X;
                ctr.Top += -inicial.Y + e.Y;
                ctr.Location = new Point(ctr.Left, ctr.Top);
            }
        }

        private void Ctr_MouseUp(object sender, MouseEventArgs e)
        {
            abajo = false;
            Control ctr = (Control)sender;

        }

        Point control1;
        bool c1 = true;
        Nodo aux1 = null;
        Nodo aux2 = null;
        Point control2;
        bool c2 = false;

        private void Ctr_MouseDown(object sender, MouseEventArgs e)
        {
            Nodo n = (Nodo)sender;
            if (e.Button == MouseButtons.Left && dibujar)
            {
                abajo = true;
                inicial = e.Location;
            }
            if (!dibujar)
            {
                if (c1)
                {
                    control1 = n.Location;
                    c2 = !c2;
                    c1 = !c1;
                    aux1 = n;

                    return;
                }
                if (c2)
                {
                    control2 = n.Location;
                    c2 = !c2;
                    c1 = !c1;

                    aux2 = n;

                    //txtLabel.Text = "Se actualizo";
                    if (aux1.Location.X > aux2.Location.X)
                    {
                        aux1.izq = aux2;


                    }
                    if (aux1.Location.X < aux2.Location.X)
                    {
                        aux1.der = aux2;

                    }
                    panelLienzo.Refresh();
                }
            }
        }

        private void btnNodo_Click(object sender, EventArgs e)
        {
            panelLienzo.Controls.Add(new Nodo());
            evento();
        }

        private void btnRama_Click(object sender, EventArgs e)
        {
            dibujar = !dibujar;
        }

        //int cont = 200;
        private void panelLienzo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //MessageBox.Show("Me ejecuto fuera del if");

            if (!dibujar)
            {
                calcularRaiz();
                //MessageBox.Show("Me ejecuto dentro del if : (" + control1.X + "-" + control1.Y + ")(" + control2.X + "-" + control2.Y + ")(");
                //MessageBox.Show("Raiz : "+Raiz);
                pintarRamas(g, Raiz);
                //g.DrawLine(Pens.Red, 0, 0, 200, 200);
            }

        }

        private void pintarRamas(Graphics g, Nodo n)
        {
            if (n != null)
            {
                if (n.izq != null)
                {
                    g.DrawLine(Pens.Red, n.Location.X + 15, n.Location.Y + 30, n.izq.Location.X + 15, n.izq.Location.Y);
                    pintarRamas(g, n.izq);
                }
                if (n.der != null)
                {
                    g.DrawLine(Pens.Blue, n.Location.X + 15, n.Location.Y + 30, n.der.Location.X + 15, n.der.Location.Y);
                    pintarRamas(g, n.der);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcularRaiz();
            txtExprecion.Text = mayor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panelLienzo.Controls.Count > 0)
                panelLienzo.Controls.RemoveAt(panelLienzo.Controls.Count - 1);
        }
    }



    class Nodo : Label
    {

        public String valor = "";
        public Nodo izq = null;
        public Nodo der = null;
        public Point Posicion;
        public Nodo()
        {
            Width = 30;
            Height = 30;
            AutoSize = false;
            Visible = true;
            Enabled = true;
            Paint += new PaintEventHandler(this.paint_Label);
            TextAlign = ContentAlignment.MiddleCenter;
            MouseDown += Nodo_MouseDown;
            Posicion = Location;
        }

        public void asignarPosocion(Point p)
        {
            Location = p;
        }

        private void Nodo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //MessageBox.Show("Se preciono.");
                String v = Interaction.InputBox("Valor del nodo.", "Nodo.", "", -1, -1);
                if (v != "")
                {
                    valor = v;
                    Text = valor;
                }
            }
        }

        override
        public String ToString()
        {
            return valor + "";
        }

        private void paint_Label(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawEllipse(Pens.Black, 0, 0, 29, 29);
        }


        public static String imprimirNodo(Nodo n)
        {
            if (n != null)
            {
                if (n.izq == null && n.der == null)
                {
                    return n.ToString();
                }

                return "(" + imprimirNodo(n.izq) + n + imprimirNodo(n.der) + ")";
            }
            return "";
        }

    }
}
