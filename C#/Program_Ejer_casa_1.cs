internal class Program
{
    private static void Main(string[] args)
    {
        double angulo;
        int opcion;
        double resultado = 0;

        Console.WriteLine("Ingrese el angulo en grados:");
        angulo = double.Parse(Console.ReadLine());

        Console.WriteLine("Seleccione una funcion:");
        Console.WriteLine("1 - Seno");
        Console.WriteLine("2 - Coseno");
        Console.WriteLine("3 - Tangente");

        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                resultado = Math.Sin(angulo * Math.PI / 180);
                Console.WriteLine("El seno es: " + resultado);
                break;

            case 2:
                resultado = Math.Cos(angulo * Math.PI / 180);
                Console.WriteLine("El coseno es: " + resultado);
                break;

            case 3:
                resultado = Math.Tan(angulo * Math.PI / 180);
                Console.WriteLine("La tangente es: " + resultado);
                break;

            default:
                Console.WriteLine("Opcion invalida");
                break;
        }
    }
}