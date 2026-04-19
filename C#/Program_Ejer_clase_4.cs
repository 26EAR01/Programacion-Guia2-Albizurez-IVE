internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;

        Console.WriteLine("1 Hamburguesa");
        Console.WriteLine("2 Pizza");
        Console.WriteLine("3 Pollo frito");
        Console.WriteLine("4 Ensalada");

        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Usted pidio Hamburguesa");
                break;

            case 2:
                Console.WriteLine("Usted pidio Pizza");
                break;

            case 3:
                Console.WriteLine("Usted pidio Pollo frito");
                break;

            case 4:
                Console.WriteLine("Usted pidio Ensalada");
                break;

            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}