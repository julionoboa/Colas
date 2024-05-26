using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    internal class Cola
    {
        public Nodo primero; //inicio de la cola
        public Nodo ultimo; //final de la cola

        public Cola() {
            primero = ultimo = null;
        }

        public void encolar(int valor)
        {
            Nodo aux = new Nodo();
            aux.info = valor;
            if (primero == null) //en caso de que la cola este vacia
            {
                primero = ultimo = aux; //ingresamos dato a la cola
                aux.sgte = null; //hacemos que señale a null el nodo
            } else // si la cola no esta vacia
            {
                ultimo.sgte = aux; //el ultimo nodo apunta al nuevo nodo
                aux.sgte = null; //el nuevo nodo apunta a null
                ultimo = aux; //el nuevo nodo es el ultimo
            }
        }

        public void desencolar() //desencola sin decirme valor
        {
            if (primero == null) Console.WriteLine("Cola vacia"); //si la cola esta vacia enviamos mensaje
            else primero = primero.sgte; // cambiamos de posicion el apuntador primero
        }

        public int desencolarValor() //desencola y me muestra valor encolado
        {
            int valor = 0;
            if (primero == null) Console.WriteLine("Cola vacia");
            else
            {
                valor = primero.info;
                primero = primero.sgte;
            } 
            return valor;                
        }

        public void mostrar()
        {
            if (primero == null) Console.WriteLine("Cola vacia");
            else
            {
                Nodo puntero;
                puntero = primero;

                do
                {
                    Console.WriteLine("{0}\t", puntero.info);
                    puntero = puntero.sgte;
                }
                while (puntero != null);
            }
            Console.WriteLine("\n");
        }
    }
}
