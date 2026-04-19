internal class Program
{
    private static void Main(string[] args)
    {
        double n1, n2;
        int opcion;

        Console.WriteLine("Ingrese primer numero:");
        n1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese segundo numero:");
        n2 = double.Parse(Console.ReadLine());

        Console.WriteLine("1 Sumar");
        Console.WriteLine("2 Restar");
        Console.WriteLine("3 Multiplicar");
        Console.WriteLine("4 Dividir");

        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Resultado: " + (n1 + n2));
                break;

            case 2:
                Console.WriteLine("Resultado: " + (n1 - n2));
                break;

            case 3:
                Console.WriteLine("Resultado: " + (n1 * n2));
                break;

            case 4:
                Console.WriteLine("Resultado: " + (n1 / n2));
                break;

            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}