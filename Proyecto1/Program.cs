namespace Proyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime inicio = DateTime.Now;
            Console.WriteLine("¡Hora de cenar!");

            Person alice = new Person();
            Burger burger = alice.PedirBurger();
            alice.jugarPlay();
            alice.Comer(burger);


            DateTime fin = DateTime.Now;
            TimeSpan tiempoTranscurrido = fin - inicio;
            Console.WriteLine("Tiempo total transcurrido: " + tiempoTranscurrido);
        }

    }

    class Hamburgueseria
    {
        public static Burger PrepararPedido()
        {
            Burger burger = new Burger();
            Console.WriteLine("Burger preparandose... (3seg)");
            Thread.Sleep(3000);
            Console.WriteLine("Burger enviandose... (3seg)");
            Thread.Sleep(3000);
            Console.WriteLine("Burger llego!");
            return burger;
        }
    }

    class Person()
    {
        public Burger PedirBurger()
        {
            Console.WriteLine("Realizando llamada!");
            Burger burger = Hamburgueseria.PrepararPedido();
            return burger;
        }

        public void Comer(Burger burger)
        {
            Console.WriteLine($"Comiendo {burger.Tipo}... (1seg)");
            Thread.Sleep(1000);
        }

        public void jugarPlay()
        {
            Console.WriteLine("Jugando Videojuegos... (5seg)");
            Thread.Sleep(5000);
        }
    }


    class Burger
    {
        public string Tipo { get; set; }
        public Burger()
        {
            Tipo = "Cheese Burger";
        }
    }

}