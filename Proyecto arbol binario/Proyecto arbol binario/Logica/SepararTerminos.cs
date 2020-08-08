using System;
using System.Windows.Forms;

namespace Proyecto_arbol_binario.Logica
{
    class SepararTerminos
    {
        String[] terminos;
        PilaTermino[] pilaTermino;

        public SepararTerminos(String str)
        {
            //Console.WriteLine("Entro : Seperar terminos");
            if (numeroParentesis(str))
            {
                terminos = new String[0];
                pilaTermino = new PilaTermino[0];

                Terminos(str);
                //Console.WriteLine("Exprecion : "+str+"\nTamaño de pila : "+pilaTermino.Length);

                for (int i = 0; i < pilaTermino.Length; i++)
                {
                    Console.WriteLine("Termino Separar: " + pilaTermino[i].ToString());
                }
            }
            else
            {
                MessageBox.Show("Ingrese el mismo numero de parentesis abiertos y cerrados, gracias ;-)");
            }

        }
        /// <summary>
        /// 1-5
        /// ((3*4)+5)
        /// (5*5)*(5*9)
        /// </summary>
        /// <param name="terminos"></param>
        private void Terminos(String terminos)
        {
            String terminoOriginal = terminos;
            int inic = -1;
            int final = -1;
            String cadenaCortada;
            //contador de id inicializado en cero
            int contadorID = 0;
            for (int i = 0; i < terminos.Length && parentesis(terminos); i++)
            {
                Console.WriteLine("Termino --: " + terminos);
                if (terminos[i] == '(')
                {
                    inic = i;
                }

                if (terminos[i] == ')')
                {

                    final = i;
                    //se extrae el termino con todo y parentesis

                    cadenaCortada = extraerCadena(terminos, inic, final);
                    aumenterTermino(pilaTermino);
                    pilaTermino[contadorID] = new PilaTermino(cadenaCortada, (char)('A' + contadorID));
                    //pilaTermino[contadorID].termino = cadenaCortada;
                    //pilaTermino[contadorID].ID = (char)('A' + contadorID);

                    terminos = quitarParentesis(terminos, inic, final, (char)('A' + contadorID++));
                    inic = 0;
                    final = 0;
                    i = 0;
                    //Console.WriteLine(terminos);
                }

                if (i == terminos.Length - 1)
                {
                    i = 0;
                }
            }
        }

        private bool numeroParentesis(String str)
        {
            int parAbiertos = 0;
            int parCerrados = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(')
                {
                    parAbiertos++;
                }
                if (str[i] == ')')
                {
                    parCerrados++;
                }
            }
            if (parCerrados == parAbiertos)
            {
                return true;
            }
            return false;

        }

        private String quitarParentesis(String str, int inic, int fin, char ID)
        {
            //Console.WriteLine("Entra : " + str);
            String nuevoTermino = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i < inic || i > fin)
                {
                    nuevoTermino += str[i];
                }

                if (i == fin)
                {
                    nuevoTermino += ID + "";
                }

            }
            //Console.WriteLine("Salida : " + nuevoTermino);
            return nuevoTermino;
        }

        private String extraerCadena(String str, int inic, int fin)
        {
            //Console.WriteLine("Cadena : " + str + "  inicio : " + inic + "  fin : " + fin);
            String nuevaCadena = "";
            for (int i = inic; i <= fin; i++)
            {
                nuevaCadena += str[i];
            }

            return nuevaCadena;
        }

        private bool parentesis(String str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(' || str[i] == ')')
                {
                    return true;
                }
            }
            return false;
        }

        private void aumenterTermino(String[] str)
        {
            terminos = new String[str.Length + 1];
            for (int i = 0; i < str.Length; i++)
            {
                terminos[i] = str[i];
            }
        }

        private void aumenterTermino(PilaTermino[] pila)
        {
            pilaTermino = new PilaTermino[pila.Length + 1];
            for (int i = 0; i < pila.Length; i++)
            {
                pilaTermino[i] = pila[i];
            }
        }

        public PilaTermino[] getPilaTerminos()
        {
            return pilaTermino;
        }
    }

    class PilaTermino
    {
        public String termino;
        public char ID;
        public PilaTermino(String ter, char id)
        {
            termino = ter;
            ID = id;
        }

        override
        public String ToString()
        {
            return termino + "   ----   " + ID + "\n";
        }

    }
}
