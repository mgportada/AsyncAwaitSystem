
namespace Proyecto2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            DateTime inicio = DateTime.Now;
            Console.WriteLine("¡Hora de cenar!");

            Person alice = new Person();
            Task<Burger> burgerTask = alice.PedirBurgerAsync();
            alice.JugarPlay();
            Burger burger = await burgerTask;
            alice.Comer(burger);

            DateTime fin = DateTime.Now;
            TimeSpan tiempoTranscurrido = fin - inicio;
            Console.WriteLine("Tiempo total transcurrido: " + tiempoTranscurrido);
        }
    }

    class Person
    {
        public async Task<Burger> PedirBurgerAsync()
        {
            Console.WriteLine("Realizando llamada...");
            Burger burger = await Hamburgueseria.PrepararPedido();
            return burger;
        }

        public void Comer(Burger burger)
        {
            Console.WriteLine($"Comiendo {burger.Tipo}... (1seg)");
            Thread.Sleep(1000);
        }

        public void JugarPlay()
        {
            Console.WriteLine("Jugando Videojuegos... (5seg)");
            Thread.Sleep(5000);
            Console.WriteLine("Fin de la Partida!");
        }
    }

    class Hamburgueseria
    {
        public static async Task<Burger> PrepararPedido()
        {
            Burger burger = new Burger();
            Console.WriteLine("Burger preparándose... (3seg)");
            await Task.Delay(3000);
            Console.WriteLine("Burger enviándose... (3seg)");
            await Task.Delay(3000);
            Console.WriteLine("Burger llegó!");
            return burger;
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
