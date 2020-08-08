using System;

namespace Proyecto_arbol_binario.Configuracion
{
    class Adaptador
    {
        Nodo[] pilaNodo;
        Nodo raiz;
        public Adaptador(Proyecto_arbol_binario.Logica.PilaTermino[] pila)
        {

            if (pila != null)
            {
                //Console.WriteLine("Entro : Adaptador");
                //char id;
                pilaNodo = new Configuracion.Nodo[0];
                for (int i = 0; i < pila.Length; i++)
                {
                    //Console.WriteLine("Tamaño de pilaNodo : "+pilaNodo.Length);
                    aumentarFila(pilaNodo);
                    pilaNodo[i] = new Nodo(pila[i].termino, pila[i].ID);
                    //Console.WriteLine(pilaNodo[i].izq +"   ---   "+ pilaNodo[i].ToString()+"   ---   "+ pilaNodo[i].Der.ToString());
                }
                //OrganizarNodos(pila);
                cambiarIDporNodo(pila);
                //Console.WriteLine("tamaño de pilaNodo : "+pilaNodo.Length+"\ntamaño de pilaExpreciones : "+pila.Length);
                raiz = pilaNodo[pilaNodo.Length - 1];
                //Nodo.imprimir(pilaNodo[pilaNodo.Length - 1]);

            }

        }

        public Nodo getRaiz()
        {
            return raiz;
        }

        private void cambiarIDporNodo(Logica.PilaTermino[] pila)
        {
            int i = 0;
            char id;
            String ext;
            Nodo aux = null; ;
            String pos;
            while (i < pila.Length)
            {
                // Console.WriteLine("Accediendo al indice : " + i);
                ext = pila[i].termino;
                id = getIDTermino(ext);
                for (int c = 0; c < pila.Length; c++)
                {
                    if (pila[c].ID == id)
                    {
                        //Console.WriteLine("Solo exprecion : " + pila[c].termino + "  ID : " + pila[c].ID);
                        //Console.WriteLine("Pila nodo : " + pilaNodo[c].izq + "   ---   " + pilaNodo[c].valor + "   ---   " + pilaNodo[c].Der);
                        aux = pilaNodo[c];
                        pos = posID(id, ext);
                        //Console.WriteLine(aux.izq + "   ---   " + aux + "   ---   " + aux.Der);
                        if (pos.Equals("IZQ"))
                        {
                            //pilaNodo[i].izq = new Nodo(aux);
                            pilaNodo[i].izq = new Nodo(aux);
                        }
                        else //if (pos.Equals("DER"))
                        {
                            pilaNodo[i].Der = new Nodo(aux);
                        }
                    }
                }
                pila[i].termino = pila[i].termino.Replace(id + "", "");
                //Console.WriteLine(pila[i].termino);
                if (existID(pila[i].termino))
                {
                    //Console.WriteLine("aumenta " + i + "   ----   " + pila[i].termino);
                    i--;
                }
                else
                {
                    i++;
                }
            }
        }

        private String posID(char id, String exp)
        {
            bool cierto = false;
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '+' || exp[i] == '-' || exp[i] == '*' || exp[i] == '/' || exp[i] == '^')
                {
                    cierto = !cierto;
                }
                if (exp[i] >= 'A' && exp[i] <= 'Z')
                {
                    if (cierto)
                    {
                        return "DER";
                    }
                    else
                    {
                        return "IZQ";
                    }
                }
            }
            return "IZQ";
        }

        private void OrganizarNodos(Logica.PilaTermino[] pila)
        {
            //Nodo n = null;
            int cont = 0;
            char id;
            for (int j = 0; j < pila.Length; j++)
            {
                while (existID(pila[cont].termino))
                {
                    id = getIDTermino(pila[j].termino);
                    //Console.WriteLine("Me ejecuto "+pila[cont].termino+" ID : "+id);

                    for (int i = 0; i < pila.Length; i++)
                    {
                        if (pilaNodo[i].izq.ID == id)
                        {
                            pilaNodo[i].izq = pilaNodo[j];
                        }
                        if (pilaNodo[i].Der.ID == id)
                        {
                            pilaNodo[i].Der = pilaNodo[j];
                        }
                    }
                    pila[cont].termino = pila[cont].termino.Replace(id + "", "");

                }
                cont++;
            }

            //Console.WriteLine("Termino de unir los nodos");
            Nodo.imprimir(pilaNodo[pilaNodo.Length - 1]);
        }

        private char getIDTermino(String exp)
        {
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] >= 'A' && exp[i] <= 'Z')
                {
                    return exp[i];
                }
            }

            //no tiene que llegar nunca
            return '\0';
        }

        private bool existID(String exp)
        {
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] >= 'A' && exp[i] <= 'Z')
                {
                    return true;
                }
            }
            return false;
        }

        private void aumentarFila(Nodo[] pila)
        {
            pilaNodo = new Nodo[pila.Length + 1];
            for (int i = 0; i < pila.Length; i++)
            {
                pilaNodo[i] = pila[i];
            }

        }
    }
    class Nodo
    {
        public String valor;
        public Nodo izq = null;
        public Nodo Der = null;
        public Char ID;

        public Nodo(Nodo n)
        {
            valor = n.valor;
            izq = n.izq;
            Der = n.Der;
            ID = n.ID;
        }

        public Nodo(String exp, char id)
        {
            ID = id;
            String newExprecion = exp.Replace("(", "");
            newExprecion = newExprecion.Replace(")", "");
            //Console.WriteLine("Nueva exprecion : " + newExprecion);

            if (newExprecion.Length == 3)
            {
                //Console.WriteLine("Entre 3 : " + newExprecion);
                valor = newExprecion[1] + "";
                izq = new Nodo(newExprecion[0] + "", id);
                Der = new Nodo(newExprecion[2] + "", id);
            }
            else if (newExprecion.Length == 1)
            {
                //Console.WriteLine("Entre 1 : " + newExprecion);
                valor = newExprecion;
            }
        }

        public int nodosCompletos(Nodo n)
        {
            if (n == null) return 0;
            if (n.izq != null && n.Der != null)
            {
                return nodosCompletos(n.izq) + nodosCompletos(n.Der) + 1;
            }
            return nodosCompletos(n.izq) + nodosCompletos(n.Der);
        }

        public static void imprimir(Nodo n)
        {
            //Console.WriteLine("Se va a imprimir");
            if (n != null)
            {
                imprimir(n.izq);

                imprimir(n.Der);
                Console.WriteLine(n);
            }
        }

        override
        public String ToString()
        {
            return valor;
        }
    }
}
