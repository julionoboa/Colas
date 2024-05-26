namespace Colas
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola cola = new Cola();
            Console.WriteLine("Colocando cinco elementos en la cola");

            cola.encolar(3);
            cola.encolar(27);
            cola.encolar(5);
            cola.encolar(22);
            cola.encolar(23);
            cola.mostrar();

            Console.WriteLine("Retirando dos elementos en cola");
            cola.desencolar();
            cola.mostrar();
            cola.desencolarValor();
            cola.mostrar();

            Console.WriteLine("Se va a retirar un nodo mas, con el valor de {0}", cola.desencolarValor());

            cola.mostrar();
            Console.ReadLine();
        }
    }
}
